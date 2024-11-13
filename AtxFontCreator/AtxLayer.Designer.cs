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
            groupBox4 = new GroupBox();
            numRow = new NumericUpDown();
            label5 = new Label();
            btnPrintString = new Button();
            txtPrintString = new TextBox();
            numColumn = new NumericUpDown();
            label4 = new Label();
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
            lblCharacters = new Label();
            picLayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numColumn).BeginInit();
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
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox4);
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(picLayer);
            splitContainer1.Size = new Size(1249, 743);
            splitContainer1.SplitterDistance = 125;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numRow);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(btnPrintString);
            groupBox4.Controls.Add(txtPrintString);
            groupBox4.Controls.Add(numColumn);
            groupBox4.Controls.Add(label4);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(853, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 125);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Print String";
            // 
            // numRow
            // 
            numRow.Location = new Point(185, 75);
            numRow.Margin = new Padding(4, 5, 4, 5);
            numRow.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numRow.Name = "numRow";
            numRow.Size = new Size(60, 31);
            numRow.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 78);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(16, 25);
            label5.TabIndex = 12;
            label5.Text = ",";
            // 
            // btnPrintString
            // 
            btnPrintString.Location = new Point(161, 31);
            btnPrintString.Name = "btnPrintString";
            btnPrintString.Size = new Size(84, 31);
            btnPrintString.TabIndex = 11;
            btnPrintString.Text = "Print";
            btnPrintString.UseVisualStyleBackColor = true;
            btnPrintString.Click += BtnPrintString_Click;
            // 
            // txtPrintString
            // 
            txtPrintString.Location = new Point(6, 31);
            txtPrintString.Name = "txtPrintString";
            txtPrintString.Size = new Size(150, 31);
            txtPrintString.TabIndex = 10;
            txtPrintString.Text = "Test Text";
            // 
            // numColumn
            // 
            numColumn.Location = new Point(96, 75);
            numColumn.Margin = new Padding(4, 5, 4, 5);
            numColumn.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numColumn.Name = "numColumn";
            numColumn.Size = new Size(60, 31);
            numColumn.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 78);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 0;
            label4.Text = "Location:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numHeight);
            groupBox3.Controls.Add(numWidth);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(679, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(174, 125);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Character Size";
            // 
            // numHeight
            // 
            numHeight.Location = new Point(103, 32);
            numHeight.Margin = new Padding(4, 5, 4, 5);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(60, 31);
            numHeight.TabIndex = 9;
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(7, 32);
            numWidth.Margin = new Padding(4, 5, 4, 5);
            numWidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(60, 31);
            numWidth.TabIndex = 8;
            numWidth.ValueChanged += NumWidth_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
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
            groupBox2.Location = new Point(368, 0);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(311, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Layer Properties";
            // 
            // cboDrawMode
            // 
            cboDrawMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDrawMode.FormattingEnabled = true;
            cboDrawMode.Items.AddRange(new object[] { "Mask", "Not Mask", "And Mask", "And Not Mask", "Or Mask", "Or Not Mask", "Xor Mask", "Xor Not Mask" });
            cboDrawMode.Location = new Point(121, 78);
            cboDrawMode.Margin = new Padding(4, 5, 4, 5);
            cboDrawMode.Name = "cboDrawMode";
            cboDrawMode.Size = new Size(180, 33);
            cboDrawMode.TabIndex = 15;
            cboDrawMode.SelectedIndexChanged += CboDrawMode_SelectedIndexChanged;
            // 
            // cboColour
            // 
            cboColour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColour.FormattingEnabled = true;
            cboColour.Items.AddRange(new object[] { "White", "Light Grey", "Grey", "Dark Grey", "Black" });
            cboColour.Location = new Point(121, 37);
            cboColour.Margin = new Padding(4, 5, 4, 5);
            cboColour.Name = "cboColour";
            cboColour.Size = new Size(180, 33);
            cboColour.TabIndex = 14;
            cboColour.SelectedIndexChanged += CboColour_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 83);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 12;
            label3.Text = "Draw Mode:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 42);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 10;
            label2.Text = "Colour:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCharacters);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(368, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Characters";
            // 
            // lblCharacters
            // 
            lblCharacters.BorderStyle = BorderStyle.Fixed3D;
            lblCharacters.Dock = DockStyle.Fill;
            lblCharacters.Font = new Font("Courier New", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCharacters.Location = new Point(4, 29);
            lblCharacters.Name = "lblCharacters";
            lblCharacters.Size = new Size(360, 91);
            lblCharacters.TabIndex = 0;
            // 
            // picLayer
            // 
            picLayer.BackColor = SystemColors.ControlDark;
            picLayer.Dock = DockStyle.Left;
            picLayer.Location = new Point(0, 0);
            picLayer.Name = "picLayer";
            picLayer.Size = new Size(1249, 611);
            picLayer.TabIndex = 7;
            picLayer.TabStop = false;
            picLayer.Paint += PicLayer_Paint;
            picLayer.Resize += PicLayer_Resize;
            // 
            // AtxLayer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(splitContainer1);
            Name = "AtxLayer";
            Size = new Size(1249, 743);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numColumn).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLayer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private PictureBox picLayer;
        private GroupBox groupBox3;
        private NumericUpDown numHeight;
        private NumericUpDown numWidth;
        private Label label1;
        private ComboBox cboDrawMode;
        private Label label3;
        private ComboBox cboColour;
        private Label label2;
        private Label lblCharacters;
        private GroupBox groupBox4;
        private NumericUpDown numColumn;
        private Label label4;
        private NumericUpDown numRow;
        private Label label5;
        private Button btnPrintString;
        private TextBox txtPrintString;
    }
}
