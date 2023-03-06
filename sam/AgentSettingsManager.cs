using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sam
{
    public class AgentSettingsManager
    {
        public List<AgentSettings> LoadAgentSettings()
        {
            List<AgentSettings> agentSettingsList = new List<AgentSettings>();

            // Retrieve existing agent settings from the settings field
            if (!string.IsNullOrEmpty(SamUserSettings.Default.AgentSettingsList))
            {
                agentSettingsList = JsonConvert.DeserializeObject<List<AgentSettings>>(SamUserSettings.Default.AgentSettingsList);
            }

            return agentSettingsList;
        }

        public void SaveAgentSettings(AgentSettings agentSetting)
        {
            var agents = LoadAgentSettings();
            // Find the agent settings object with the selected name
            AgentSettings selectedAgentSettings=null;
            if (agents != null) { selectedAgentSettings = agents.Find(x => x.AgentName == agentSetting.AgentName); }
             
            if (selectedAgentSettings==null)
            {
                agents.Add(agentSetting);
                // Serialize the agent settings list to JSON
                string agentSettingsJson = JsonConvert.SerializeObject(agents);

                // Save the agent settings to the settings field
                SamUserSettings.Default.AgentSettingsList = agentSettingsJson;
                SamUserSettings.Default.Save();
            }
            else
            {
                agents.Find(x => x.AgentName == agentSetting.AgentName).AgentID= agentSetting.AgentID;
                agents.Find(x => x.AgentName == agentSetting.AgentName).AgentName = agentSetting.AgentName;
                agents.Find(x => x.AgentName == agentSetting.AgentName).AgentPersonality = agentSetting.AgentPersonality;
                agents.Find(x => x.AgentName == agentSetting.AgentName).SlaveAgents = agentSetting.SlaveAgents;
                // Serialize the agent settings list to JSON
                string agentSettingsJson = JsonConvert.SerializeObject(agents);

                // Save the agent settings to the settings field
                SamUserSettings.Default.AgentSettingsList = agentSettingsJson;
                SamUserSettings.Default.Save();
            }
        }

        public AgentSettings LoadAgentSetting(string agentName)
        {
            AgentSettings agentSettings = new AgentSettings();
            var agents = LoadAgentSettings();
            if (agents != null) { agentSettings = agents.Find(x => x.AgentName == agentName); }
            if (agentSettings == null) { agentSettings = new AgentSettings(); };
            return agentSettings;
        }

    }
}
