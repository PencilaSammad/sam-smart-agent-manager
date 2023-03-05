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
using WeifenLuo.WinFormsUI.Docking;

namespace sam
{
    public partial class SmartAgent : DockContent
    {
        public SmartAgent(AgentSettings? selectedAgentSettings = null)
        {
            InitializeComponent();
            if (selectedAgentSettings != null )
            {
                txtAgentPersonality.Text = selectedAgentSettings.AgentPersonality;
                txtAgentName.Text = selectedAgentSettings.AgentName;
                txtAgentID.Text = selectedAgentSettings.AgentID;
            }
            else
            {
                txtAgentPersonality.Text = SamUserSettings.Default.DefaultAgentPersonality;
                txtAgentName.Text = GenerateRandomAgentName();
                txtAgentID.Text = Guid.NewGuid().ToString();
            }
        }

        private void SmartAgent_Load(object sender, EventArgs e)
        {
            
        }

        private string GenerateRandomAgentName()
        {
            // Create an array of ten possible agent name options
            string[] agentNames = new string[] { "Alex", "Avery", "Brooke", "Cameron", "Dakota", "Jordan", "Morgan", "Riley", "Taylor", "Logan", "Evelyn", "Madison", "Peyton", "Sydney", "Bailey", "Reagan", "Charlie", "Hayden", "Harper", "Parker", "Ariel" };

            // Generate a random number between 0 and 9 to select a random agent name from the array
            int index = new Random().Next(0, 10);

            // Return the selected agent name
            return agentNames[index];
        }

        private void btnSaveAgent_Click(object sender, EventArgs e)
        {
            SaveAgentSettings();
        }

        private void SaveAgentSettings()
        {
            // Create a new agent settings object
            AgentSettings agentSettings = new AgentSettings
            {
                AgentName = txtAgentName.Text,
                AgentID = txtAgentID.Text,
                AgentPersonality = txtAgentPersonality.Text
            };
            List<AgentSettings> loadedAgentSettings = new List<AgentSettings>();
            // Retrieve existing agent settings from the settings field
            dynamic agentSettingsList = new List<AgentSettings>();
            if (!string.IsNullOrEmpty(SamUserSettings.Default.AgentSettingsList))
            {
                agentSettingsList = JsonConvert.DeserializeObject(SamUserSettings.Default.AgentSettingsList);
            }

            // Add the new agent settings object to the collection
            // Add each agent to the list box
            foreach (var agent in agentSettingsList)
            {
                if (agent.AgentName != null)
                {
                    // Create a new agent settings object
                    AgentSettings agens = new AgentSettings
                    {
                        AgentName = agent.AgentName,
                        AgentID = agent.AgentID,
                        AgentPersonality = agent.AgentPersonality
                    };
                    loadedAgentSettings.Add(agens);
                }
            }
            loadedAgentSettings.Add(agentSettings);

            // Serialize and save the updated agent settings collection to application settings
            string serializedAgentSettings = JsonConvert.SerializeObject(loadedAgentSettings);
            SamUserSettings.Default.AgentSettingsList = serializedAgentSettings;
            SamUserSettings.Default.Save();

            MessageBox.Show("Agent settings saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
