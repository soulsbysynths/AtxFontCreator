namespace AtxFontCreator
{
    partial class AtxFontLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtxFontLibrary));
            splitContainer1 = new SplitContainer();
            lstAtxFontLibrary = new ListBox();
            atxFont1 = new AtxFont();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstAtxFontLibrary);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(atxFont1);
            splitContainer1.Size = new Size(810, 446);
            splitContainer1.SplitterDistance = 208;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 2;
            // 
            // lstAtxFontLibrary
            // 
            lstAtxFontLibrary.Dock = DockStyle.Fill;
            lstAtxFontLibrary.FormattingEnabled = true;
            lstAtxFontLibrary.ItemHeight = 15;
            lstAtxFontLibrary.Location = new Point(0, 0);
            lstAtxFontLibrary.Margin = new Padding(2);
            lstAtxFontLibrary.Name = "lstAtxFontLibrary";
            lstAtxFontLibrary.ScrollAlwaysVisible = true;
            lstAtxFontLibrary.Size = new Size(208, 446);
            lstAtxFontLibrary.TabIndex = 2;
            lstAtxFontLibrary.SelectedIndexChanged += LstAtxFontLibrary_SelectedIndexChanged;
            // 
            // atxFont1
            // 
            atxFont1.CharacterCount = 0;
            atxFont1.PixelSize = new Size(0, 0);
            atxFont1.Dock = DockStyle.Fill;
            atxFont1.FontName = "";
            atxFont1.Location = new Point(0, 0);
            atxFont1.Mode = AtxFont.EditMode.Edit;
            atxFont1.Name = "atxFont1";
            atxFont1.Size = new Size(599, 446);
            atxFont1.StartCharacter = 0;
            atxFont1.TabIndex = 0;
            // 
            // AtxFontLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 446);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimizeBox = false;
            Name = "AtxFontLibrary";
            Text = "ATX Font Library";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private ListBox lstAtxFontLibrary;
        private AtxFont atxFont1;
    }
}