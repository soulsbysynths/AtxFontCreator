namespace AtxFontCreator
{
    partial class FontCharacter
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
            lblCharacter = new Label();
            chkInclude = new CheckBox();
            picSource = new PictureBox();
            picDestination = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDestination).BeginInit();
            SuspendLayout();
            // 
            // lblCharacter
            // 
            lblCharacter.BorderStyle = BorderStyle.Fixed3D;
            lblCharacter.Location = new Point(3, 3);
            lblCharacter.Name = "lblCharacter";
            lblCharacter.Size = new Size(22, 23);
            lblCharacter.TabIndex = 0;
            lblCharacter.Text = "A";
            lblCharacter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkInclude
            // 
            chkInclude.AutoSize = true;
            chkInclude.Checked = true;
            chkInclude.CheckState = CheckState.Checked;
            chkInclude.Location = new Point(31, 6);
            chkInclude.Name = "chkInclude";
            chkInclude.Size = new Size(15, 14);
            chkInclude.TabIndex = 1;
            chkInclude.UseVisualStyleBackColor = true;
            chkInclude.Click += ChkInclude_Click;
            // 
            // picSource
            // 
            picSource.BackColor = Color.Black;
            picSource.Location = new Point(3, 29);
            picSource.Name = "picSource";
            picSource.Size = new Size(66, 92);
            picSource.TabIndex = 2;
            picSource.TabStop = false;
            picSource.Paint += PicSource_Paint;
            // 
            // picDestination
            // 
            picDestination.BackColor = Color.Black;
            picDestination.Location = new Point(75, 29);
            picDestination.Name = "picDestination";
            picDestination.Size = new Size(66, 92);
            picDestination.TabIndex = 3;
            picDestination.TabStop = false;
            picDestination.Paint += PicDestination_Paint;
            // 
            // FontCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(picDestination);
            Controls.Add(picSource);
            Controls.Add(chkInclude);
            Controls.Add(lblCharacter);
            Name = "FontCharacter";
            Size = new Size(142, 123);
            ((System.ComponentModel.ISupportInitialize)picSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDestination).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCharacter;
        private CheckBox chkInclude;
        private PictureBox picSource;
        private PictureBox picDestination;
    }
}
