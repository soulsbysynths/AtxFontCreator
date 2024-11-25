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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontEditor));
            lblFont = new Label();
            fontDialog1 = new FontDialog();
            splitContainer1 = new SplitContainer();
            chkShowLabels = new CheckBox();
            atxCharacter1 = new AtxCharacter();
            groupBox2 = new GroupBox();
            numHeight = new NumericUpDown();
            numWidth = new NumericUpDown();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnSetBoundingBoxes = new Button();
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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(3, 48);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(0, 15);
            lblFont.TabIndex = 8;
            lblFont.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(chkShowLabels);
            splitContainer1.Panel1.Controls.Add(atxCharacter1);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(btnFont);
            splitContainer1.Panel1.Padding = new Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flpFontConverter);
            splitContainer1.Size = new Size(1102, 595);
            splitContainer1.SplitterDistance = 135;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 9;
            // 
            // chkShowLabels
            // 
            chkShowLabels.AutoSize = true;
            chkShowLabels.Dock = DockStyle.Left;
            chkShowLabels.Location = new Point(408, 4);
            chkShowLabels.Name = "chkShowLabels";
            chkShowLabels.Size = new Size(91, 127);
            chkShowLabels.TabIndex = 13;
            chkShowLabels.Text = "Show Labels";
            chkShowLabels.UseVisualStyleBackColor = true;
            chkShowLabels.CheckedChanged += ChkShowLabels_CheckedChanged;
            // 
            // atxCharacter1
            // 
            atxCharacter1.BackColor = Color.FromArgb(224, 224, 224);
            atxCharacter1.Character = '\0';
            atxCharacter1.Dock = DockStyle.Left;
            atxCharacter1.Location = new Point(345, 4);
            atxCharacter1.Name = "atxCharacter1";
            atxCharacter1.PixelSize = new Size(8, 16);
            atxCharacter1.Selected = true;
            atxCharacter1.Size = new Size(63, 127);
            atxCharacter1.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numHeight);
            groupBox2.Controls.Add(numWidth);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(223, 4);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(122, 127);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output Size";
            // 
            // numHeight
            // 
            numHeight.Location = new Point(72, 18);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(42, 23);
            numHeight.TabIndex = 9;
            numHeight.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(5, 19);
            numWidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(42, 23);
            numWidth.TabIndex = 7;
            numWidth.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numWidth.ValueChanged += NumWidth_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 20);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 8;
            label3.Text = "x";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSetBoundingBoxes);
            groupBox1.Controls.Add(chkIncludeNumbers);
            groupBox1.Controls.Add(chkIncludeMisc);
            groupBox1.Controls.Add(chkIncludePunctuation);
            groupBox1.Controls.Add(chkIncludeCharacters);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(65, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(158, 127);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Set All Bounding Boxes";
            // 
            // btnSetBoundingBoxes
            // 
            btnSetBoundingBoxes.Dock = DockStyle.Top;
            btnSetBoundingBoxes.Location = new Point(3, 95);
            btnSetBoundingBoxes.Name = "btnSetBoundingBoxes";
            btnSetBoundingBoxes.Size = new Size(152, 27);
            btnSetBoundingBoxes.TabIndex = 5;
            btnSetBoundingBoxes.Text = "Set";
            btnSetBoundingBoxes.UseVisualStyleBackColor = true;
            // 
            // chkIncludeNumbers
            // 
            chkIncludeNumbers.AutoSize = true;
            chkIncludeNumbers.Dock = DockStyle.Top;
            chkIncludeNumbers.Location = new Point(3, 76);
            chkIncludeNumbers.Name = "chkIncludeNumbers";
            chkIncludeNumbers.Size = new Size(152, 19);
            chkIncludeNumbers.TabIndex = 4;
            chkIncludeNumbers.Text = "Numbers";
            chkIncludeNumbers.UseVisualStyleBackColor = true;
            chkIncludeNumbers.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludeMisc
            // 
            chkIncludeMisc.AutoSize = true;
            chkIncludeMisc.Dock = DockStyle.Top;
            chkIncludeMisc.Location = new Point(3, 57);
            chkIncludeMisc.Name = "chkIncludeMisc";
            chkIncludeMisc.Size = new Size(152, 19);
            chkIncludeMisc.TabIndex = 2;
            chkIncludeMisc.Text = "Misc";
            chkIncludeMisc.UseVisualStyleBackColor = true;
            chkIncludeMisc.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludePunctuation
            // 
            chkIncludePunctuation.AutoSize = true;
            chkIncludePunctuation.Dock = DockStyle.Top;
            chkIncludePunctuation.Location = new Point(3, 38);
            chkIncludePunctuation.Name = "chkIncludePunctuation";
            chkIncludePunctuation.Size = new Size(152, 19);
            chkIncludePunctuation.TabIndex = 1;
            chkIncludePunctuation.Text = "Punctuation";
            chkIncludePunctuation.UseVisualStyleBackColor = true;
            chkIncludePunctuation.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludeCharacters
            // 
            chkIncludeCharacters.AutoSize = true;
            chkIncludeCharacters.Dock = DockStyle.Top;
            chkIncludeCharacters.Location = new Point(3, 19);
            chkIncludeCharacters.Name = "chkIncludeCharacters";
            chkIncludeCharacters.Size = new Size(152, 19);
            chkIncludeCharacters.TabIndex = 0;
            chkIncludeCharacters.Text = "Characters";
            chkIncludeCharacters.UseVisualStyleBackColor = true;
            chkIncludeCharacters.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // btnFont
            // 
            btnFont.Dock = DockStyle.Left;
            btnFont.Location = new Point(4, 4);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(61, 127);
            btnFont.TabIndex = 2;
            btnFont.Text = "Font...";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += BtnFont_Click;
            // 
            // flpFontConverter
            // 
            flpFontConverter.AutoScroll = true;
            flpFontConverter.BackColor = SystemColors.ControlDark;
            flpFontConverter.BorderStyle = BorderStyle.Fixed3D;
            flpFontConverter.Dock = DockStyle.Fill;
            flpFontConverter.Location = new Point(0, 0);
            flpFontConverter.Name = "flpFontConverter";
            flpFontConverter.Size = new Size(1102, 458);
            flpFontConverter.TabIndex = 8;
            // 
            // FontEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 595);
            Controls.Add(splitContainer1);
            Controls.Add(lblFont);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FontEditor";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "System Font Converter";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
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
        private GroupBox groupBox2;
        private NumericUpDown numHeight;
        private NumericUpDown numWidth;
        private Label label3;
        private Button btnSetBoundingBoxes;
        private AtxCharacter atxCharacter1;
        private CheckBox chkShowLabels;
    }
}
