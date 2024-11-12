namespace AtxFontCreator
{
    partial class AtxLayer
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
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            numHeight = new NumericUpDown();
            numWidth = new NumericUpDown();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cboDrawMode = new ComboBox();
            cboColour = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtCharacters = new TextBox();
            picLayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLayer).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(picLayer);
            splitContainer1.Size = new Size(874, 446);
            splitContainer1.SplitterDistance = 76;
            splitContainer1.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numHeight);
            groupBox3.Controls.Add(numWidth);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(388, 0);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(122, 76);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Character Size";
            // 
            // numHeight
            // 
            numHeight.Location = new Point(72, 19);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(42, 23);
            numHeight.TabIndex = 9;
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(5, 19);
            numWidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(42, 23);
            numWidth.TabIndex = 8;
            numWidth.ValueChanged += NumWidth_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 21);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 7;
            label1.Text = "x";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboDrawMode);
            groupBox2.Controls.Add(cboColour);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(170, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 76);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Layer Properties";
            // 
            // cboDrawMode
            // 
            cboDrawMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDrawMode.FormattingEnabled = true;
            cboDrawMode.Items.AddRange(new object[] { "Mask", "Not Mask", "And Mask", "And Not Mask", "Or Mask", "Or Not Mask", "Xor Mask", "Xor Not Mask" });
            cboDrawMode.Location = new Point(85, 47);
            cboDrawMode.Name = "cboDrawMode";
            cboDrawMode.Size = new Size(127, 23);
            cboDrawMode.TabIndex = 15;
            cboDrawMode.SelectedIndex = 0;
            cboDrawMode.SelectedIndexChanged += CboDrawMode_SelectedIndexChanged;
            // 
            // cboColour
            // 
            cboColour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColour.FormattingEnabled = true;
            cboColour.Items.AddRange(new object[] { "White", "Light Grey", "Grey", "Dark Grey", "Black" });
            cboColour.Location = new Point(85, 22);
            cboColour.Name = "cboColour";
            cboColour.Size = new Size(127, 23);
            cboColour.TabIndex = 14;
            cboColour.SelectedIndex = 0;
            cboColour.SelectedIndexChanged += CboColour_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 12;
            label3.Text = "Draw Mode:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 10;
            label2.Text = "Colour:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCharacters);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Characters";
            // 
            // txtCharacters
            // 
            txtCharacters.Dock = DockStyle.Fill;
            txtCharacters.Location = new Point(3, 19);
            txtCharacters.Margin = new Padding(2);
            txtCharacters.Multiline = true;
            txtCharacters.Name = "txtCharacters";
            txtCharacters.ScrollBars = ScrollBars.Both;
            txtCharacters.Size = new Size(164, 54);
            txtCharacters.TabIndex = 1;
            txtCharacters.TextChanged += TxtCharacters_TextChanged;
            // 
            // picLayer
            // 
            picLayer.BackColor = SystemColors.ControlDark;
            picLayer.Dock = DockStyle.Left;
            picLayer.Location = new Point(0, 0);
            picLayer.Margin = new Padding(2);
            picLayer.Name = "picLayer";
            picLayer.Size = new Size(874, 366);
            picLayer.TabIndex = 7;
            picLayer.TabStop = false;
            picLayer.Paint += PicLayer_Paint;
            picLayer.Resize += picLayer_Resize;
            // 
            // AtxLayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(splitContainer1);
            Margin = new Padding(2);
            Name = "AtxLayer";
            Size = new Size(874, 446);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLayer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtCharacters;
        private PictureBox picLayer;
        private GroupBox groupBox3;
        private NumericUpDown numHeight;
        private NumericUpDown numWidth;
        private Label label1;
        private ComboBox cboDrawMode;
        private Label label3;
        private ComboBox cboColour;
        private Label label2;
    }
}
