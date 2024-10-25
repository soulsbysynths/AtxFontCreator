namespace AtxFontCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            atxFont1 = new AtxFont();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            chkIncludeNumbers = new CheckBox();
            chkIncludeMisc = new CheckBox();
            chkIncludePunctuation = new CheckBox();
            chkIncludeCharacters = new CheckBox();
            lblFont = new Label();
            chkCopyToAtxFont = new CheckBox();
            flpFontConverter = new FlowLayoutPanel();
            btnFont = new Button();
            tabPage2 = new TabPage();
            atxCharacter1 = new AtxCharacter();
            fontDialog1 = new FontDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1240, 651);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(atxFont1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1232, 623);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "ATX Font";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // atxFont1
            // 
            atxFont1.CharacterCount = 95;
            atxFont1.Dimensions = new Size(8, 16);
            atxFont1.FontName = "AtxFont";
            atxFont1.Location = new Point(6, 6);
            atxFont1.Margin = new Padding(4, 5, 4, 5);
            atxFont1.Name = "atxFont1";
            atxFont1.Size = new Size(1222, 610);
            atxFont1.StartCharacter = 32;
            atxFont1.TabIndex = 0;
            atxFont1.DimensionsChanged += AtxFont1_DimensionsChanged;
            atxFont1.StartCharacterChanged += AtxFont1_StartCharacterChanged;
            atxFont1.CharacterCountChanged += AtxFont1_CharacterCountChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(lblFont);
            tabPage1.Controls.Add(chkCopyToAtxFont);
            tabPage1.Controls.Add(flpFontConverter);
            tabPage1.Controls.Add(btnFont);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1232, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Font Converter";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIncludeNumbers);
            groupBox1.Controls.Add(chkIncludeMisc);
            groupBox1.Controls.Add(chkIncludePunctuation);
            groupBox1.Controls.Add(chkIncludeCharacters);
            groupBox1.Location = new Point(73, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 42);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Include";
            // 
            // chkIncludeNumbers
            // 
            chkIncludeNumbers.AutoSize = true;
            chkIncludeNumbers.Location = new Point(6, 17);
            chkIncludeNumbers.Name = "chkIncludeNumbers";
            chkIncludeNumbers.Size = new Size(75, 19);
            chkIncludeNumbers.TabIndex = 4;
            chkIncludeNumbers.Text = "Numbers";
            chkIncludeNumbers.UseVisualStyleBackColor = true;
            chkIncludeNumbers.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludeMisc
            // 
            chkIncludeMisc.AutoSize = true;
            chkIncludeMisc.Location = new Point(272, 17);
            chkIncludeMisc.Name = "chkIncludeMisc";
            chkIncludeMisc.Size = new Size(51, 19);
            chkIncludeMisc.TabIndex = 2;
            chkIncludeMisc.Text = "Misc";
            chkIncludeMisc.UseVisualStyleBackColor = true;
            chkIncludeMisc.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludePunctuation
            // 
            chkIncludePunctuation.AutoSize = true;
            chkIncludePunctuation.Location = new Point(175, 17);
            chkIncludePunctuation.Name = "chkIncludePunctuation";
            chkIncludePunctuation.Size = new Size(91, 19);
            chkIncludePunctuation.TabIndex = 1;
            chkIncludePunctuation.Text = "Punctuation";
            chkIncludePunctuation.UseVisualStyleBackColor = true;
            chkIncludePunctuation.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // chkIncludeCharacters
            // 
            chkIncludeCharacters.AutoSize = true;
            chkIncludeCharacters.Location = new Point(87, 17);
            chkIncludeCharacters.Name = "chkIncludeCharacters";
            chkIncludeCharacters.Size = new Size(82, 19);
            chkIncludeCharacters.TabIndex = 0;
            chkIncludeCharacters.Text = "Characters";
            chkIncludeCharacters.UseVisualStyleBackColor = true;
            chkIncludeCharacters.CheckedChanged += ChkInclude_CheckedChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(6, 605);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(0, 15);
            lblFont.TabIndex = 1;
            lblFont.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkCopyToAtxFont
            // 
            chkCopyToAtxFont.AutoSize = true;
            chkCopyToAtxFont.Checked = true;
            chkCopyToAtxFont.CheckState = CheckState.Checked;
            chkCopyToAtxFont.Location = new Point(1110, 14);
            chkCopyToAtxFont.Name = "chkCopyToAtxFont";
            chkCopyToAtxFont.Size = new Size(116, 19);
            chkCopyToAtxFont.TabIndex = 3;
            chkCopyToAtxFont.Text = "Copy to ATX font";
            chkCopyToAtxFont.UseVisualStyleBackColor = true;
            // 
            // flpFontConverter
            // 
            flpFontConverter.AutoScroll = true;
            flpFontConverter.BorderStyle = BorderStyle.Fixed3D;
            flpFontConverter.Location = new Point(6, 54);
            flpFontConverter.Name = "flpFontConverter";
            flpFontConverter.Size = new Size(1220, 548);
            flpFontConverter.TabIndex = 2;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(6, 6);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(61, 42);
            btnFont.TabIndex = 0;
            btnFont.Text = "Font...";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += BtnFont_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(atxCharacter1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1232, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Character Editor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // atxCharacter1
            // 
            atxCharacter1.BorderStyle = BorderStyle.FixedSingle;
            atxCharacter1.Character = '\0';
            atxCharacter1.Dimensions = new Size(8, 16);
            atxCharacter1.Location = new Point(3, 3);
            atxCharacter1.Margin = new Padding(0);
            atxCharacter1.Mode = AtxCharacter.CharacterMode.Select;
            atxCharacter1.Name = "atxCharacter1";
            atxCharacter1.Size = new Size(230, 461);
            atxCharacter1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import...";
            importToolStripMenuItem.Click += ImportToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export...";
            exportToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Header files|*.h";
            openFileDialog1.FileOk += OpenFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "ATX Font Creator";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnFont;
        private TabPage tabPage2;
        private FontDialog fontDialog1;
        private Label lblFont;
        private TabPage tabPage3;
        private AtxFont atxFont1;
        private AtxCharacter atxCharacter1;
        private FlowLayoutPanel flpFontConverter;
        private CheckBox chkCopyToAtxFont;
        private GroupBox groupBox1;
        private CheckBox chkIncludeMisc;
        private CheckBox chkIncludePunctuation;
        private CheckBox chkIncludeCharacters;
        private CheckBox chkIncludeNumbers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
