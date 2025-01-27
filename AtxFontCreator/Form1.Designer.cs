namespace AtxFontCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            libraryToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyFromSystemFontToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            libraryToolStripMenuItem1 = new ToolStripMenuItem();
            systemFontEditorToolStripMenuItem = new ToolStripMenuItem();
            imageEditorToolStripMenuItem = new ToolStripMenuItem();
            previewScreenToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, windowToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, importToolStripMenuItem, exportToolStripMenuItem, libraryToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(119, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(119, 22);
            importToolStripMenuItem.Text = "Import...";
            importToolStripMenuItem.Click += ImportToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(119, 22);
            exportToolStripMenuItem.Text = "Export...";
            exportToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // libraryToolStripMenuItem
            // 
            libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            libraryToolStripMenuItem.Size = new Size(119, 22);
            libraryToolStripMenuItem.Text = "Library...";
            libraryToolStripMenuItem.Click += LibraryToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(119, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyFromSystemFontToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyFromSystemFontToolStripMenuItem
            // 
            copyFromSystemFontToolStripMenuItem.Name = "copyFromSystemFontToolStripMenuItem";
            copyFromSystemFontToolStripMenuItem.Size = new Size(201, 22);
            copyFromSystemFontToolStripMenuItem.Text = "Copy From System Font";
            copyFromSystemFontToolStripMenuItem.Click += CopyFromSystemFontToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { libraryToolStripMenuItem1, systemFontEditorToolStripMenuItem, imageEditorToolStripMenuItem, previewScreenToolStripMenuItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(63, 20);
            windowToolStripMenuItem.Text = "Window";
            // 
            // libraryToolStripMenuItem1
            // 
            libraryToolStripMenuItem1.Name = "libraryToolStripMenuItem1";
            libraryToolStripMenuItem1.Size = new Size(173, 22);
            libraryToolStripMenuItem1.Text = "ATX Font Library";
            libraryToolStripMenuItem1.Click += LibraryToolStripMenuItem1_Click;
            // 
            // systemFontEditorToolStripMenuItem
            // 
            systemFontEditorToolStripMenuItem.Name = "systemFontEditorToolStripMenuItem";
            systemFontEditorToolStripMenuItem.Size = new Size(173, 22);
            systemFontEditorToolStripMenuItem.Text = "System Font Editor";
            systemFontEditorToolStripMenuItem.Click += SystemFontEditorToolStripMenuItem_Click;
            // 
            // imageEditorToolStripMenuItem
            // 
            imageEditorToolStripMenuItem.Name = "imageEditorToolStripMenuItem";
            imageEditorToolStripMenuItem.Size = new Size(173, 22);
            imageEditorToolStripMenuItem.Text = "Image Editor";
            // 
            // previewScreenToolStripMenuItem
            // 
            previewScreenToolStripMenuItem.Name = "previewScreenToolStripMenuItem";
            previewScreenToolStripMenuItem.Size = new Size(173, 22);
            previewScreenToolStripMenuItem.Text = "Preview Screen";
            previewScreenToolStripMenuItem.Click += PreviewScreenToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Header files|*.h";
            openFileDialog1.FileOk += OpenFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 637);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form1";
            Text = "ATX Font Creator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem libraryToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem libraryToolStripMenuItem1;
        private ToolStripMenuItem systemFontEditorToolStripMenuItem;
        private ToolStripMenuItem imageEditorToolStripMenuItem;
        private ToolStripMenuItem previewScreenToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyFromSystemFontToolStripMenuItem;
    }
}
