namespace AtxFontCreator
{
    partial class AtxFont
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
            tbZoom = new TrackBar();
            grpEdit = new GroupBox();
            rdoLock = new RadioButton();
            rdoSelect = new RadioButton();
            rdoEdit = new RadioButton();
            groupBox1 = new GroupBox();
            btnLockSelected = new Button();
            btnClear = new Button();
            btnToggleSelect = new Button();
            grpMove = new GroupBox();
            btnMoveDown = new Button();
            btnMoveUp = new Button();
            btnMoveRight = new Button();
            btnMoveLeft = new Button();
            groupBox2 = new GroupBox();
            numCharacterCount = new NumericUpDown();
            label5 = new Label();
            lblStartCharacter = new Label();
            numStartCharacter = new NumericUpDown();
            label4 = new Label();
            numHeight = new NumericUpDown();
            numWidth = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            txtFontName = new TextBox();
            label1 = new Label();
            flpCharacters = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbZoom).BeginInit();
            grpEdit.SuspendLayout();
            groupBox1.SuspendLayout();
            grpMove.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCharacterCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(grpEdit);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(grpMove);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flpCharacters);
            splitContainer1.Size = new Size(942, 409);
            splitContainer1.SplitterDistance = 110;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 22;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbZoom);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(428, 0);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(86, 110);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zoom";
            // 
            // tbZoom
            // 
            tbZoom.Dock = DockStyle.Fill;
            tbZoom.LargeChange = 16;
            tbZoom.Location = new Point(2, 18);
            tbZoom.Margin = new Padding(2);
            tbZoom.Maximum = 256;
            tbZoom.Minimum = 32;
            tbZoom.Name = "tbZoom";
            tbZoom.Size = new Size(82, 90);
            tbZoom.SmallChange = 16;
            tbZoom.TabIndex = 19;
            tbZoom.TickFrequency = 16;
            tbZoom.Value = 96;
            tbZoom.Scroll += TbZoom_Scroll;
            // 
            // grpEdit
            // 
            grpEdit.Controls.Add(rdoLock);
            grpEdit.Controls.Add(rdoSelect);
            grpEdit.Controls.Add(rdoEdit);
            grpEdit.Dock = DockStyle.Left;
            grpEdit.Location = new Point(347, 0);
            grpEdit.Name = "grpEdit";
            grpEdit.Size = new Size(81, 110);
            grpEdit.TabIndex = 25;
            grpEdit.TabStop = false;
            grpEdit.Text = "Edit Mode";
            // 
            // rdoLock
            // 
            rdoLock.AutoSize = true;
            rdoLock.Location = new Point(7, 73);
            rdoLock.Name = "rdoLock";
            rdoLock.Size = new Size(50, 19);
            rdoLock.TabIndex = 2;
            rdoLock.Tag = "2";
            rdoLock.Text = "Lock";
            rdoLock.UseVisualStyleBackColor = true;
            rdoLock.Click += RdoMode_Click;
            // 
            // rdoSelect
            // 
            rdoSelect.AutoSize = true;
            rdoSelect.Location = new Point(7, 50);
            rdoSelect.Name = "rdoSelect";
            rdoSelect.Size = new Size(56, 19);
            rdoSelect.TabIndex = 1;
            rdoSelect.Tag = "1";
            rdoSelect.Text = "Select";
            rdoSelect.UseVisualStyleBackColor = true;
            rdoSelect.Click += RdoMode_Click;
            // 
            // rdoEdit
            // 
            rdoEdit.AutoSize = true;
            rdoEdit.Checked = true;
            rdoEdit.Location = new Point(7, 26);
            rdoEdit.Name = "rdoEdit";
            rdoEdit.Size = new Size(45, 19);
            rdoEdit.TabIndex = 0;
            rdoEdit.TabStop = true;
            rdoEdit.Tag = "0";
            rdoEdit.Text = "Edit";
            rdoEdit.UseVisualStyleBackColor = true;
            rdoEdit.Click += RdoMode_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLockSelected);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnToggleSelect);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(270, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(77, 110);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected";
            // 
            // btnLockSelected
            // 
            btnLockSelected.AutoSize = true;
            btnLockSelected.Font = new Font("Segoe UI", 9F);
            btnLockSelected.Location = new Point(5, 49);
            btnLockSelected.Name = "btnLockSelected";
            btnLockSelected.Size = new Size(66, 26);
            btnLockSelected.TabIndex = 19;
            btnLockSelected.Text = "Lock";
            btnLockSelected.UseVisualStyleBackColor = true;
            btnLockSelected.Click += BtnLockSelected_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(6, 76);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 26);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnToggleSelect
            // 
            btnToggleSelect.AutoSize = true;
            btnToggleSelect.Font = new Font("Segoe UI", 9F);
            btnToggleSelect.Location = new Point(5, 22);
            btnToggleSelect.Name = "btnToggleSelect";
            btnToggleSelect.Size = new Size(67, 26);
            btnToggleSelect.TabIndex = 17;
            btnToggleSelect.Text = "Toggle";
            btnToggleSelect.UseVisualStyleBackColor = true;
            btnToggleSelect.Click += BtnToggleSelect_Click;
            // 
            // grpMove
            // 
            grpMove.Controls.Add(btnMoveDown);
            grpMove.Controls.Add(btnMoveUp);
            grpMove.Controls.Add(btnMoveRight);
            grpMove.Controls.Add(btnMoveLeft);
            grpMove.Dock = DockStyle.Left;
            grpMove.Location = new Point(204, 0);
            grpMove.Name = "grpMove";
            grpMove.Size = new Size(66, 110);
            grpMove.TabIndex = 23;
            grpMove.TabStop = false;
            grpMove.Text = "Move";
            // 
            // btnMoveDown
            // 
            btnMoveDown.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveDown.Location = new Point(38, 54);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(26, 26);
            btnMoveDown.TabIndex = 3;
            btnMoveDown.Tag = "3";
            btnMoveDown.Text = "6";
            btnMoveDown.UseVisualStyleBackColor = true;
            btnMoveDown.Click += BtnMove_Click;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveUp.Location = new Point(6, 54);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new Size(26, 26);
            btnMoveUp.TabIndex = 2;
            btnMoveUp.Tag = "2";
            btnMoveUp.Text = "5";
            btnMoveUp.UseVisualStyleBackColor = true;
            btnMoveUp.Click += BtnMove_Click;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveRight.Location = new Point(38, 22);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(26, 26);
            btnMoveRight.TabIndex = 1;
            btnMoveRight.Tag = "1";
            btnMoveRight.Text = "4";
            btnMoveRight.UseVisualStyleBackColor = true;
            btnMoveRight.Click += BtnMove_Click;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveLeft.Location = new Point(6, 22);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(26, 26);
            btnMoveLeft.TabIndex = 0;
            btnMoveLeft.Tag = "0";
            btnMoveLeft.Text = "3";
            btnMoveLeft.UseVisualStyleBackColor = true;
            btnMoveLeft.Click += BtnMove_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numCharacterCount);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblStartCharacter);
            groupBox2.Controls.Add(numStartCharacter);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numHeight);
            groupBox2.Controls.Add(numWidth);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtFontName);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(204, 110);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // numCharacterCount
            // 
            numCharacterCount.Location = new Point(108, 83);
            numCharacterCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numCharacterCount.Name = "numCharacterCount";
            numCharacterCount.Size = new Size(42, 23);
            numCharacterCount.TabIndex = 15;
            numCharacterCount.ValueChanged += NumCharacterCount_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 85);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 14;
            label5.Text = "Character Count:";
            // 
            // lblStartCharacter
            // 
            lblStartCharacter.BorderStyle = BorderStyle.FixedSingle;
            lblStartCharacter.Location = new Point(147, 61);
            lblStartCharacter.Name = "lblStartCharacter";
            lblStartCharacter.Size = new Size(27, 19);
            lblStartCharacter.TabIndex = 13;
            lblStartCharacter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numStartCharacter
            // 
            numStartCharacter.Location = new Point(99, 61);
            numStartCharacter.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numStartCharacter.Name = "numStartCharacter";
            numStartCharacter.Size = new Size(42, 23);
            numStartCharacter.TabIndex = 12;
            numStartCharacter.ValueChanged += NumStartCharacter_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 62);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 11;
            label4.Text = "Start Character:";
            // 
            // numHeight
            // 
            numHeight.Location = new Point(154, 38);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(42, 23);
            numHeight.TabIndex = 10;
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(87, 38);
            numWidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(42, 23);
            numWidth.TabIndex = 9;
            numWidth.ValueChanged += NumWidth_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 40);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 8;
            label3.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 40);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Pixel size:";
            // 
            // txtFontName
            // 
            txtFontName.Location = new Point(53, 13);
            txtFontName.Name = "txtFontName";
            txtFontName.Size = new Size(144, 23);
            txtFontName.TabIndex = 4;
            txtFontName.TextChanged += TxtFontName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 15);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // flpCharacters
            // 
            flpCharacters.AutoScroll = true;
            flpCharacters.BackColor = SystemColors.ControlDark;
            flpCharacters.BorderStyle = BorderStyle.Fixed3D;
            flpCharacters.Dock = DockStyle.Fill;
            flpCharacters.Location = new Point(0, 0);
            flpCharacters.Name = "flpCharacters";
            flpCharacters.Size = new Size(942, 297);
            flpCharacters.TabIndex = 13;
            // 
            // AtxFont
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "AtxFont";
            Size = new Size(942, 409);
            Resize += AtxFont_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbZoom).EndInit();
            grpEdit.ResumeLayout(false);
            grpEdit.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpMove.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCharacterCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flpCharacters;
        private GroupBox groupBox3;
        private TrackBar tbZoom;
        private GroupBox grpEdit;
        private RadioButton rdoLock;
        private RadioButton rdoSelect;
        private RadioButton rdoEdit;
        private GroupBox groupBox1;
        private Button btnLockSelected;
        private Button btnClear;
        private Button btnToggleSelect;
        private GroupBox grpMove;
        private Button btnMoveDown;
        private Button btnMoveUp;
        private Button btnMoveRight;
        private Button btnMoveLeft;
        private GroupBox groupBox2;
        private NumericUpDown numCharacterCount;
        private Label label5;
        private Label lblStartCharacter;
        private NumericUpDown numStartCharacter;
        private Label label4;
        private NumericUpDown numHeight;
        private NumericUpDown numWidth;
        private Label label3;
        private Label label2;
        private TextBox txtFontName;
        private Label label1;
    }
}
