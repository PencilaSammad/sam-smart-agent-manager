namespace sam
{
    partial class SamSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamSettings));
            grpAPI = new GroupBox();
            txtApiKey = new TextBox();
            grpPersonality = new GroupBox();
            txtAgentPersonality = new TextBox();
            grpAgentControl = new GroupBox();
            btnSaveAgent = new Button();
            btnReset = new Button();
            grpAPI.SuspendLayout();
            grpPersonality.SuspendLayout();
            grpAgentControl.SuspendLayout();
            SuspendLayout();
            // 
            // grpAPI
            // 
            grpAPI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAPI.Controls.Add(txtApiKey);
            grpAPI.Location = new Point(12, 12);
            grpAPI.Name = "grpAPI";
            grpAPI.Size = new Size(378, 51);
            grpAPI.TabIndex = 1;
            grpAPI.TabStop = false;
            grpAPI.Text = "OpenAI API Key";
            // 
            // txtApiKey
            // 
            txtApiKey.Dock = DockStyle.Fill;
            txtApiKey.Location = new Point(3, 19);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PasswordChar = '*';
            txtApiKey.Size = new Size(372, 23);
            txtApiKey.TabIndex = 1;
            // 
            // grpPersonality
            // 
            grpPersonality.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonality.Controls.Add(txtAgentPersonality);
            grpPersonality.Location = new Point(12, 69);
            grpPersonality.Name = "grpPersonality";
            grpPersonality.Size = new Size(378, 219);
            grpPersonality.TabIndex = 3;
            grpPersonality.TabStop = false;
            grpPersonality.Text = "Default agent personality";
            // 
            // txtAgentPersonality
            // 
            txtAgentPersonality.Dock = DockStyle.Fill;
            txtAgentPersonality.Location = new Point(3, 19);
            txtAgentPersonality.Multiline = true;
            txtAgentPersonality.Name = "txtAgentPersonality";
            txtAgentPersonality.Size = new Size(372, 197);
            txtAgentPersonality.TabIndex = 1;
            // 
            // grpAgentControl
            // 
            grpAgentControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAgentControl.Controls.Add(btnSaveAgent);
            grpAgentControl.Controls.Add(btnReset);
            grpAgentControl.Location = new Point(12, 308);
            grpAgentControl.Name = "grpAgentControl";
            grpAgentControl.Size = new Size(375, 108);
            grpAgentControl.TabIndex = 6;
            grpAgentControl.TabStop = false;
            grpAgentControl.Text = "Settings control";
            // 
            // btnSaveAgent
            // 
            btnSaveAgent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveAgent.Location = new Point(6, 22);
            btnSaveAgent.Name = "btnSaveAgent";
            btnSaveAgent.Size = new Size(78, 80);
            btnSaveAgent.TabIndex = 3;
            btnSaveAgent.Text = "Save";
            btnSaveAgent.UseVisualStyleBackColor = true;
            btnSaveAgent.Click += btnSaveAgent_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.Location = new Point(90, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 80);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // SamSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 419);
            Controls.Add(grpAgentControl);
            Controls.Add(grpPersonality);
            Controls.Add(grpAPI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SamSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAM Settings";
            TopMost = true;
            Load += SamSettings_Load;
            grpAPI.ResumeLayout(false);
            grpAPI.PerformLayout();
            grpPersonality.ResumeLayout(false);
            grpPersonality.PerformLayout();
            grpAgentControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAPI;
        private TextBox txtApiKey;
        private GroupBox grpPersonality;
        private TextBox txtAgentPersonality;
        private GroupBox grpAgentControl;
        private Button btnSaveAgent;
        private Button btnReset;
    }
}