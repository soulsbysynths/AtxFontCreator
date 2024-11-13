namespace AtxFontCreator
{
    partial class AtxFontDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstFonts = new ListBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lstFonts
            // 
            lstFonts.FormattingEnabled = true;
            lstFonts.ItemHeight = 25;
            lstFonts.Location = new Point(12, 12);
            lstFonts.Name = "lstFonts";
            lstFonts.Size = new Size(212, 404);
            lstFonts.TabIndex = 0;
            lstFonts.SelectedIndexChanged += LstFonts_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(230, 12);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 34);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += BtnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(230, 52);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AtxFontDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(354, 429);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lstFonts);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AtxFontDialog";
            Text = "ATX Font";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstFonts;
        private Button btnOk;
        private Button btnCancel;
    }
}