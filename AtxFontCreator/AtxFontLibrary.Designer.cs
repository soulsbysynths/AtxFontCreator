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
            splitContainer1 = new SplitContainer();
            lstAtxFontLibrary = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstAtxFontLibrary);
            splitContainer1.Size = new Size(1002, 625);
            splitContainer1.SplitterDistance = 258;
            splitContainer1.TabIndex = 2;
            // 
            // lstAtxFontLibrary
            // 
            lstAtxFontLibrary.Dock = DockStyle.Fill;
            lstAtxFontLibrary.FormattingEnabled = true;
            lstAtxFontLibrary.ItemHeight = 25;
            lstAtxFontLibrary.Location = new Point(0, 0);
            lstAtxFontLibrary.Name = "lstAtxFontLibrary";
            lstAtxFontLibrary.ScrollAlwaysVisible = true;
            lstAtxFontLibrary.Size = new Size(258, 625);
            lstAtxFontLibrary.TabIndex = 2;
            lstAtxFontLibrary.SelectedIndexChanged += LstAtxFontLibrary_SelectedIndexChanged;
            // 
            // AtxFontLibrary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 625);
            Controls.Add(splitContainer1);
            MinimizeBox = false;
            Name = "AtxFontLibrary";
            Text = "ATX Font Library";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private ListBox lstAtxFontLibrary;
    }
}