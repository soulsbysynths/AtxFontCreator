using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtxFontCreator
{
    public partial class AtxFontDialog : Form
    {
        public AtxFontDialog(List<AtxFont> fontList)
        {
            InitializeComponent();
            lstFonts.DataSource = fontList;
            lstFonts.DisplayMember = "FontName";
        }

        public AtxFont AtxFont { get; set; } = new AtxFont();

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
        }

        public DialogResult ShowDialog()
        {
            return this.ShowDialog();
        }

        private void LstFonts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
