namespace AtxFontCreator
{
    partial class FontEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFont = new Label();
            fontDialog1 = new FontDialog();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            chkIncludeNumbers = new CheckBox();
            chkIncludeMisc = new CheckBox();
            chkIncludePunctuation = new CheckBox();
            chkIncludeCharacters = new CheckBox();
            btnFont = new Button();
            flpFontConverter = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(4, 80);
            lblFont.Margin = new Padding(4, 0, 4, 0);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(0, 25);
            lblFont.TabIndex = 8;
            lblFont.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(btnFont);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flpFontConverter);
            splitContainer1.Size = new Size(1368, 710);
            splitContainer1.SplitterDistance = 75;
            splitContainer1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIncludeNumbers);
            groupBox1.Controls.Add(chkIncludeMisc);
            groupBox1.Controls.Add(chkIncludePunctuation);
            groupBox1.Controls.Add(chkIncludeCharacters);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(87, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(466, 75);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Include";
            // 
            // chkIncludeNumbers
            // 
            chkIncludeNumbers.AutoSize = true;
            chkIncludeNumbers.Location = new Point(11, 32);
            chkIncludeNumbers.Margin = new Padding(4, 5, 4, 5);
            chkIncludeNumbers.Name = "chkIncludeNumbers";
            chkIncludeNumbers.Size = new Size(111, 29);
            chkIncludeNumbers.TabIndex = 4;
            chkIncludeNumbers.Text = "Numbers";
            chkIncludeNumbers.UseVisualStyleBackColor = true;
            chkIncludeNumbers.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludeMisc
            // 
            chkIncludeMisc.AutoSize = true;
            chkIncludeMisc.Location = new Point(391, 32);
            chkIncludeMisc.Margin = new Padding(4, 5, 4, 5);
            chkIncludeMisc.Name = "chkIncludeMisc";
            chkIncludeMisc.Size = new Size(74, 29);
            chkIncludeMisc.TabIndex = 2;
            chkIncludeMisc.Text = "Misc";
            chkIncludeMisc.UseVisualStyleBackColor = true;
            chkIncludeMisc.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludePunctuation
            // 
            chkIncludePunctuation.AutoSize = true;
            chkIncludePunctuation.Location = new Point(252, 32);
            chkIncludePunctuation.Margin = new Padding(4, 5, 4, 5);
            chkIncludePunctuation.Name = "chkIncludePunctuation";
            chkIncludePunctuation.Size = new Size(132, 29);
            chkIncludePunctuation.TabIndex = 1;
            chkIncludePunctuation.Text = "Punctuation";
            chkIncludePunctuation.UseVisualStyleBackColor = true;
            chkIncludePunctuation.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludeCharacters
            // 
            chkIncludeCharacters.AutoSize = true;
            chkIncludeCharacters.Location = new Point(126, 32);
            chkIncludeCharacters.Margin = new Padding(4, 5, 4, 5);
            chkIncludeCharacters.Name = "chkIncludeCharacters";
            chkIncludeCharacters.Size = new Size(120, 29);
            chkIncludeCharacters.TabIndex = 0;
            chkIncludeCharacters.Text = "Characters";
            chkIncludeCharacters.UseVisualStyleBackColor = true;
            chkIncludeCharacters.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // btnFont
            // 
            btnFont.Dock = DockStyle.Left;
            btnFont.Location = new Point(0, 0);
            btnFont.Margin = new Padding(4, 5, 4, 5);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(87, 75);
            btnFont.TabIndex = 2;
            btnFont.Text = "Font...";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += BtnFont_Click;
            // 
            // flpFontConverter
            // 
            flpFontConverter.AutoScroll = true;
            flpFontConverter.BorderStyle = BorderStyle.Fixed3D;
            flpFontConverter.Dock = DockStyle.Fill;
            flpFontConverter.Location = new Point(0, 0);
            flpFontConverter.Margin = new Padding(4, 5, 4, 5);
            flpFontConverter.Name = "flpFontConverter";
            flpFontConverter.Size = new Size(1368, 631);
            flpFontConverter.TabIndex = 8;
            // 
            // FontEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 710);
            Controls.Add(splitContainer1);
            Controls.Add(lblFont);
            Name = "FontEditor";
            Text = "System Font Converter";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFont;
        private FontDialog fontDialog1;
        private SplitContainer splitContainer1;
        private Button btnFont;
        private GroupBox groupBox1;
        private CheckBox chkIncludeNumbers;
        private CheckBox chkIncludeMisc;
        private CheckBox chkIncludePunctuation;
        private CheckBox chkIncludeCharacters;
        private FlowLayoutPanel flpFontConverter;
    }
}
