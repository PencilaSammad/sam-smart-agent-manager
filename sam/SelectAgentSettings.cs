using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sam
{
    public partial class SelectAgentSettings : Form
    {
        public SelectAgentSettings()
        {
            InitializeComponent();
        }

        internal List<AgentSettings> AgentSettingsList { get; set; }
        internal AgentSettings SelectedAgentSettings { get; set; }
        public List<AgentSettings> loadedAgentSettings { get; private set; }

        private void SelectAgentSettings_Load(object sender, EventArgs e)
        {
            // Deserialize the agent settings collection from application settings
            // Retrieve existing agent settings from the settings field
            loadedAgentSettings = new List<AgentSettings>();
            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();

            List<AgentSettings> agentSettingsList = agentSettingsManager.LoadAgentSettings();


            // Add each agent to the list box
            if (agentSettingsList != null)
            {
                foreach (var agent in agentSettingsList)
                {
                    if (agent.AgentName != null)
                    {
                        lbAgentList.Items.Add(agent.AgentName);
                        // Create a new agent settings object
                        AgentSettings agens = new AgentSettings
                        {
                            AgentName = agent.AgentName,
                            AgentID = agent.AgentID,
                            AgentPersonality = agent.AgentPersonality,
                            SlaveAgentMessage=agent.SlaveAgentMessage
                            
                        };
                        loadedAgentSettings.Add(agens);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected agent from the list box
            string selectedAgentName = lbAgentList.SelectedItem?.ToString();
            if (selectedAgentName != null)
            {
                // Find the agent settings object with the selected name
                SelectedAgentSettings = loadedAgentSettings.Find(x => x.AgentName == selectedAgentName);
            }

            // Set the dialog result to OK
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set the dialog result to Cancel
            DialogResult = DialogResult.Cancel;
        }

        private void lbAgentList_SelectedValueChanged(object sender, EventArgs e)
        {
            /// Get the selected agent from the list box
            string selectedAgentName = lbAgentList.SelectedItem?.ToString();

            if (selectedAgentName != null)
            {
                // Find the agent settings object with the selected name
                SelectedAgentSettings = loadedAgentSettings.Find(x => x.AgentName == selectedAgentName);
            }
            if (selectedAgentName != null)
            {
                // Set the agent personality in the text box
                txtAgentPersonality.Text = SelectedAgentSettings.AgentPersonality;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbAgentList.Items.Clear();
            txtAgentPersonality.Text = "";
            SamUserSettings.Default.AgentSettingsList = "";
            SamUserSettings.Default.Save();
        }
    }
}
