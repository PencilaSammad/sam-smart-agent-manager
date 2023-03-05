namespace sam
{
    partial class SAM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAM));
            samTools = new ToolStripContainer();
            dockPanelSAM = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            toolSAM = new ToolStrip();
            samMenu = new ToolStripDropDownButton();
            newSmartAgentToolStripMenuItem = new ToolStripMenuItem();
            loadSmartAgentToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            samTools.ContentPanel.SuspendLayout();
            samTools.TopToolStripPanel.SuspendLayout();
            samTools.SuspendLayout();
            toolSAM.SuspendLayout();
            SuspendLayout();
            // 
            // samTools
            // 
            // 
            // samTools.ContentPanel
            // 
            samTools.ContentPanel.Controls.Add(dockPanelSAM);
            samTools.ContentPanel.Size = new Size(1028, 570);
            samTools.Dock = DockStyle.Fill;
            samTools.Location = new Point(0, 0);
            samTools.Name = "samTools";
            samTools.Size = new Size(1028, 601);
            samTools.TabIndex = 0;
            samTools.Text = "toolStripContainer1";
            // 
            // samTools.TopToolStripPanel
            // 
            samTools.TopToolStripPanel.Controls.Add(toolSAM);
            // 
            // dockPanelSAM
            // 
            dockPanelSAM.Dock = DockStyle.Fill;
            dockPanelSAM.Location = new Point(0, 0);
            dockPanelSAM.Name = "dockPanelSAM";
            dockPanelSAM.Size = new Size(1028, 570);
            dockPanelSAM.TabIndex = 0;
            // 
            // toolSAM
            // 
            toolSAM.Dock = DockStyle.None;
            toolSAM.Items.AddRange(new ToolStripItem[] { samMenu });
            toolSAM.Location = new Point(0, 0);
            toolSAM.Name = "toolSAM";
            toolSAM.Size = new Size(1028, 31);
            toolSAM.Stretch = true;
            toolSAM.TabIndex = 0;
            // 
            // samMenu
            // 
            samMenu.DisplayStyle = ToolStripItemDisplayStyle.Image;
            samMenu.DropDownItems.AddRange(new ToolStripItem[] { newSmartAgentToolStripMenuItem, loadSmartAgentToolStripMenuItem, exitToolStripMenuItem });
            samMenu.Image = (Image)resources.GetObject("samMenu.Image");
            samMenu.ImageScaling = ToolStripItemImageScaling.None;
            samMenu.ImageTransparentColor = Color.Magenta;
            samMenu.Name = "samMenu";
            samMenu.Size = new Size(37, 28);
            samMenu.Text = "Menu";
            // 
            // newSmartAgentToolStripMenuItem
            // 
            newSmartAgentToolStripMenuItem.Name = "newSmartAgentToolStripMenuItem";
            newSmartAgentToolStripMenuItem.Size = new Size(169, 22);
            newSmartAgentToolStripMenuItem.Text = "New Smart Agent";
            newSmartAgentToolStripMenuItem.Click += newSmartAgentToolStripMenuItem_Click;
            // 
            // loadSmartAgentToolStripMenuItem
            // 
            loadSmartAgentToolStripMenuItem.Name = "loadSmartAgentToolStripMenuItem";
            loadSmartAgentToolStripMenuItem.Size = new Size(169, 22);
            loadSmartAgentToolStripMenuItem.Text = "Load Smart Agent";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(169, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // SAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 601);
            Controls.Add(samTools);
            Name = "SAM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAM - Smart Agent Manager";
            samTools.ContentPanel.ResumeLayout(false);
            samTools.TopToolStripPanel.ResumeLayout(false);
            samTools.TopToolStripPanel.PerformLayout();
            samTools.ResumeLayout(false);
            samTools.PerformLayout();
            toolSAM.ResumeLayout(false);
            toolSAM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer samTools;
        private ToolStrip toolSAM;
        private ToolStripDropDownButton samMenu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelSAM;
        private ToolStripMenuItem newSmartAgentToolStripMenuItem;
        private ToolStripMenuItem loadSmartAgentToolStripMenuItem;
    }
}