using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    class Bit
    {

        // Get Bit 
        // This method shifts 1 over by i bits, creating a value that looks like 00010000. By
        // performing an AND with num, we clear all bits other than the bit at bit i. Finally, we
        // compare that to 0. If that new value is not zero, then bit i must have a 1. Otherwise, bit
        //i is a O.

        bool GetBit(int num, int i)
        {
            return ((num & (1 << i)) != 0);
        }


        // Set Bit
        // Set Bit shifts 1 over by i bits, creating a value like 00010000. By performing an OR with
        //  num, only the value at bit i will change. All other bits of the mask are zero and will not
        //  affect num.

        int setBit(int num, int i)
        {
            return num | (1 << i);
        }


        // Clear Bit
        //This method operates in almost the reverse of setBit. First, we create a number like
        //11101111 by creating the reverse of it (00010000) and negating it. Then, we perform
        //an AND with num. This will clear the ith bit and leave the remainder unchanged.

        // & 0

        int clearBit(int num, int i)
        {
            int mask = ~(1 << i);
            return num & mask;
        }

        // To clear all bits from the most significant bit through i (inclusive), we do:
        int clearBitsMSBthroughi(int num, int i)
        {
            int mask = (1 << i) - 1;
            return num & mask;
        }

        //   To clear all bits from i through 0 (inclusive), we do:
        int clearBitsIthrough0(int num, int i)
        {
            int mask = ~((1 << (i + 1)) - 1);
            return num & mask;
        }


        // Update Bit
        // This method merges the approaches of setBit and clearBit. First, we clear the bit at
        // position i by using a mask that looks like 11101111. 

        // Then, we shift the intended value v, left by i bits. This will create a number with bit i equal to v and all other bits equal
        // to 0. 

        // Finally, we OR these two numbers, updating the ith bit if v is 1 and leaving it as 0
        // otherwise.

        int updateBit(int num, int i, int v)
        {
            int mask = ~(1 << i);
            return (num & mask) | (v << i);
        }

        #region 5.2
        //5.2 Given a real number between 0 and 7 (e.g., 0.72) that is passed in as a double, print
        //the binary representation. If the number cannot be represented accurately in binary
        //with at most 32 characters, print "ERROR."

        public string printBinary(double num)
        {
            if (num >= 1 || num <= 0)
            {
                return "Error";
            }

            StringBuilder binary = new StringBuilder();
            binary.Append(".");
            while (num > 0)
            {
                /* Setting a limit on length: 32 characters */
                if (binary.Length >= 32)
                {
                    return "Error";
                }

                double r = num * 2;
                if (r >= 1)
                {
                    binary.Append(1);
                    num = r - 1;
                }
                else
                {
                    binary.Append(0);
                    num = r;
                }
            }
            return binary.ToString();
        }

        #endregion

        #region 5.8

        //5.8 A monochrome screen is stored as a single array of bytes, allowing eight consecutive
        //pixels to be stored in one byte. The screen has width w, where w is divisible
        //by 8 (that is, no byte will be split across rows). The height of the screen, of course,
        //can be derived from the length of the array and the width. Implement a function
        //drawHorizontalLine(byte[] screen, int width, intxl, intx2, inty) which draws a horizontal
        //line from (x 1, y) to (x2, y).

      


        void DrawLine(byte[] screen, int width, int xl, int x2, int y)
        {
            int start_offset = xl % 8;
            int first_full_byte = xl / 8;
            if (start_offset != 0)
            {
                first_full_byte++;
            }

            int end_offset = x2 % 8;
            int last_full_byte = x2 / 8;
            if (end_offset != 7)
            {
                last_full_byte--;
            }

            // Set full bytes
            for (int b = first_full_byte; b <= last_full_byte; b++)
            {
                screen[(width / 8) * y + b] = (byte)0xFF;
            }

            // Create masks for start and end of line
            byte start_mask = (byte)(0xFF >> start_offset);
            byte endjnask = (byte)~(0xFF >> (end_offset + 1));

            // Set start and end of line
            if ((xl / 8) == (x2 / 8))
            { // xl and x2 are in the same byte
                byte mask = (byte)(start_mask & endjnask);
                screen[(width / 8) * y + (xl / 8)] |= mask;
            }
            else
            {
                if (start_offset != 0)
                {
                    int byte_number = (width / 8) * y + first_full_byte - 1;
                    screen[byte_number] |= start_mask;
                }
                if (end_offset != 7)
                {
                    int byte_number = (width / 8) * y + last_full_byte + 1;
                    screen[byte_number] |= endjnask;
                }
            }
        }

        #endregion



    }

}


