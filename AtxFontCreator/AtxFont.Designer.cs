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
            btnSelectAll = new Button();
            btnClear = new Button();
            btnSelectNone = new Button();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCharacterCount).BeginInit();
            grpMove.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 3);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Dimensions:";
            // 
            // txtFontName
            // 
            txtFontName.Location = new Point(48, 0);
            txtFontName.Name = "txtFontName";
            txtFontName.Size = new Size(121, 23);
            txtFontName.TabIndex = 2;
            txtFontName.TextChanged += TxtFontName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 3);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 4;
            label3.Text = "x";
            // 
            // numWidth
            // 
            numWidth.Location = new Point(247, 0);
            numWidth.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(42, 23);
            numWidth.TabIndex = 5;
            numWidth.ValueChanged += NumWidth_ValueChanged;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(314, 0);
            numHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(42, 23);
            numHeight.TabIndex = 6;
            numHeight.ValueChanged += NumHeight_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 33);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Start Character:";
            // 
            // numStartCharacter
            // 
            numStartCharacter.Location = new Point(94, 31);
            numStartCharacter.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numStartCharacter.Name = "numStartCharacter";
            numStartCharacter.Size = new Size(42, 23);
            numStartCharacter.TabIndex = 8;
            numStartCharacter.ValueChanged += NumStartCharacter_ValueChanged;
            // 
            // lblStartCharacter
            // 
            lblStartCharacter.BorderStyle = BorderStyle.FixedSingle;
            lblStartCharacter.Location = new Point(142, 31);
            lblStartCharacter.Name = "lblStartCharacter";
            lblStartCharacter.Size = new Size(27, 23);
            lblStartCharacter.TabIndex = 9;
            lblStartCharacter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 33);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 10;
            label5.Text = "Character Count:";
            // 
            // numCharacterCount
            // 
            numCharacterCount.Location = new Point(278, 31);
            numCharacterCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numCharacterCount.Name = "numCharacterCount";
            numCharacterCount.Size = new Size(42, 23);
            numCharacterCount.TabIndex = 11;
            numCharacterCount.ValueChanged += NumCharacterCount_ValueChanged;
            // 
            // flpCharacters
            // 
            flpCharacters.AutoScroll = true;
            flpCharacters.BorderStyle = BorderStyle.Fixed3D;
            flpCharacters.Location = new Point(3, 60);
            flpCharacters.Name = "flpCharacters";
            flpCharacters.Size = new Size(739, 348);
            flpCharacters.TabIndex = 12;
            // 
            // grpMove
            // 
            grpMove.Controls.Add(btnMoveDown);
            grpMove.Controls.Add(btnMoveUp);
            grpMove.Controls.Add(btnMoveRight);
            grpMove.Controls.Add(btnMoveLeft);
            grpMove.Location = new Point(362, 0);
            grpMove.Name = "grpMove";
            grpMove.Size = new Size(134, 54);
            grpMove.TabIndex = 13;
            grpMove.TabStop = false;
            grpMove.Text = "Move";
            // 
            // btnMoveDown
            // 
            btnMoveDown.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMoveDown.Location = new Point(102, 22);
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
            btnMoveUp.Location = new Point(70, 22);
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
            // btnSelectAll
            // 
            btnSelectAll.Location = new Point(502, 3);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(51, 51);
            btnSelectAll.TabIndex = 14;
            btnSelectAll.Text = "Select All";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += BtnSelectAll_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(616, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(51, 51);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSelectNone
            // 
            btnSelectNone.Location = new Point(559, 3);
            btnSelectNone.Name = "btnSelectNone";
            btnSelectNone.Size = new Size(51, 51);
            btnSelectNone.TabIndex = 16;
            btnSelectNone.Text = "Select None";
            btnSelectNone.UseVisualStyleBackColor = true;
            btnSelectNone.Click += BtnSelectNone_Click;
            // 
            // AtxFont
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSelectNone);
            Controls.Add(btnClear);
            Controls.Add(btnSelectAll);
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
            Name = "AtxFont";
            Size = new Size(745, 411);
            Load += AtxFont_Load;
            Resize += AtxFont_Resize;
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCharacterCount).EndInit();
            grpMove.ResumeLayout(false);
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
        private Button btnSelectAll;
        private Button btnClear;
        private Button btnSelectNone;
    }
}
