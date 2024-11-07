namespace AtxFontCreator
{
    partial class AtxCharacter
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
            SuspendLayout();
            // 
            // AtxCharacter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AtxCharacter";
            Size = new Size(443, 702);
            Paint += AtxCharacter_Paint;
            Resize += AtxCharacter_Resize;
            ResumeLayout(false);
        }

        #endregion
    }
}
