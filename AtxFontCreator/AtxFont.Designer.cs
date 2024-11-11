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
            splitContainer1.Panel2MinSize = 600;
            splitContainer1.Size = new Size(1345, 681);
            splitContainer1.SplitterDistance = 177;
            splitContainer1.TabIndex = 22;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbZoom);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(612, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(123, 177);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zoom";
            // 
            // tbZoom
            // 
            tbZoom.Dock = DockStyle.Fill;
            tbZoom.LargeChange = 16;
            tbZoom.Location = new Point(3, 27);
            tbZoom.Maximum = 256;
            tbZoom.Minimum = 32;
            tbZoom.Name = "tbZoom";
            tbZoom.Size = new Size(117, 147);
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
            grpEdit.Location = new Point(496, 0);
            grpEdit.Margin = new Padding(4, 5, 4, 5);
            grpEdit.Name = "grpEdit";
            grpEdit.Padding = new Padding(4, 5, 4, 5);
            grpEdit.Size = new Size(116, 177);
            grpEdit.TabIndex = 25;
            grpEdit.TabStop = false;
            grpEdit.Text = "Edit Mode";
            // 
            // rdoLock
            // 
            rdoLock.AutoSize = true;
            rdoLock.Location = new Point(10, 122);
            rdoLock.Margin = new Padding(4, 5, 4, 5);
            rdoLock.Name = "rdoLock";
            rdoLock.Size = new Size(73, 29);
            rdoLock.TabIndex = 2;
            rdoLock.Tag = "2";
            rdoLock.Text = "Lock";
            rdoLock.UseVisualStyleBackColor = true;
            rdoLock.Click += RdoMode_Click;
            // 
            // rdoSelect
            // 
            rdoSelect.AutoSize = true;
            rdoSelect.Location = new Point(10, 83);
            rdoSelect.Margin = new Padding(4, 5, 4, 5);
            rdoSelect.Name = "rdoSelect";
            rdoSelect.Size = new Size(83, 29);
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
            rdoEdit.Location = new Point(10, 44);
            rdoEdit.Margin = new Padding(4, 5, 4, 5);
            rdoEdit.Name = "rdoEdit";
            rdoEdit.Size = new Size(67, 29);
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
            groupBox1.Location = new Point(386, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(110, 177);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected";
            // 
            // btnLockSelected
            // 
            btnLockSelected.AutoSize = true;
            btnLockSelected.Font = new Font("Segoe UI", 9F);
            btnLockSelected.Location = new Point(7, 82);
            btnLockSelected.Margin = new Padding(4, 5, 4, 5);
            btnLockSelected.Name = "btnLockSelected";
            btnLockSelected.Size = new Size(94, 43);
            btnLockSelected.TabIndex = 19;
            btnLockSelected.Text = "Lock";
            btnLockSelected.UseVisualStyleBackColor = true;
            btnLockSelected.Click += BtnLockSelected_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(9, 127);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 43);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnToggleSelect
            // 
            btnToggleSelect.AutoSize = true;
            btnToggleSelect.Font = new Font("Segoe UI", 9F);
            btnToggleSelect.Location = new Point(7, 37);
            btnToggleSelect.Margin = new Padding(4, 5, 4, 5);
            btnToggleSelect.Name = "btnToggleSelect";
            btnToggleSelect.Size = new Size(96, 43);
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
            grpMove.Location = new Point(291, 0);
            grpMove.Margin = new Padding(4, 5, 4, 5);
            grpMove.Name = "grpMove";
            grpMove.Padding = new Padding(4, 5, 4, 5);
            grpMove.Size = new Size(95, 177);
            grpMove.TabIndex = 23;
            grpMove.TabStop = false;
            grpMove.Text = "Move";
            // 
            // btnMoveDown
            // 
            btnMoveDown.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveDown.Location = new Point(54, 90);
            btnMoveDown.Margin = new Padding(4, 5, 4, 5);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(37, 43);
            btnMoveDown.TabIndex = 3;
            btnMoveDown.Tag = "3";
            btnMoveDown.Text = "6";
            btnMoveDown.UseVisualStyleBackColor = true;
            btnMoveDown.Click += BtnMove_Click;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveUp.Location = new Point(9, 90);
            btnMoveUp.Margin = new Padding(4, 5, 4, 5);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new Size(37, 43);
            btnMoveUp.TabIndex = 2;
            btnMoveUp.Tag = "2";
            btnMoveUp.Text = "5";
            btnMoveUp.UseVisualStyleBackColor = true;
            btnMoveUp.Click += BtnMove_Click;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveRight.Location = new Point(54, 37);
            btnMoveRight.Margin = new Padding(4, 5, 4, 5);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(37, 43);
            btnMoveRight.TabIndex = 1;
            btnMoveRight.Tag = "1";
            btnMoveRight.Text = "4";
            btnMoveRight.UseVisualStyleBackColor = true;
            btnMoveRight.Click += BtnMove_Click;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveLeft.Location = new Point(9, 37);
            btnMoveLeft.Margin = new Padding(4, 5, 4, 5);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(37, 43);
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
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 177);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // numCharacterCount
            // 
            numCharacterCount.Location = new Point(154, 139);
            numCharacterCount.Margin = new Padding(4, 5, 4, 5);
            numCharacterCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numCharacterCount.Name = "numCharacterCount";
            numCharacterCount.Size = new Size(60, 31);
            numCharacterCount.TabIndex = 15;
            numCharacterCount.ValueChanged += NumCharacterCount_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 142);
            label5.Margin = new Padding(4, 5, 4, 5);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 14;
            label5.Text = "Character Count:";
            // 
            // lblStartCharacter
            // 
            lblStartCharacter.BorderStyle = BorderStyle.FixedSingle;
            lblStartCharacter.Location = new Point(210, 101);
            lblStartCharacter.Margin = new Padding(4, 0, 4, 0);
            lblStartCharacter.Name = "lblStartCharacter";
            lblStartCharacter.Size = new Size(38, 31);
            lblStartCharacter.TabIndex = 13;
            lblStartCharacter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numStartCharacter
            // 
            numStartCharacter.Location = new Point(141, 101);
            numStartCharacter.Margin = new Padding(4, 5, 4, 5);
            numStartCharacter.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numStartCharacter.Name = "numStartCharacter";
            numStartCharacter.Size = new Size(60, 31);
            numStartCharacter.TabIndex = 12;
            numStartCharacter.ValueChanged += NumStartCharacter_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 104);
            label4.Margin = new Padding(4, 5, 4, 5);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 11;
            label4.Text = "Start Character:";
            // 
            // numHeight
            // 
            numHeight.Location = new Point(220, 63);
            numHeight.Margin = new Padding(4, 5, 4, 5);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(60, 31);
            numHeight.TabIndex = 10;
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(124, 63);
            numWidth.Margin = new Padding(4, 5, 4, 5);
            numWidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(60, 31);
            numWidth.TabIndex = 9;
            numWidth.ValueChanged += NumWidth_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 8;
            label3.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 66);
            label2.Margin = new Padding(4, 5, 4, 5);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 7;
            label2.Text = "Dimensions:";
            // 
            // txtFontName
            // 
            txtFontName.Location = new Point(76, 22);
            txtFontName.Margin = new Padding(4, 5, 4, 5);
            txtFontName.Name = "txtFontName";
            txtFontName.Size = new Size(204, 31);
            txtFontName.TabIndex = 4;
            txtFontName.TextChanged += TxtFontName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Margin = new Padding(4, 5, 4, 5);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
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
            flpCharacters.Margin = new Padding(4, 5, 4, 5);
            flpCharacters.Name = "flpCharacters";
            flpCharacters.Size = new Size(1345, 600);
            flpCharacters.TabIndex = 13;
            // 
            // AtxFont
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AtxFont";
            Size = new Size(1345, 681);
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
