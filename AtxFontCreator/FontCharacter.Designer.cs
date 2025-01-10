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
            SuspendLayout();
            // 
            // lblCharacter
            // 
            lblCharacter.BackColor = Color.Transparent;
            lblCharacter.ForeColor = Color.White;
            lblCharacter.Location = new Point(0, 0);
            lblCharacter.Margin = new Padding(0);
            lblCharacter.Name = "lblCharacter";
            lblCharacter.Size = new Size(17, 17);
            lblCharacter.TabIndex = 0;
            lblCharacter.Text = "A";
            lblCharacter.TextAlign = ContentAlignment.MiddleCenter;
            lblCharacter.Visible = false;
            // 
            // FontCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(lblCharacter);
            Name = "FontCharacter";
            Size = new Size(144, 125);
            SizeChanged += FontCharacter_SizeChanged;
            Click += FontCharacter_Click;
            Paint += FontCharacter_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Label lblCharacter;
    }
}
