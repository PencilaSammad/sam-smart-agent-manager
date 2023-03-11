using System.Data;
using System.Diagnostics;
using System.IO;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using WeifenLuo.WinFormsUI.Docking;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sam
{
    public partial class SmartAgent : DockContent
    {
        public AgentSettings? currentAgentSettings { get; private set; }
        internal Conversation conversation { get; private set; }
        public SAM parentSAM { get; }
        public bool ttsActive { get; private set; }
        public string ttsSelectedVoice { get; private set; }
       

        private List<InstalledVoice> _installedVoices;
        public SmartAgent(AgentSettings? selectedAgentSettings = null, SAM sAM = null)
        {
            InitializeComponent();
            parentSAM = sAM;
            if (selectedAgentSettings != null)
            {
                txtAgentPersonality.Text = selectedAgentSettings.AgentPersonality;
                txtAgentName.Text = selectedAgentSettings.AgentName;
                txtAgentID.Text = selectedAgentSettings.AgentID;
                txtSlaveMessage.Text = selectedAgentSettings.SlaveAgentMessage;
            }
            else
            {
                txtAgentPersonality.Text = SamUserSettings.Default.DefaultAgentPersonality;
                txtAgentName.Text = GenerateRandomAgentName();
                txtAgentID.Text = Guid.NewGuid().ToString();

                // Create a new agent settings object
                AgentSettings agentSettings = new AgentSettings
                {
                    AgentName = txtAgentName.Text,
                    AgentID = txtAgentID.Text,
                    AgentPersonality = txtAgentPersonality.Text,
                    SlaveAgents = new List<AgentSettings> { },
                    SlaveAgentMessage = txtSlaveMessage.Text

                };
                selectedAgentSettings = agentSettings;
            }
            this.currentAgentSettings = selectedAgentSettings;
            LoadSlaveAgents();

            //Load voices
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                SpeechApiReflectionHelper.InjectOneCoreVoices(synth);
                foreach (var voice in synth.GetInstalledVoices())
                {
                    ttsVoice.Items.Add(voice.VoiceInfo.Name);
                    ttsVoice.Text = voice.VoiceInfo.Name;
                    ttsSelectedVoice = voice.VoiceInfo.Name;
                }
            }
            


        }

        private void LoadSlaveAgents()
        {
            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();

            var slaveAgents = agentSettingsManager.LoadAgentSettings();
            var agentSetting = agentSettingsManager.LoadAgentSetting(currentAgentSettings.AgentName);
            if (slaveAgents != null)
            {
                foreach (var slaveAgent in slaveAgents)
                {

                    checkedListSelectedSlaves.Items.Add(slaveAgent.AgentName);
                }
                if (agentSetting.SlaveAgents != null)
                {
                    var itemsToCheck = new List<object>(); // create a new list to hold the items that need to be checked
                    foreach (var agentSlave in agentSetting.SlaveAgents)
                    {
                        foreach (var availableSlaves in checkedListSelectedSlaves.Items)
                        {
                            if (agentSlave.AgentName == availableSlaves.ToString())
                            {
                                itemsToCheck.Add(availableSlaves); // add the item to the list of items to check
                            }
                        }
                    }
                    foreach (var item in itemsToCheck)
                    {
                        checkedListSelectedSlaves.SetItemChecked(checkedListSelectedSlaves.Items.IndexOf(item), true); // check the items outside of the loop
                    }
                }
            }

        }

        private void SmartAgent_Load(object sender, EventArgs e)
        {

        }

        private string GenerateRandomAgentName()
        {
            // Create an array of twenty possible agent name options
            string[] agentNames = new string[] { "Alex", "Avery", "Brooke", "Cameron", "Dakota", "Jordan", "Morgan", "Riley", "Taylor", "Logan", "Evelyn", "Madison", "Peyton", "Sydney", "Bailey", "Reagan", "Charlie", "Hayden", "Harper", "Parker", "Ariel", "Phoenix", "Rowan", "Sage", "Aspen", "Emerson", "Dallas", "Skyler", "Casey", "Kendall", "Cassidy" };

            // Generate a random number between 0 and 19 to select a random agent name from the array
            int index = new Random().Next(0, 20);

            // Return the selected agent name
            return agentNames[index];
        }

        private void btnSaveAgent_Click(object sender, EventArgs e)
        {
            SaveAgentSettings();
        }

        private void SaveAgentSettings()
        {

            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();

            // Create a new agent settings object
            AgentSettings agentSettings = new AgentSettings
            {
                AgentName = txtAgentName.Text,
                AgentID = txtAgentID.Text,
                AgentPersonality = txtAgentPersonality.Text,
                SlaveAgentMessage = txtSlaveMessage.Text
            };

            List<AgentSettings> slaveAgents = new List<AgentSettings>();
            foreach (string slave in checkedListSelectedSlaves.CheckedItems)
            {
                slaveAgents.Add(agentSettingsManager.LoadAgentSetting(slave));
            }
            agentSettings.SlaveAgents = slaveAgents;
            agentSettingsManager.SaveAgentSettings(agentSettings);

            MessageBox.Show("Agent settings saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Task.Run(() => SendUserConversationMessageAsync());

        }

        private void AppendTextToChat(string text, Color color)
        {
            // Set the color of the text that will be appended
            txtChat.SelectionColor = color;

            // Append the text to the control
            txtChat.AppendText(text);
            txtCode.AppendText(text);

            if (ttsActive)
            {
                if(SamUserSettings.Default.AZURE_API_KEY != "" && SamUserSettings.Default.AZURE_TTS_REGION != "" && SamUserSettings.Default.AZURE_TTS_VOICE != "")
                {
                    if (color == Color.Blue) { Task.Run(() => SpeakAzureTextAsync(text)); }
                }
                else
                {
                    if (color == Color.Blue) { Task.Run(() => SpeakTextAsync(text)); }
                }
                
            }

            // Add a new line
            txtChat.AppendText(Environment.NewLine);
            txtChat.AppendText(Environment.NewLine);

            // Add a new line
            txtCode.AppendText(Environment.NewLine);
            txtCode.AppendText(Environment.NewLine);
        }

        private async Task SpeakAzureTextAsync(string text)
        {
            AzureTextToSpeech azureTTS = new AzureTextToSpeech(SamUserSettings.Default.AZURE_API_KEY, SamUserSettings.Default.AZURE_TTS_REGION, SamUserSettings.Default.AZURE_TTS_VOICE);
            azureTTS.SynthesizeAsync(text);
        }

        private async Task SendUserConversationMessageAsync()
        {
            Invoke((Action)(() => { StartAnalysis(); }));
            if (conversation == null)
            {
                List<string> systemPersonality = new List<string> { };

                systemPersonality.Add(txtAgentPersonality.Text);

                conversation = new Conversation(SamUserSettings.Default.GPT_API_KEY, systemPersonality, txtAgentID.Text);
                foreach (var chat in conversation.chatHistory)
                {
                    if (chat.Role == "user")
                    {
                        // Append the user's input to the chat with green text
                        Invoke((Action)(() =>
                        {
                            AppendTextToChat(chat.Content, Color.Green);
                        }));
                    }
                    else
                    {
                        // Append the gpt input to the chat with blue text
                        Invoke((Action)(() =>
                        {
                            AppendTextToChat(chat.Content, Color.Blue);
                        }));
                    }
                }
                if (txtUserInput.Text != "")
                {
                    string userInput = txtUserInput.Text;

                    // Append the user's input to the chat with green text
                    Invoke((Action)(() =>
                    {
                        AppendTextToChat(userInput, Color.Green);
                    }));
                    // Clear the user input field
                    Invoke((Action)(() =>
                    {
                        txtUserInput.Text = "";
                    }));

                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.StartConversation(userInput);
                    foreach (string s in response)
                    {
                        Invoke((Action)(() => { AppendTextToChat(s, Color.Blue); }));
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        Invoke((Action)(() => { SendSmartAgentResponseToSlaves(response); }));
                    }


                };

            }
            else
            {
                if (txtUserInput.Text != "")
                {
                    string userInput = txtUserInput.Text;

                    // Append the user's input to the chat with green text
                    Invoke((Action)(() =>
                    {
                        AppendTextToChat(userInput, Color.Green);
                    }));
                    // Clear the user input field
                    Invoke((Action)(() =>
                    {
                        txtUserInput.Text = "";
                    }));
                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.StartConversation(userInput);
                    foreach (string s in response)
                    {
                        Invoke((Action)(() =>
                        {
                            AppendTextToChat(s, Color.Blue);
                        }));
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        Invoke((Action)(() => { SendSmartAgentResponseToSlaves(response); }));
                    }

                };
            }
            // Raise the AnalysisComplete event
            Invoke((Action)(() => { OnAnalysisComplete(); }));
        }

        private void SendSmartAgentResponseToSlaves(List<string> response)
        {
            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();
            List<AgentSettings> slaveAgents = new List<AgentSettings>();
            foreach (string slave in checkedListSelectedSlaves.CheckedItems)
            {
                slaveAgents.Add(agentSettingsManager.LoadAgentSetting(slave));
            }
            foreach (SmartAgent slave in parentSAM.activeSmartAgents)
            {
                foreach (AgentSettings agentSettings in slaveAgents)
                {
                    if (slave.currentAgentSettings.AgentName == agentSettings.AgentName)
                    {
                        slave.SendSlaveMessageAsync(txtSlaveMessage.Text + String.Join(" ", response));
                    }
                }
            }


        }

        private async Task SendSlaveMessageAsync(string slaveMessage)
        {
            if (chkSmartAgentEnabled.Checked)
            {
                txtUserInput.Text = slaveMessage;
                await SendUserConversationMessageAsync();
            }
        }

        private void SmartAgent_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentSAM.activeSmartAgents.Remove(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            if (conversation != null)
            {
                conversation.ClearChatHistory();
                conversation = null;
            }
            txtChat.Text = "";
            txtCode.SelectAll();
            txtCode.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to only allow WAV files
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";

            // Set the initial directory to the recordings directory
            openFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "rec");

            // Show the file dialog and wait for the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path and do something with it
                string selectedFilePath = openFileDialog.FileName;

                // Start the analysis task on a background thread
                Task.Run(() => AnalyzeAudioAsync(selectedFilePath));

            }

        }


        private void OnAnalysisComplete()
        {
            agentStatusLabel.Text = "Ready";
            agentProgress.Visible = false;
        }

        private void StartAnalysis()
        {
            agentStatusLabel.Text = "Analyzing";
            agentProgress.Visible = true;
        }

        private async Task AnalyzeAudioAsync(string selectedFilePath)
        {
            Invoke((Action)(() =>
            {
                StartAnalysis();
            }));
            if (conversation == null)
            {
                List<string> systemPersonality = new List<string> { };

                systemPersonality.Add(txtAgentPersonality.Text);

                conversation = new Conversation(SamUserSettings.Default.GPT_API_KEY, systemPersonality, txtAgentID.Text);

                if (selectedFilePath != "")
                {

                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.AnalyzeAudio(selectedFilePath);
                    foreach (string s in response)
                    {
                        Invoke((Action)(() => { AppendTextToChat(s, Color.Blue); }));
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        Invoke((Action)(() => { SendSmartAgentResponseToSlaves(response); }));
                    }


                };

            }
            else
            {
                if (selectedFilePath != "")
                {

                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.AnalyzeAudio(selectedFilePath);
                    foreach (string s in response)
                    {
                        Invoke((Action)(() => { AppendTextToChat(s, Color.Blue); }));
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        Invoke((Action)(() => { SendSmartAgentResponseToSlaves(response); }));
                    }

                };
            }
            // Raise the AnalysisComplete event
            Invoke((Action)(() =>
            {
                OnAnalysisComplete();
            }));

        }

        private void btnTTS_Click(object sender, EventArgs e)
        {
            if (ttsActive)
            {
                btnTTS.Image = sam.Properties.Resources.mute_sound_speaker_volume_icon;
                ttsActive = false;           
            }
            else
            {
                btnTTS.Image = sam.Properties.Resources.lound_sound_speaker_volume_icon;
                ttsActive = true;
            }
        }

        private async Task SpeakTextAsync(string speak)
        {
            try
            {


                // Initialize a new instance of the SpeechSynthesizer.  
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    SpeechApiReflectionHelper.InjectOneCoreVoices(synth);
                    foreach (var voice in synth.GetInstalledVoices())
                    {
                        Console.WriteLine(voice.VoiceInfo.Name);
                    }
                    // Set a value for the speaking rate.  
                    synth.Rate = 1;
                    synth.SelectVoice(ttsSelectedVoice);
                    // Configure the audio output.   
                    synth.SetOutputToDefaultAudioDevice();

                    // Create a prompt from a string.  
                    Prompt color = new Prompt(speak);

                    // Speak the contents of the prompt synchronously.  
                    synth.Speak(color);
                }
            }
            catch (Exception ex)
            {
                // Handle any other errors that may occur
                Debug.WriteLine($"Error in SpeakTextAsync: {ex.Message}");
            }
        }

        private void ttsVoice_TextChanged(object sender, EventArgs e)
        {
            ttsSelectedVoice = ttsVoice.Text;
        }
    }
}
