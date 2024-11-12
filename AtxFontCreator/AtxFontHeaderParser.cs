using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AtxFontCreator
{
    static class AtxFontHeaderParser
    {
        public static bool ImportHeader(StreamReader reader, ref AtxFont font)
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
            if (lines.Count <= FontNameLine)
            {
                return false;
            }

            string[] words = lines[FontNameLine].Split(' ');
            const int FontNameWord = 3;
            if (words.Length > FontNameWord)
            {
                font.FontName = words[FontNameWord];
            }


            const int CharacterCountLine = 6;
            if (lines.Count <= CharacterCountLine)
            {
                return false;
            }

            words = lines[CharacterCountLine].Split(' ');
            const int CharacterCountWord = 3;
            if (words.Length > CharacterCountWord)
            {
                try
                {
                    font.CharacterCount = Convert.ToInt32(words[CharacterCountWord].Trim('[').Trim(']'));
                }
                catch
                {
                    return false;
                }
            }

            int PixelSizeLine = font.CharacterCount + 9;
            if (lines.Count <= PixelSizeLine)
            {
                return false;
            }
            
            words = lines[PixelSizeLine].Split(' ');
            Size dimensions = new();
            const int WidthWord = 1;
            if (words.Length > WidthWord)
            {
                try
                {
                    dimensions.Width = Convert.ToInt32(words[WidthWord].Trim(','));
                }
                catch
                {
                    return false;
                }
            }

            const int HeightWord = 2;
            if (words.Length > HeightWord)
            {
                try
                {
                    dimensions.Height = Convert.ToInt32(words[HeightWord]);

                }
                catch
                {
                    return false;
                }
            }

            font.PixelSize = dimensions;

            int StartCharacterLine = font.CharacterCount + 10;
            if (lines.Count <= StartCharacterLine)
            {
                return false;
            }
            
            const int StartCharacterIndex = 2;
            if (lines[StartCharacterLine].Length >= StartCharacterIndex)
            {
                font.StartCharacter = lines[StartCharacterLine][StartCharacterIndex];
            }

            const int CharacterLine = 8;
            if (lines.Count <= CharacterLine)
            {
                return false;
            }

            int c = 0;
            for (int l = CharacterLine; l < CharacterLine + font.CharacterCount; l++)
            {
                words = lines[l].Split(' ');
                const int CharacterWord = 4;
                int x = 0, y = 0, w = CharacterWord;
                while (w < words.Length)
                {
                    byte value = Convert.ToByte(words[w].Trim(','), 16);
                    for (int b = 0; b < 8; b++)
                    {
                        font.GetCharacter(c).SetPixel(new Point(x, y), BitFunctions.GetBit(value, b));
                        y++;
                    }

                    y -= 8;
                    x++;

                    if (x >= font.PixelSize.Width)
                    {
                        x = 0;
                        y += 8;
                    }

                    if (y >= font.PixelSize.Height)
                    {
                        break;
                    }

                    w++;
                }

                c++;
            }

            return true;
        }

        public static void ExportHeader(StreamWriter writer, AtxFont font)
        {
            writer.WriteLine("#pragma once");
            writer.WriteLine("#include <stdint.h>");
            writer.WriteLine("#include \"Font.h\"");
            writer.WriteLine();
            writer.WriteLine("static const Font " + font.FontName + " = ");
            writer.WriteLine("{");
            writer.WriteLine("\tnew const uint8_t* [" + font.CharacterCount.ToString() + "]");
            writer.WriteLine("{");
            int charBytes = (int)Math.Ceiling(font.PixelSize.Height / 8f) * font.PixelSize.Width;
            for (int l = 0; l < font.CharacterCount; l++)
            {
                writer.Write("\tnew const uint8_t[" + charBytes.ToString() + "] { ");
                int x = 0, y = 0;
                for (int w = 0; w < charBytes; w++)
                {
                    byte value = 0;
                    AtxCharacter atxCharacter = font.GetCharacter(l);
                    for (int b = 0; b < 8; b++)
                    {
                        BitFunctions.SetBit(ref value, b, atxCharacter.GetPixel(new Point(x, y)));
                        y++;
                    }

                    writer.Write("0x" + value.ToString("x2"));

                    if (w < (charBytes - 1))
                    {
                        writer.Write(", ");
                    }
                    else
                    {
                        writer.WriteLine(" }, /*" + ((int)atxCharacter.Character).ToString() + " " + atxCharacter.Character + "*/");
                    }

                    y -= 8;
                    x++;

                    if (x >= font.PixelSize.Width)
                    {
                        x = 0;
                        y += 8;
                    }

                    if (y >= font.PixelSize.Height)
                    {
                        break;
                    }
                }
            }

            writer.WriteLine("},");
            writer.WriteLine("\t{ " + font.PixelSize.Width.ToString() + ", " + font.PixelSize.Height.ToString() + " },");
            writer.WriteLine("\t'" + (char)font.StartCharacter + "',");
            writer.WriteLine("\t" + font.CharacterCount.ToString());
            writer.WriteLine("};");
        }
    }
}
