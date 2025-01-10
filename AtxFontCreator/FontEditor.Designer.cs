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
            groupBox3 = new GroupBox();
            numBBY = new NumericUpDown();
            numBBX = new NumericUpDown();
            label2 = new Label();
            numBBHeight = new NumericUpDown();
            numBBWidth = new NumericUpDown();
            label1 = new Label();
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
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBBY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBBX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBBHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBBWidth).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Dock = DockStyle.Top;
            lblFont.Location = new Point(0, 0);
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
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(btnFont);
            splitContainer1.Panel1.Padding = new Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flpFontConverter);
            splitContainer1.Panel2.Controls.Add(lblFont);
            splitContainer1.Size = new Size(1102, 595);
            splitContainer1.SplitterDistance = 135;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 9;
            // 
            // chkShowLabels
            // 
            chkShowLabels.AutoSize = true;
            chkShowLabels.Dock = DockStyle.Left;
            chkShowLabels.Location = new Point(530, 4);
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
            atxCharacter1.Location = new Point(467, 4);
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
            groupBox2.Location = new Point(345, 4);
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
            numHeight.Location = new Point(74, 17);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(42, 23);
            numHeight.TabIndex = 9;
            numHeight.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(7, 18);
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
            label3.Location = new Point(55, 19);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 8;
            label3.Text = "x";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numBBY);
            groupBox3.Controls.Add(numBBX);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(numBBHeight);
            groupBox3.Controls.Add(numBBWidth);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(223, 4);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(122, 127);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bounding Box";
            // 
            // numBBY
            // 
            numBBY.Location = new Point(74, 51);
            numBBY.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numBBY.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numBBY.Name = "numBBY";
            numBBY.Size = new Size(42, 23);
            numBBY.TabIndex = 12;
            numBBY.ValueChanged += NumBB_ValueChanged;
            // 
            // numBBX
            // 
            numBBX.Location = new Point(7, 52);
            numBBX.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numBBX.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numBBX.Name = "numBBX";
            numBBX.Size = new Size(42, 23);
            numBBX.TabIndex = 10;
            numBBX.ValueChanged += NumBB_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 61);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 11;
            label2.Text = ",";
            // 
            // numBBHeight
            // 
            numBBHeight.Location = new Point(74, 17);
            numBBHeight.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numBBHeight.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numBBHeight.Name = "numBBHeight";
            numBBHeight.Size = new Size(42, 23);
            numBBHeight.TabIndex = 9;
            numBBHeight.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numBBHeight.ValueChanged += NumBB_ValueChanged;
            // 
            // numBBWidth
            // 
            numBBWidth.Location = new Point(7, 18);
            numBBWidth.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numBBWidth.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numBBWidth.Name = "numBBWidth";
            numBBWidth.Size = new Size(42, 23);
            numBBWidth.TabIndex = 7;
            numBBWidth.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numBBWidth.ValueChanged += NumBB_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 8;
            label1.Text = "x";
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
            flpFontConverter.Location = new Point(0, 15);
            flpFontConverter.Name = "flpFontConverter";
            flpFontConverter.Size = new Size(1102, 443);
            flpFontConverter.TabIndex = 8;
            // 
            // FontEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 595);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FontEditor";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "System Font Converter";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBBY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBBX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBBHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBBWidth).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox3;
        private NumericUpDown numBBY;
        private NumericUpDown numBBX;
        private Label label2;
        private NumericUpDown numBBHeight;
        private NumericUpDown numBBWidth;
        private Label label1;
    }
}
