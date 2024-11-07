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
            label1 = new Label();
            label2 = new Label();
            txtFontName = new TextBox();
            label3 = new Label();
            numWidth = new NumericUpDown();
            numHeight = new NumericUpDown();
            label4 = new Label();
            numStartCharacter = new NumericUpDown();
            lblStartCharacter = new Label();
            label5 = new Label();
            numCharacterCount = new NumericUpDown();
            flpCharacters = new FlowLayoutPanel();
            grpMove = new GroupBox();
            btnMoveDown = new Button();
            btnMoveUp = new Button();
            btnMoveRight = new Button();
            btnMoveLeft = new Button();
            grpEdit = new GroupBox();
            rdoLock = new RadioButton();
            rdoSelect = new RadioButton();
            rdoEdit = new RadioButton();
            tbZoom = new TrackBar();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnLockSelected = new Button();
            btnClear = new Button();
            btnToggleSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCharacterCount).BeginInit();
            grpMove.SuspendLayout();
            grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbZoom).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Dimensions:";
            // 
            // txtFontName
            // 
            txtFontName.Location = new Point(69, 0);
            txtFontName.Margin = new Padding(4, 5, 4, 5);
            txtFontName.Name = "txtFontName";
            txtFontName.Size = new Size(171, 31);
            txtFontName.TabIndex = 2;
            txtFontName.TextChanged += TxtFontName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 5);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 4;
            label3.Text = "x";
            // 
            // numWidth
            // 
            numWidth.Location = new Point(353, 0);
            numWidth.Margin = new Padding(4, 5, 4, 5);
            numWidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(60, 31);
            numWidth.TabIndex = 5;
            numWidth.ValueChanged += NumWidth_ValueChanged;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(449, 0);
            numHeight.Margin = new Padding(4, 5, 4, 5);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(60, 31);
            numHeight.TabIndex = 6;
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 55);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 7;
            label4.Text = "Start Character:";
            // 
            // numStartCharacter
            // 
            numStartCharacter.Location = new Point(134, 52);
            numStartCharacter.Margin = new Padding(4, 5, 4, 5);
            numStartCharacter.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numStartCharacter.Name = "numStartCharacter";
            numStartCharacter.Size = new Size(60, 31);
            numStartCharacter.TabIndex = 8;
            numStartCharacter.ValueChanged += NumStartCharacter_ValueChanged;
            // 
            // lblStartCharacter
            // 
            lblStartCharacter.BorderStyle = BorderStyle.FixedSingle;
            lblStartCharacter.Location = new Point(203, 52);
            lblStartCharacter.Margin = new Padding(4, 0, 4, 0);
            lblStartCharacter.Name = "lblStartCharacter";
            lblStartCharacter.Size = new Size(38, 37);
            lblStartCharacter.TabIndex = 9;
            lblStartCharacter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 55);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 10;
            label5.Text = "Character Count:";
            // 
            // numCharacterCount
            // 
            numCharacterCount.Location = new Point(397, 52);
            numCharacterCount.Margin = new Padding(4, 5, 4, 5);
            numCharacterCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numCharacterCount.Name = "numCharacterCount";
            numCharacterCount.Size = new Size(60, 31);
            numCharacterCount.TabIndex = 11;
            numCharacterCount.ValueChanged += NumCharacterCount_ValueChanged;
            // 
            // flpCharacters
            // 
            flpCharacters.AutoScroll = true;
            flpCharacters.BackColor = SystemColors.ControlDark;
            flpCharacters.BorderStyle = BorderStyle.Fixed3D;
            flpCharacters.Location = new Point(4, 100);
            flpCharacters.Margin = new Padding(4, 5, 4, 5);
            flpCharacters.Name = "flpCharacters";
            flpCharacters.Size = new Size(1335, 577);
            flpCharacters.TabIndex = 12;
            // 
            // grpMove
            // 
            grpMove.Controls.Add(btnMoveDown);
            grpMove.Controls.Add(btnMoveUp);
            grpMove.Controls.Add(btnMoveRight);
            grpMove.Controls.Add(btnMoveLeft);
            grpMove.Location = new Point(517, 0);
            grpMove.Margin = new Padding(4, 5, 4, 5);
            grpMove.Name = "grpMove";
            grpMove.Padding = new Padding(4, 5, 4, 5);
            grpMove.Size = new Size(191, 90);
            grpMove.TabIndex = 13;
            grpMove.TabStop = false;
            grpMove.Text = "Move";
            // 
            // btnMoveDown
            // 
            btnMoveDown.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveDown.Location = new Point(146, 37);
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
            btnMoveUp.Location = new Point(100, 37);
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
            // grpEdit
            // 
            grpEdit.Controls.Add(rdoLock);
            grpEdit.Controls.Add(rdoSelect);
            grpEdit.Controls.Add(rdoEdit);
            grpEdit.Location = new Point(961, 0);
            grpEdit.Margin = new Padding(4, 5, 4, 5);
            grpEdit.Name = "grpEdit";
            grpEdit.Padding = new Padding(4, 5, 4, 5);
            grpEdit.Size = new Size(244, 90);
            grpEdit.TabIndex = 17;
            grpEdit.TabStop = false;
            grpEdit.Text = "Edit Mode";
            // 
            // rdoLock
            // 
            rdoLock.AutoSize = true;
            rdoLock.Location = new Point(170, 42);
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
            rdoSelect.Location = new Point(81, 42);
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
            rdoEdit.Location = new Point(9, 42);
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
            // tbZoom
            // 
            tbZoom.LargeChange = 16;
            tbZoom.Location = new Point(1211, 11);
            tbZoom.Maximum = 256;
            tbZoom.Minimum = 32;
            tbZoom.Name = "tbZoom";
            tbZoom.Size = new Size(132, 69);
            tbZoom.SmallChange = 16;
            tbZoom.TabIndex = 18;
            tbZoom.TickFrequency = 16;
            tbZoom.Value = 96;
            tbZoom.Scroll += TbZoom_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1247, 52);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 19;
            label6.Text = "Zoom";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLockSelected);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnToggleSelect);
            groupBox1.Location = new Point(715, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 90);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected";
            // 
            // btnLockSelected
            // 
            btnLockSelected.AutoSize = true;
            btnLockSelected.Font = new Font("Segoe UI", 9F);
            btnLockSelected.Location = new Point(90, 37);
            btnLockSelected.Margin = new Padding(4, 5, 4, 5);
            btnLockSelected.Name = "btnLockSelected";
            btnLockSelected.Size = new Size(73, 43);
            btnLockSelected.TabIndex = 19;
            btnLockSelected.Text = "Lock";
            btnLockSelected.UseVisualStyleBackColor = true;
            btnLockSelected.Click += BtnLockSelected_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(171, 37);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 43);
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
            btnToggleSelect.Size = new Size(75, 43);
            btnToggleSelect.TabIndex = 17;
            btnToggleSelect.Text = "Toggle";
            btnToggleSelect.UseVisualStyleBackColor = true;
            btnToggleSelect.Click += BtnToggleSelect_Click;
            // 
            // AtxFont
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 681);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(tbZoom);
            Controls.Add(grpEdit);
            Controls.Add(grpMove);
            Controls.Add(flpCharacters);
            Controls.Add(numCharacterCount);
            Controls.Add(label5);
            Controls.Add(lblStartCharacter);
            Controls.Add(numStartCharacter);
            Controls.Add(label4);
            Controls.Add(numHeight);
            Controls.Add(numWidth);
            Controls.Add(label3);
            Controls.Add(txtFontName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AtxFont";
            Resize += AtxFont_Resize;
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCharacterCount).EndInit();
            grpMove.ResumeLayout(false);
            grpEdit.ResumeLayout(false);
            grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbZoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFontName;
        private Label label3;
        private NumericUpDown numWidth;
        private NumericUpDown numHeight;
        private Label label4;
        private NumericUpDown numStartCharacter;
        private Label lblStartCharacter;
        private Label label5;
        private NumericUpDown numCharacterCount;
        private FlowLayoutPanel flpCharacters;
        private GroupBox grpMove;
        private Button btnMoveLeft;
        private Button btnMoveDown;
        private Button btnMoveUp;
        private Button btnMoveRight;
        private GroupBox grpEdit;
        private RadioButton rdoLock;
        private RadioButton rdoSelect;
        private RadioButton rdoEdit;
        private TrackBar tbZoom;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnLockSelected;
        private Button btnClear;
        private Button btnToggleSelect;
    }
}
