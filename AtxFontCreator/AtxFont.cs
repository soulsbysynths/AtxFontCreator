using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private readonly List<AtxCharacter> characters = [];

        public enum EditMode
        {
            Edit,
            Select,
            Lock,
        }

        private EditMode mode;

        public EditMode Mode
        {
            get { return mode; }
            set
            {
                mode = value;
                switch (mode)
                {
                    case EditMode.Edit:
                        rdoEdit.Checked = true;
                        break;
                    case EditMode.Select:
                        rdoSelect.Checked = true;
                        break;
                    case EditMode.Lock:
                        rdoLock.Checked = true;
                        break;
                }
            }
        }


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
                if (dimensions == value)
                {
                    return;
                }

                dimensions = value;
                numWidth.Value = dimensions.Width;
                numHeight.Value = dimensions.Height;

                foreach (AtxCharacter character in characters)
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
                if (startCharacter == value)
                {
                    return;
                }

                startCharacter = value;
                numStartCharacter.Value = (int)startCharacter;
                lblStartCharacter.Text = ((char)startCharacter).ToString();
                AddRemovecharacters();
                StartCharacterChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CharacterCount
        {
            get { return characterCount; }
            set
            {
                if (characterCount == value)
                {
                    return;
                }

                characterCount = value;
                numCharacterCount.Value = characterCount;
                AddRemovecharacters();
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

        public AtxCharacter GetCharacter(int charIndex)
        {
            if (charIndex < 0 || charIndex >= characterCount)
            {
                AtxCharacter atxCharacter = new()
                {
                    Dimensions = dimensions
                };
                return atxCharacter;
            }
            else
            {
                return characters[charIndex];
            }
        }

        public AtxCharacter GetCharacter(char character)
        {
            int charIndex = (int)character - startCharacter;
            return GetCharacter(charIndex);
        }

        private void AddRemovecharacters()
        {

            if (characterCount == 0)
            {
                return;
            }

            if (characters.Count == characterCount && characters[0].Character == startCharacter)
            {
                return;
            }

            for (int i = characters.Count - 1; i >= 0; i--)
            {
                if (characters[i].Character > GetEndCharacter() || characters[i].Character < startCharacter)
                {
                    characters[i].Dispose();
                    characters.RemoveAt(i);
                }
            }

            if (characters.Count == 0)
            {
                for (int i = startCharacter; i <= GetEndCharacter(); i++)
                {
                    characters.Add(CreateCharacter((char)i));
                }
            }
            else
            {
                List<AtxCharacter> newcharacters = [];
                for (int i = startCharacter; i < characters[0].Character; i++)
                {
                    newcharacters.Add(CreateCharacter((char)i));
                }

                characters.InsertRange(0, newcharacters);
                newcharacters.Clear();
                for (int i = characters[^1].Character + 1; i <= GetEndCharacter(); i++)
                {
                    newcharacters.Add(CreateCharacter((char)i));
                }

                characters.AddRange(newcharacters);
            }

            foreach (Control control in flpCharacters.Controls)
            {
                if (control is not AtxCharacter)
                {
                    continue;
                }

                if (!characters.Contains(control))
                {
                    flpCharacters.Controls.Remove(control);
                }
            }

            for (int i = 0; i < characterCount; i++)
            {
                if (!flpCharacters.Contains(characters[i]))
                {
                    flpCharacters.Controls.Add(characters[i]);
                }

                flpCharacters.Controls.SetChildIndex(characters[i], i);
            }
        }

        private AtxCharacter CreateCharacter(char c)
        {
            AtxCharacter character = new()
            {
                Visible = true,
                Character = c,
                Dimensions = dimensions,
                Height = tbZoom.Value,
            };

            character.MouseDown += AtxCharacter_MouseDown;
            character.MouseMove += AtxCharacter_MouseMove;
            return character;
        }

        private void AtxCharacter_MouseDown(object? sender, MouseEventArgs e)
        {
            if (sender is not AtxCharacter character || e.Button != MouseButtons.Left)
            {
                return;
            }

            switch (mode)
            {
                case EditMode.Edit:
                    character.StartEditPixel(e.Location);
                    break;
                case EditMode.Select:
                    if (!character.Locked)
                    {
                        character.Selected = !character.Selected;
                    }
                    break;
                case EditMode.Lock:
                    character.Locked = !character.Locked;
                    if (character.Locked)
                    {
                        character.Selected = false;
                    }
                    break;
            }
        }

        private void AtxCharacter_MouseMove(object? sender, MouseEventArgs e)
        {
            if (sender is not AtxCharacter character)
            {
                return;
            }

            if (e.Button == MouseButtons.Left && mode == EditMode.Edit)
            {
                character.ContinueEditPixel(e.Location);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the selected characters?", "Clear Selected Characters", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            foreach (AtxCharacter character in characters)
            {
                if (character.Selected)
                {
                    character.Clear();
                }
            }
        }

        private void RdoMode_Click(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            Mode = (EditMode)Convert.ToInt32(button.Tag);
        }

        private void TbZoom_Scroll(object sender, EventArgs e)
        {
            foreach (AtxCharacter character in characters)
            {
                character.Height = tbZoom.Value;
            }

            foreach (AtxCharacter character in characters)
            {
                character.Invalidate();
            }
        }

        private void BtnToggleSelect_Click(object sender, EventArgs e)
        {
            foreach (AtxCharacter character in characters)
            {
                character.Selected = !character.Selected;
            }
        }

        private void BtnLockSelected_Click(object sender, EventArgs e)
        {
            foreach (AtxCharacter character in characters)
            {
                if (character.Selected)
                {
                    character.Locked = !character.Locked;
                }
            }
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AtxCharacter.Direction direction = (AtxCharacter.Direction?)button.Tag ?? AtxCharacter.Direction.Up;
            foreach (AtxCharacter character in characters)
            {
                if (character.Selected)
                {
                    character.MovePixels(direction);
                }
            }
        }

        private void AtxFont_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }
    }
}
