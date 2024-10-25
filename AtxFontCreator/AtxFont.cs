using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtxFontCreator
{
    public partial class AtxFont : UserControl
    {
        public event EventHandler? DimensionsChanged;
        public event EventHandler? StartCharacterChanged;
        public event EventHandler? CharacterCountChanged;
        private string fontName = "";
        private Size dimensions;
        private int startCharacter;
        private int characterCount;
        public AtxFont()
        {
            InitializeComponent();
        }

        public List<AtxCharacter> Characters { get; set; } = [];

        public string FontName
        {
            get { return fontName; }
            set
            {
                fontName = value;
                txtFontName.Text = fontName;
            }
        }

        public Size Dimensions
        {
            get { return dimensions; }
            set
            {
                dimensions = value;
                numWidth.Value = dimensions.Width;
                numHeight.Value = dimensions.Height;

                foreach (AtxCharacter character in Characters)
                {
                    character.Dimensions = dimensions;
                }

                DimensionsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public int StartCharacter
        {
            get { return startCharacter; }
            set
            {
                startCharacter = value;
                numStartCharacter.Value = (int)startCharacter;
                lblStartCharacter.Text = ((char)startCharacter).ToString();
                AddRemoveCharacters();
                StartCharacterChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CharacterCount
        {
            get { return characterCount; }
            set
            {
                characterCount = value;
                numCharacterCount.Value = characterCount;
                AddRemoveCharacters();
                CharacterCountChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void TxtFontName_TextChanged(object sender, EventArgs e)
        {
            FontName = txtFontName.Text;
        }

        private void NumWidth_ValueChanged(object sender, EventArgs e)
        {
            Dimensions = new Size((int)numWidth.Value, dimensions.Height);
        }

        private void NumHeight_ValueChanged(object sender, EventArgs e)
        {
            Dimensions = new Size(dimensions.Width, (int)numHeight.Value);
        }

        private void NumStartCharacter_ValueChanged(object sender, EventArgs e)
        {
            StartCharacter = (char)numStartCharacter.Value;
        }

        private void NumCharacterCount_ValueChanged(object sender, EventArgs e)
        {
            CharacterCount = (int)numCharacterCount.Value;
        }

        private void AtxFont_Resize(object sender, EventArgs e)
        {
            flpCharacters.Width = this.Width - flpCharacters.Left - flpCharacters.Margin.Right;
            flpCharacters.Height = this.Height - flpCharacters.Top - flpCharacters.Margin.Bottom;
        }

        public int GetEndCharacter()
        {
            return (startCharacter + characterCount - 1);
        }

        private void AddRemoveCharacters()
        {
            const int CHARACTER_HEIGHT = 96;
            if (characterCount == 0)
            {
                return;
            }

            if (Characters.Count == characterCount && Characters[0].Character == startCharacter)
            {
                return;
            }

            for (int i = Characters.Count - 1; i >= 0; i--)
            {
                if (Characters[i].Character > GetEndCharacter() || Characters[i].Character < startCharacter)
                {
                    Characters[i].Dispose();
                    Characters.RemoveAt(i);
                }
            }

            if (Characters.Count == 0)
            {
                for (int i = startCharacter; i < GetEndCharacter(); i++)
                {
                    Characters.Add(new()
                    {
                        Visible = true,
                        Character = (char)i,
                        Dimensions = dimensions,
                        Height = CHARACTER_HEIGHT
                    });
                }

                return;
            }

            List<AtxCharacter> newCharacters = [];
            for (int i = startCharacter; i < Characters[0].Character; i++)
            {
                newCharacters.Add(new()
                {
                    Visible = true,
                    Character = (char)i,
                    Dimensions = dimensions,
                    Height = CHARACTER_HEIGHT
                });
            }

            Characters.InsertRange(0, newCharacters);
            newCharacters.Clear();
            for (int i = Characters[^1].Character + 1; i <= GetEndCharacter(); i++)
            {
                newCharacters.Add(new()
                {
                    Visible = true,
                    Character = (char)i,
                    Dimensions = dimensions,
                    Height = CHARACTER_HEIGHT
                });
            }

            Characters.AddRange(newCharacters);

            flpCharacters.SuspendLayout();
            flpCharacters.Controls.Clear();
            flpCharacters.Controls.AddRange([.. Characters]);
            flpCharacters.ResumeLayout();
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (AtxCharacter character in Characters)
            {
                if (character.Mode != AtxCharacter.CharacterMode.Lock)
                {
                    character.Mode = AtxCharacter.CharacterMode.Select;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (AtxCharacter character in Characters)
            {
                if (character.Mode == AtxCharacter.CharacterMode.Select)
                {
                    character.Clear();
                }
            }
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            foreach (AtxCharacter character in Characters)
            {
                if (character.Mode == AtxCharacter.CharacterMode.Select)
                {
                    character.MovePixels((AtxCharacter.Direction)Convert.ToInt32(((Button)sender).Tag!));
                }
            }
        }

        private void AtxFont_Load(object sender, EventArgs e)
        {

        }

        private void BtnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (AtxCharacter character in Characters)
            {
                if (character.Mode != AtxCharacter.CharacterMode.Lock)
                {
                    character.Mode = AtxCharacter.CharacterMode.Edit;
                }
            }
        }
    }
}
