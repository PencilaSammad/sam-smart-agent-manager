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
        public AgentSettings? currentAgentSettings { get; private set; }
        internal Conversation conversation { get; private set; }

        public SmartAgent(AgentSettings? selectedAgentSettings = null)
        {
            InitializeComponent();

            if (selectedAgentSettings != null)
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

                // Create a new agent settings object
                AgentSettings agentSettings = new AgentSettings
                {
                    AgentName = txtAgentName.Text,
                    AgentID = txtAgentID.Text,
                    AgentPersonality = txtAgentPersonality.Text,
                    SlaveAgents = new List<AgentSettings> { }
                };
                selectedAgentSettings = agentSettings;
            }
            this.currentAgentSettings = selectedAgentSettings;
            LoadSlaveAgents();
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

            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();

            // Create a new agent settings object
            AgentSettings agentSettings = new AgentSettings
            {
                AgentName = txtAgentName.Text,
                AgentID = txtAgentID.Text,
                AgentPersonality = txtAgentPersonality.Text
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
            SendUserConversationMessageAsync();
            
        }

        private void AppendTextToChat(string text, Color color)
        {
            // Set the color of the text that will be appended
            txtChat.SelectionColor = color;

            // Append the text to the control
            txtChat.AppendText(text);

            // Add a new line
            txtChat.AppendText(Environment.NewLine);
            txtChat.AppendText(Environment.NewLine);
        }

        private async Task SendUserConversationMessageAsync()
        {
            if (conversation == null)
            {
                List<string> systemPersonality = new List<string> { };

                systemPersonality.Add(txtAgentPersonality.Text);

                conversation = new Conversation(SamUserSettings.Default.GPT_API_KEY, systemPersonality);
                if (txtUserInput.Text != "")
                {
                    string userInput = txtUserInput.Text;

                    // Append the user's input to the chat with green text
                    AppendTextToChat(userInput, Color.Green);

                    // Start the conversation and append the system's response with blue text
                    string response = await conversation.StartConversation(userInput);
                    AppendTextToChat(response, Color.Blue);

                    // Clear the user input field
                    txtUserInput.Text = "";
                };

            }
            else
            {
                if (txtUserInput.Text != "")
                {
                    string userInput = txtUserInput.Text;

                    // Append the user's input to the chat with green text
                    AppendTextToChat(userInput, Color.Green);

                    // Start the conversation and append the system's response with blue text
                    string response = await conversation.StartConversation(userInput);
                    AppendTextToChat(response, Color.Blue);

                    // Clear the user input field
                    txtUserInput.Text = "";
                };
            }
        }
    }
}
