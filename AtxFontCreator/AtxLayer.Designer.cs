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
            txtCharacters = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cboColour = new ComboBox();
            label3 = new Label();
            cboDrawMode = new ComboBox();
            picLayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLayer).BeginInit();
            SuspendLayout();
            // 
            // txtCharacters
            // 
            txtCharacters.Location = new Point(107, 6);
            txtCharacters.Multiline = true;
            txtCharacters.Name = "txtCharacters";
            txtCharacters.ScrollBars = ScrollBars.Both;
            txtCharacters.Size = new Size(365, 73);
            txtCharacters.TabIndex = 0;
            txtCharacters.TextChanged += TxtCharacters_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Characters:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 6);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Colour:";
            // 
            // cboColour
            // 
            cboColour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColour.FormattingEnabled = true;
            cboColour.Items.AddRange(new object[] { "White", "Light Grey", "Grey", "Dark Grey", "Black" });
            cboColour.Location = new Point(602, 3);
            cboColour.Name = "cboColour";
            cboColour.Size = new Size(169, 33);
            cboColour.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 49);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 4;
            label3.Text = "Draw Mode:";
            // 
            // cboDrawMode
            // 
            cboDrawMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDrawMode.FormattingEnabled = true;
            cboDrawMode.Items.AddRange(new object[] { "Mask", "Not Mask", "And Mask", "And Not Mask", "Or Mask", "Or Not Mask", "Xor Mask", "Xor Not Mask" });
            cboDrawMode.Location = new Point(602, 46);
            cboDrawMode.Name = "cboDrawMode";
            cboDrawMode.Size = new Size(169, 33);
            cboDrawMode.TabIndex = 5;
            // 
            // picLayer
            // 
            picLayer.BackColor = SystemColors.ControlDark;
            picLayer.Location = new Point(3, 85);
            picLayer.Name = "picLayer";
            picLayer.Size = new Size(1242, 655);
            picLayer.TabIndex = 6;
            picLayer.TabStop = false;
            picLayer.Paint += PicLayer_Paint;
            // 
            // AtxLayer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(picLayer);
            Controls.Add(cboDrawMode);
            Controls.Add(label3);
            Controls.Add(cboColour);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCharacters);
            Name = "AtxLayer";
            Size = new Size(1248, 743);
            Paint += AtxLayer_Paint;
            Resize += AtxLayer_Resize;
            ((System.ComponentModel.ISupportInitialize)picLayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCharacters;
        private Label label1;
        private Label label2;
        private ComboBox cboColour;
        private Label label3;
        private ComboBox cboDrawMode;
        private PictureBox picLayer;
    }
}
