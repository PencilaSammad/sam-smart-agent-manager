using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using NAudio.Wave;

namespace sam
{
    public partial class SAM : Form
    {
        private bool audioRecordingActive;
        private WaveFileWriter writer;
        private WasapiLoopbackCapture capture;
        public List<SmartAgent> activeSmartAgents { get; set; } = new List<SmartAgent>();
        private WaveFileWriter computerAudioWriter;
        private WaveFileWriter micWriter;
        private WasapiLoopbackCapture computerAudioCapture;
        private WaveInEvent micCapture;
        public SAM()
        {
            InitializeComponent();
            dockPanelSAM.DocumentStyle = DocumentStyle.DockingWindow;

            dockPanelSAM.Theme = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
            DockPaneStripSkin dockPaneSkin = new DockPaneStripSkin();
            dockPaneSkin.DocumentGradient.DockStripGradient.LinearGradientMode = LinearGradientMode.Vertical;
            dockPaneSkin.DocumentGradient.DockStripGradient.StartColor = Color.Silver;
            dockPaneSkin.DocumentGradient.DockStripGradient.EndColor = Color.White;

            dockPaneSkin.DocumentGradient.ActiveTabGradient.StartColor = Color.White;
            dockPaneSkin.DocumentGradient.ActiveTabGradient.EndColor = Color.White;
            dockPaneSkin.DocumentGradient.ActiveTabGradient.TextColor = Color.FromArgb(32, 32, 32);

            dockPaneSkin.DocumentGradient.InactiveTabGradient.LinearGradientMode = LinearGradientMode.Vertical;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.StartColor = Color.Silver;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.EndColor = Color.WhiteSmoke;
            dockPaneSkin.DocumentGradient.InactiveTabGradient.TextColor = Color.White;
            dockPanelSAM.ShowDocumentIcon = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to close SAM?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void newSmartAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartAgent smartAgent = new SmartAgent(null, this);
            activeSmartAgents.Add(smartAgent);
            smartAgent.Show(dockPanelSAM);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SamSettings sSettings = new SamSettings();
            sSettings.Show();
        }

        private void loadSmartAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new form to display the agent settings
            SelectAgentSettings agentSettingsForm = new SelectAgentSettings();

            // Deserialize the agent settings collection from application settings
            List<AgentSettings> agentSettingsList = new List<AgentSettings>();
            if (!string.IsNullOrEmpty(SamUserSettings.Default.AgentSettingsList))
            {
                agentSettingsList = JsonConvert.DeserializeObject<List<AgentSettings>>(SamUserSettings.Default.AgentSettingsList);
            }

            // If the collection is empty, show an error message and return
            if (agentSettingsList == null || agentSettingsList.Count == 0)
            {
                MessageBox.Show("No agents saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show the agent settings form to allow the user to select an agent
            agentSettingsForm.AgentSettingsList = agentSettingsList;
            DialogResult result = agentSettingsForm.ShowDialog();

            // If the user clicks "Cancel", return
            if (result == DialogResult.Cancel)
            {
                return;
            }

            // Get the selected agent settings object
            AgentSettings selectedAgentSettings = agentSettingsForm.SelectedAgentSettings;

            // Create a new SmartAgent form with the selected settings
            SmartAgent smartAgent = new SmartAgent(selectedAgentSettings, this);
            activeSmartAgents.Add(smartAgent);

            // Show the SmartAgent form
            smartAgent.Show(dockPanelSAM);


        }

        private void btnRecAudio_Click(object sender, EventArgs e)
        {
            if(audioRecordingActive)
            {
                btnRecAudio.Image = sam.Properties.Resources.sharp_sensors_off_black_24dp;
                audioRecordingActive=false;
                StopRecording();
            }
            else
            {
                btnRecAudio.Image = sam.Properties.Resources.sharp_sensors_black_24dp;
                audioRecordingActive=true;
                StartRecording();
            }
        }

        public void StartRecording()
        {
            // Create the directory for recordings if it does not exist
            Directory.CreateDirectory(@"rec");

            // Create a filename for the recording based on the current date and time
            string filename = string.Format(@"rec\recording-{0:yyyy-MM-dd-HH-mm-ss}.wav", DateTime.Now);

            // Set up recording device for computer audio
            computerAudioCapture = new WasapiLoopbackCapture();
            computerAudioCapture.DataAvailable += (sender, e) =>
            {
                // Write data to computer audio WAV file
                computerAudioWriter.Write(e.Buffer, 0, e.BytesRecorded);
            };
            computerAudioWriter = new WaveFileWriter(filename + "-computerAudio.wav", computerAudioCapture.WaveFormat);

            // Set up recording device for mic audio
            micCapture = new WaveInEvent();
            micCapture.DeviceNumber = -1;
            for (int n = 0; n < WaveInEvent.DeviceCount; n++)
            {
                var capabilities = WaveInEvent.GetCapabilities(n);
                if (capabilities.ProductName.Contains("Microphone"))
                {
                    micCapture.DeviceNumber = n;
                    break;
                }
            }
            micCapture.DataAvailable += (sender, e) =>
            {
                // Write data to mic audio WAV file
                micWriter.Write(e.Buffer, 0, e.BytesRecorded);
            };
            micWriter = new WaveFileWriter(filename + "-micAudio.wav", micCapture.WaveFormat);

            // Start recording
            computerAudioCapture.StartRecording();
            micCapture.StartRecording();
        }

        public void StopRecording()
        {
            // Stop recording
            computerAudioCapture.StopRecording();
            micCapture.StopRecording();

            // Clean up resources
            computerAudioWriter?.Dispose();
            micWriter?.Dispose();
            computerAudioCapture?.Dispose();
            micCapture?.Dispose();
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            // Write audio data to the WaveFileWriter
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            // Dispose of the WaveFileWriter and WasapiLoopbackCapture
            writer.Dispose();
            capture.Dispose();
        }
    }
}