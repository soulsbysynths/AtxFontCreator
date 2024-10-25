using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtxFontCreator
{
    static class AtxFontHeaderParser
    {
        public static void ImportHeader(StreamReader reader, ref AtxFont font)
        {
            List<string> lines = [];

            while (true)
            {
                string? line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    lines.Add(line);
                }

            }

            const int FontNameLine = 4;
            if (lines.Count > FontNameLine)
            {
                string[] words = lines[FontNameLine].Split(' ');
                const int FontNameWord = 3;
                if (words.Length > FontNameWord)
                {
                    font.FontName = words[FontNameWord];
                }
            }

            const int CharacterCountLine = 6;
            if (lines.Count > CharacterCountLine)
            {
                string[] words = lines[CharacterCountLine].Split(' ');
                const int CharacterCountWord = 4;
                if (words.Length > CharacterCountWord)
                {
                    font.CharacterCount = Convert.ToInt32(words[CharacterCountWord].Trim('[').Trim(']'));
                }
            }

            int DimensionsLine = font.CharacterCount + 9;
            if (lines.Count > DimensionsLine)
            {
                string[] words = lines[DimensionsLine].Split(' ');
                Size dimensions = new();
                const int WidthWord = 1;
                if (words.Length > WidthWord)
                {

                    dimensions.Width = Convert.ToInt32(words[WidthWord].Trim(','));
                }

                const int HeightWord = 2;
                if (words.Length > HeightWord)
                {

                    dimensions.Height = Convert.ToInt32(words[HeightWord]);
                }

                font.Dimensions = dimensions;
            }

            int StartCharacterLine = font.CharacterCount + 10;
            if (lines.Count > StartCharacterLine)
            {
                const int StartCharacterIndex = 2;
                if (lines[StartCharacterLine].Length >= StartCharacterIndex)
                {
                    font.StartCharacter = lines[StartCharacterLine][StartCharacterIndex];
                }
            }

        }

        static void ExportHeader(AtxFont font, StreamWriter writer)
        {
        }
    }
}
