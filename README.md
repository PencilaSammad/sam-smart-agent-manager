# SAM - Smart Agent Manager

SAM - Smart Agent Manager
SAM (Smart Agent Manager) is an ChatGPT AI agent system that allows multiple agents with different roles to communicate with each other. It is created using Visual Studio 2022 WinForms, making it easy to use and intuitive for developers. SAM optimizes workflow, automates routine tasks, and ensures smooth collaboration between agents. It is licensed under the permissive MIT License.

Features
Create multiple agents with different roles
Allow agents to communicate with each other
Automate routine tasks and optimize workflow
Ensure smooth collaboration between agents
Installation
To install SAM, simply clone the repository and open the solution in Visual Studio 2022. Build the project to create the executable file.

Usage
To start using SAM, run the executable file to start the SAM server. This will allow you to begin creating agents and managing workflows.

License
SAM is licensed under the permissive MIT License. See the LICENSE file for more information.

Contributing
If you would like to contribute to SAM, please fork the repository and submit a pull request. We welcome contributions from the community and are always looking for ways to improve SAM.
![image](https://user-images.githubusercontent.com/167311/223538270-7d3de6cd-98c7-49f1-a7dd-4ce98b7307c3.png)
1. Agent Name - This is the name of the GPT agent that the user is currently using.

2. Agent ID - This is the unique identification number or code for the GPT agent.

3. Slave Agent Settings - This option enables the user to forward responses to another GPT agent based on specific instructions.

4. Message to Slave Agent - This is a text box where the user can input a message that is forwarded to the slave agent before the response.

5. Agent Control - This section provides the user with some controls over the GPT agent. The Save Settings button saves the current settings, and the Reset Conversation button clears the current conversation.

6. Smart Agent Enabled - This setting allows the message forwarding to slave agents based on the defined rules. This also prevents slave agent handling the message if it is not checked. By unchecking this you can prevent infinite ChatGPT loops.

7. Conversation Panel - This panel displays the entire chat conversation between the user and the GPT agent. It provides the user with a view of all the messages exchanged, including the ones forwarded to a slave agent.

8. Code Panel - This panel displays the code provided by the GPT Agent.

Remember to use these features appropriately to achieve the best possible user experience with your GPT application.

## Azure integration, users can now enable voice chat with their selected SAM agent

By integrating with Azure, users can now take advantage of voice chat capabilities with their selected SAM agent. This feature involves using Azure's Text to Speech and Speech to Text APIs to convert the user's spoken words into text and the SAM agent's responses into spoken words.

To access these features, users must have a valid API key and region set up on their Azure account. Once they've entered this information, the UI will display buttons that enable Text to Speech and Speech to Text functionality.

In practice, this means that users can speak their questions or responses to the SAM agent using a microphone, which will be converted into text and displayed within the chat UI. The SAM agent will then provide its response, which will be converted back into spoken words using the Text to Speech API and forwarded to the user's speakers or headphones.

Azure's voice chat capabilities with the SAM agent adds another level of interactivity and convenience for users who prefer to communicate via speech rather than typing.

## Installation Guide for SAM - Smart Agent Manager
To install SAM, follow the steps below:

Option 1: Clone the repository and build the project

1. Clone the SAM repository from GitHub using Git or GitHub Desktop.
2. Open the solution file in Visual Studio 2022.
3. Build the project to create an executable file.
4. Launch SAM by running the executable file you built.

Option 2: Use the standalone samsetup installer

1. Download the samsetup.exe file from the SAM release page on GitHub.
2. Double-click on the samsetup.exe file to begin the installation process.
3. Follow the on-screen instructions to install SAM.
4. Launch SAM by running the executable file installed by the samsetup installer.

Once you have installed SAM, you can start creating agents, managing workflows, and optimizing routines. Remember to add your OpenAI API key and Azure Cognitive Speech Service API key and associate it with the region where it is located. 

We hope this installation guide helps you get started with SAM. 
