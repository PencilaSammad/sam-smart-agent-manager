using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using WeifenLuo.WinFormsUI.Docking;

namespace sam
{
    public partial class SAM : Form
    {
        public List<SmartAgent> activeSmartAgents { get; set; }= new List<SmartAgent>();

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
            SmartAgent smartAgent = new SmartAgent(null,this);
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

       
    }
}