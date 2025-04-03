namespace ImageViewer
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            thumbnailsPanel = new FlowLayoutPanel();
            loadFolderButton = new Button();
            mainPictureBox = new PictureBox();
            fileInfoLabel = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            zoomInButton = new ToolStripButton();
            zoomOutButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            rotateButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 71);
            splitContainer1.Margin = new Padding(5, 6, 5, 6);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(thumbnailsPanel);
            splitContainer1.Panel1.Controls.Add(loadFolderButton);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(mainPictureBox);
            splitContainer1.Panel2.Controls.Add(fileInfoLabel);
            splitContainer1.Size = new Size(1333, 762);
            splitContainer1.SplitterDistance = 333;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 0;
            // 
            // thumbnailsPanel
            // 
            thumbnailsPanel.AutoScroll = true;
            thumbnailsPanel.Dock = DockStyle.Fill;
            thumbnailsPanel.Location = new Point(0, 58);
            thumbnailsPanel.Margin = new Padding(5, 6, 5, 6);
            thumbnailsPanel.Name = "thumbnailsPanel";
            thumbnailsPanel.Size = new Size(333, 704);
            thumbnailsPanel.TabIndex = 1;
            // 
            // loadFolderButton
            // 
            loadFolderButton.Dock = DockStyle.Top;
            loadFolderButton.Location = new Point(0, 0);
            loadFolderButton.Margin = new Padding(5, 6, 5, 6);
            loadFolderButton.Name = "loadFolderButton";
            loadFolderButton.Size = new Size(333, 58);
            loadFolderButton.TabIndex = 0;
            loadFolderButton.Text = "Load Folder";
            loadFolderButton.UseVisualStyleBackColor = true;
            loadFolderButton.Click += loadFolderButton_Click;
            // 
            // mainPictureBox
            // 
            mainPictureBox.BackColor = Color.Black;
            mainPictureBox.Dock = DockStyle.Fill;
            mainPictureBox.Location = new Point(0, 0);
            mainPictureBox.Margin = new Padding(5, 6, 5, 6);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(993, 717);
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPictureBox.TabIndex = 0;
            mainPictureBox.TabStop = false;
            // 
            // fileInfoLabel
            // 
            fileInfoLabel.AutoSize = true;
            fileInfoLabel.BackColor = Color.Transparent;
            fileInfoLabel.Dock = DockStyle.Bottom;
            fileInfoLabel.Location = new Point(0, 717);
            fileInfoLabel.Margin = new Padding(5, 0, 5, 0);
            fileInfoLabel.Name = "fileInfoLabel";
            fileInfoLabel.Padding = new Padding(8, 10, 8, 10);
            fileInfoLabel.Size = new Size(16, 45);
            fileInfoLabel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 833);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 23, 0);
            statusStrip1.Size = new Size(1333, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(60, 25);
            statusLabel.Text = "Ready";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(1333, 37);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFolderToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(213, 34);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += loadFolderButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(213, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { zoomInButton, zoomOutButton, toolStripSeparator2, rotateButton });
            toolStrip1.Location = new Point(0, 37);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1333, 34);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // zoomInButton
            // 
            zoomInButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            zoomInButton.Name = "zoomInButton";
            zoomInButton.Size = new Size(84, 29);
            zoomInButton.Text = "Zoom In";
            zoomInButton.Click += zoomInButton_Click;
            // 
            // zoomOutButton
            // 
            zoomOutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            zoomOutButton.Name = "zoomOutButton";
            zoomOutButton.Size = new Size(99, 29);
            zoomOutButton.Text = "Zoom Out";
            zoomOutButton.Click += zoomOutButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 34);
            // 
            // rotateButton
            // 
            rotateButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(67, 29);
            rotateButton.Text = "Rotate";
            rotateButton.Click += rotateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Image Viewer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button loadFolderButton;
        private System.Windows.Forms.FlowLayoutPanel thumbnailsPanel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton zoomInButton;
        private System.Windows.Forms.ToolStripButton zoomOutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton rotateButton;
    }
}