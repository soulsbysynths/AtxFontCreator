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
    public partial class AtxScreen : Form
    {
        private readonly List<AtxLayer> layers = [];
        public AtxScreen()
        {
            InitializeComponent();
            if (layers.Count == 0)
            {
                AddNewLayer();
            }
        }

        public void AddNewLayer()
        {
            layers.Add(new AtxLayer()
            {
                Id = layers.Count,
                CharacterSize = new Size(12, 2),
            });

            lstLayers.DataSource = layers;
            lstLayers.DisplayMember = "IdName";
        }

        private Size pixelSize;

        private void LstLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLayers.SelectedIndex < 0 || lstLayers.SelectedIndex >= layers.Count)
            {
                return;
            }

            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(layers[lstLayers.SelectedIndex]);
        }

        public Size PixelSize
        {
            get { return pixelSize; }
            set { pixelSize = value; }
        }


    }
}
