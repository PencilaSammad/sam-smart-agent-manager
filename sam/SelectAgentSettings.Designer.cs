namespace sam
{
    partial class SelectAgentSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAgentSettings));
            lbAgentList = new ListBox();
            btnOk = new Button();
            btnCancel = new Button();
            grpPersonality = new GroupBox();
            txtAgentPersonality = new TextBox();
            btnReset = new Button();
            grpPersonality.SuspendLayout();
            SuspendLayout();
            // 
            // lbAgentList
            // 
            lbAgentList.FormattingEnabled = true;
            lbAgentList.ItemHeight = 15;
            lbAgentList.Location = new Point(12, 12);
            lbAgentList.Name = "lbAgentList";
            lbAgentList.Size = new Size(513, 139);
            lbAgentList.TabIndex = 0;
            lbAgentList.SelectedValueChanged += lbAgentList_SelectedValueChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(147, 336);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 336);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpPersonality
            // 
            grpPersonality.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonality.Controls.Add(txtAgentPersonality);
            grpPersonality.Location = new Point(12, 157);
            grpPersonality.Name = "grpPersonality";
            grpPersonality.Size = new Size(513, 161);
            grpPersonality.TabIndex = 3;
            grpPersonality.TabStop = false;
            grpPersonality.Text = "Selected agent personality";
            // 
            // txtAgentPersonality
            // 
            txtAgentPersonality.Dock = DockStyle.Fill;
            txtAgentPersonality.Location = new Point(3, 19);
            txtAgentPersonality.Multiline = true;
            txtAgentPersonality.Name = "txtAgentPersonality";
            txtAgentPersonality.Size = new Size(507, 139);
            txtAgentPersonality.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(309, 336);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // SelectAgentSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 371);
            Controls.Add(btnReset);
            Controls.Add(grpPersonality);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lbAgentList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectAgentSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Available agents";
            TopMost = true;
            Load += SelectAgentSettings_Load;
            grpPersonality.ResumeLayout(false);
            grpPersonality.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbAgentList;
        private Button btnOk;
        private Button btnCancel;
        private GroupBox grpPersonality;
        private TextBox txtAgentPersonality;
        private Button btnReset;
    }
}