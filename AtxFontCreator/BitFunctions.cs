using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtxFontCreator
{
    static class BitFunctions
    {
        public static bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }

        public static void SetBit(ref byte b, int bitNumber, bool value)
        {
            b ^= (byte)((-(value ? 1 : 0) ^ b) & (1 << bitNumber));
        }
    }
}
