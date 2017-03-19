using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionForm
{
    static class Constants
    {
        //Key length mode
        public const int _128_BITS_MODE = 0;
        public const int _192_BITS_MODE = 1;
        public const int _256_BITS_MODE = 2;

        //Key length (in word)
        public const int _128_BITS_WORD = 4;
        public const int _192_BITS_WORD = 6;
        public const int _256_BITS_WORD = 8;

        //Expanded key length (in word)
        public const int _128_BITS_EX_WORD = 44;
        public const int _192_BITS_EX_WORD = 52;
        public const int _256_BITS_EX_WORD = 60;

        //Number of round of each mode
        public const int _128_BITS_NUM_ROUND = 10;
        public const int _192_BITS_NUM_ROUND = 12;
        public const int _256_BITS_NUM_ROUND = 14;

        //Size of one word
        public const int WORD_SIZE = 4;    
    
        //Size of a block (in byte)
        public const int BLOCK_SIZE = 16;

    }
    class AES
    {
        private int wordOfKey;
        private int wordOfExKey;
        private int numOfRound;
        private byte[,] sBox;
        private byte[,] invSBox;
        private byte[,] rCon;
        private int keyLengthMode;
        private byte[,] expandedKey;
        //private byte[] key = new byte[24] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
        //private byte[] plaintext = new byte[16] { 0xdd, 0xa9, 0x7c, 0xa4, 0x86, 0x4c, 0xdf, 0xe0, 0x6e, 0xaf, 0x70, 0xa0, 0xec, 0x0d, 0x71, 0x91 };
        //private byte[] ciphertext;
        private byte[,] state;
        public AES (int keyLengthMode, byte[] key)
        {
            state = new byte[Constants.BLOCK_SIZE / Constants.WORD_SIZE, Constants.WORD_SIZE];
            this.keyLengthMode = keyLengthMode;
            initSBox();
            initInvSbox();
            initRCon();
            initSomeNum();
            expandKey(key);
        }

        //Encrypt a file
        public void encyptFile()
        {

        }

        //Decrypt a file
        public void decyptFile()
        {

        }

        //Encrypt one 128-bit block of plaintext
        public byte[] encyptOneBLock(byte[] plainText)
        {
            byte[] cipherText = new byte[Constants.BLOCK_SIZE];

            for (int i = 0; i < Constants.BLOCK_SIZE; ++i)
            {
                state[i / 4, i % 4] = plainText[i];
            }
            addRoundKey(0);
            for (int i = 1; i < numOfRound; i++)
            {
                substituteBytes();
                shiftRows();
                mixColumns();
                addRoundKey(i);
            }
            substituteBytes();
            shiftRows();
            addRoundKey(numOfRound);

            for (int i = 0; i < Constants.BLOCK_SIZE; i++)
            {
                cipherText[i] = state[i / 4, i % 4];
            }
            return cipherText;
        }

        //Decrypt one 128-bit block of ciphertext
        public byte[] decyptOneBLock(byte[] cipherText)
        {
            byte[] plainText = new byte[Constants.BLOCK_SIZE];

            for (int i = 0; i < Constants.BLOCK_SIZE; ++i)
            {
                state[i / 4, i % 4] = cipherText[i];
            }

            addRoundKey(numOfRound);
            for (int i = numOfRound - 1; i > 0; i--)
            {
                invShiftRows();
                invSubstituteBytes();
                addRoundKey(i);
                invMixColumns();
            }
            invShiftRows();
            invSubstituteBytes();      
            addRoundKey(0);

            for (int i = 0; i < Constants.BLOCK_SIZE; i++)
            {
                plainText[i] = state[i / 4, i % 4];
            }
            return plainText;
        }

        //Substitute Bytes Transformation
        private void substituteBytes()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    state[i, j] = sBox[state[i, j] >> 4, state[i, j] & 0x0f];
        }

        //Invert Substitute Bytes Transformation
        private void invSubstituteBytes()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    state[i, j] = invSBox[state[i, j] >> 4, state[i, j] & 0x0f];
        }

        //Shift Rows Transformation
        private void shiftRows()
        {
            byte temp;
            for (int j = 1; j < 4; j++)
            {
                for (int k = 0; k < j; k++)
                {
                    temp = state[0, j];
                    for (int i = 0; i < 3; i++)
                    {
                        state[i, j] = state[i + 1, j];
                    }
                    state[3, j] = temp;
                }
            }
        }

        //Invert Shift Rows Transformation
        private void invShiftRows()
        {
            byte temp;
            for (int j = 1; j < 4; j++)
            {
                for (int k = 0; k < j; k++)
                {
                    temp = state[3, j];
                    for (int i = 3; i > 0; i--)
                    {
                        state[i, j] = state[i - 1, j];
                    }
                    state[0, j] = temp;
                }
            }
        }

        //Mix Columns Transformation
        private void mixColumns()
        {
            byte[,] temp = new byte[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[i, j] = state[i, j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                state[i, 0] = XOR(XOR(gfMulBy02(temp[i, 0]), gfMulBy03(temp[i, 1])), XOR(gfMulBy01(temp[i, 2]), gfMulBy01(temp[i, 3])));
                state[i, 1] = XOR(XOR(gfMulBy01(temp[i, 0]), gfMulBy02(temp[i, 1])), XOR(gfMulBy03(temp[i, 2]), gfMulBy01(temp[i, 3])));
                state[i, 2] = XOR(XOR(gfMulBy01(temp[i, 0]), gfMulBy01(temp[i, 1])), XOR(gfMulBy02(temp[i, 2]), gfMulBy03(temp[i, 3])));
                state[i, 3] = XOR(XOR(gfMulBy03(temp[i, 0]), gfMulBy01(temp[i, 1])), XOR(gfMulBy01(temp[i, 2]), gfMulBy02(temp[i, 3])));
            }
        }

        //Invert Mix Columns Transformation
        private void invMixColumns()
        {
            byte[,] temp = new byte[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[i, j] = state[i, j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                state[i, 0] = XOR(XOR(gfMulBy0e(temp[i, 0]), gfMulBy0b(temp[i, 1])), XOR(gfMulBy0d(temp[i, 2]), gfMulBy09(temp[i, 3])));
                state[i, 1] = XOR(XOR(gfMulBy09(temp[i, 0]), gfMulBy0e(temp[i, 1])), XOR(gfMulBy0b(temp[i, 2]), gfMulBy0d(temp[i, 3])));
                state[i, 2] = XOR(XOR(gfMulBy0d(temp[i, 0]), gfMulBy09(temp[i, 1])), XOR(gfMulBy0e(temp[i, 2]), gfMulBy0b(temp[i, 3])));
                state[i, 3] = XOR(XOR(gfMulBy0b(temp[i, 0]), gfMulBy0d(temp[i, 1])), XOR(gfMulBy09(temp[i, 2]), gfMulBy0e(temp[i, 3])));
            }
        }

        //Add Round Key Transformation
        private void addRoundKey(int roundNum)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i, j] = XOR(state[i, j], expandedKey[roundNum*4 + i, j]);
                }
            }
        }

        //Key Expansion
        private void expandKey(byte[] key)
        {
            int i;
            byte[] temp = new byte[Constants.WORD_SIZE];
            expandedKey = new byte[wordOfExKey, Constants.WORD_SIZE];

            for (i = 0; i < wordOfKey; i++)
            {
                for (int j = 0; j < Constants.WORD_SIZE; j++)
                    expandedKey[i, j] = key[Constants.WORD_SIZE*i + j];
            }
            for (i = wordOfKey; i < wordOfExKey; i++)
            {
                for (int j = 0; j < Constants.WORD_SIZE; j++)
                    temp[j] = expandedKey[i - 1, j];
                if (i % wordOfKey == 0)
                {
                    temp = subWord(rotWord(temp));
                    for (int j = 0; j < Constants.WORD_SIZE; j++)
                        temp[j] = XOR(temp[j], rCon[i / wordOfKey, j]);
                }
                else if (i % wordOfKey == 4 && wordOfKey > 6)
                {
                    temp = subWord(temp);
                }
                for (int j = 0; j < Constants.WORD_SIZE; j++)
                    expandedKey[i, j] = XOR(expandedKey[i - wordOfKey, j], temp[j]);
            }
        }
        private byte XOR(byte op1, byte op2)
        {
            String strOp1 = Convert.ToString(op1, 2).PadLeft(8, '0');
            String strOp2 = Convert.ToString(op2, 2).PadLeft(8, '0');
            String strOut = "";
            for (int i = 0; i < strOp1.Length; i++)
            {
                if (strOp1[i].Equals(strOp2[i]))
                    strOut += '0';
                else
                    strOut += '1';
            }
            byte byteOut = Convert.ToByte(strOut, 2);
            return byteOut;
        }
        private byte[] subWord(byte[] wordIn)
        {
            byte[] wordOut = new byte[4];
            wordOut[0] = sBox[wordIn[0] >> 4, wordIn[0] & 0x0f];
            wordOut[1] = sBox[wordIn[1] >> 4, wordIn[1] & 0x0f];
            wordOut[2] = sBox[wordIn[2] >> 4, wordIn[2] & 0x0f];
            wordOut[3] = sBox[wordIn[3] >> 4, wordIn[3] & 0x0f];
            return wordOut;
        }
        private byte[] rotWord(byte[] wordIn)
        {
            byte[] wordOut = new byte[4];
            wordOut[0] = wordIn[1];
            wordOut[1] = wordIn[2];
            wordOut[2] = wordIn[3];
            wordOut[3] = wordIn[0];
            return wordOut;
        }
        private void initSBox()
        {
            sBox = new byte[16, 16] {
          /* 0     1     2     3     4     5     6     7     8     9     a     b     c     d     e     f */
    /*0*/  {0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76},
    /*1*/  {0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0},
    /*2*/  {0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15},
    /*3*/  {0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75},
    /*4*/  {0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84},
    /*5*/  {0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf},
    /*6*/  {0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8},
    /*7*/  {0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2},
    /*8*/  {0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73},
    /*9*/  {0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb},
    /*a*/  {0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79},
    /*b*/  {0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08},
    /*c*/  {0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a},
    /*d*/  {0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e},
    /*e*/  {0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf},
    /*f*/  {0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16} };  
        }
        private void initInvSbox()
        {
            invSBox = new byte[16,16] {
          /* 0     1     2     3     4     5     6     7     8     9     a     b     c     d     e     f */
    /*0*/  {0x52, 0x09, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb},
    /*1*/  {0x7c, 0xe3, 0x39, 0x82, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb},
    /*2*/  {0x54, 0x7b, 0x94, 0x32, 0xa6, 0xc2, 0x23, 0x3d, 0xee, 0x4c, 0x95, 0x0b, 0x42, 0xfa, 0xc3, 0x4e},
    /*3*/  {0x08, 0x2e, 0xa1, 0x66, 0x28, 0xd9, 0x24, 0xb2, 0x76, 0x5b, 0xa2, 0x49, 0x6d, 0x8b, 0xd1, 0x25},
    /*4*/  {0x72, 0xf8, 0xf6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xd4, 0xa4, 0x5c, 0xcc, 0x5d, 0x65, 0xb6, 0x92},
    /*5*/  {0x6c, 0x70, 0x48, 0x50, 0xfd, 0xed, 0xb9, 0xda, 0x5e, 0x15, 0x46, 0x57, 0xa7, 0x8d, 0x9d, 0x84},
    /*6*/  {0x90, 0xd8, 0xab, 0x00, 0x8c, 0xbc, 0xd3, 0x0a, 0xf7, 0xe4, 0x58, 0x05, 0xb8, 0xb3, 0x45, 0x06},
    /*7*/  {0xd0, 0x2c, 0x1e, 0x8f, 0xca, 0x3f, 0x0f, 0x02, 0xc1, 0xaf, 0xbd, 0x03, 0x01, 0x13, 0x8a, 0x6b},
    /*8*/  {0x3a, 0x91, 0x11, 0x41, 0x4f, 0x67, 0xdc, 0xea, 0x97, 0xf2, 0xcf, 0xce, 0xf0, 0xb4, 0xe6, 0x73},
    /*9*/  {0x96, 0xac, 0x74, 0x22, 0xe7, 0xad, 0x35, 0x85, 0xe2, 0xf9, 0x37, 0xe8, 0x1c, 0x75, 0xdf, 0x6e},
    /*a*/  {0x47, 0xf1, 0x1a, 0x71, 0x1d, 0x29, 0xc5, 0x89, 0x6f, 0xb7, 0x62, 0x0e, 0xaa, 0x18, 0xbe, 0x1b},
    /*b*/  {0xfc, 0x56, 0x3e, 0x4b, 0xc6, 0xd2, 0x79, 0x20, 0x9a, 0xdb, 0xc0, 0xfe, 0x78, 0xcd, 0x5a, 0xf4},
    /*c*/  {0x1f, 0xdd, 0xa8, 0x33, 0x88, 0x07, 0xc7, 0x31, 0xb1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xec, 0x5f},
    /*d*/  {0x60, 0x51, 0x7f, 0xa9, 0x19, 0xb5, 0x4a, 0x0d, 0x2d, 0xe5, 0x7a, 0x9f, 0x93, 0xc9, 0x9c, 0xef},
    /*e*/  {0xa0, 0xe0, 0x3b, 0x4d, 0xae, 0x2a, 0xf5, 0xb0, 0xc8, 0xeb, 0xbb, 0x3c, 0x83, 0x53, 0x99, 0x61},
    /*f*/  {0x17, 0x2b, 0x04, 0x7e, 0xba, 0x77, 0xd6, 0x26, 0xe1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0c, 0x7d} };

        }
        private void initRCon()
        {
            this.rCon = new byte[11, 4] { {0x00, 0x00, 0x00, 0x00}, 
                                   {0x01, 0x00, 0x00, 0x00},
                                   {0x02, 0x00, 0x00, 0x00},
                                   {0x04, 0x00, 0x00, 0x00},
                                   {0x08, 0x00, 0x00, 0x00},
                                   {0x10, 0x00, 0x00, 0x00},
                                   {0x20, 0x00, 0x00, 0x00},
                                   {0x40, 0x00, 0x00, 0x00},
                                   {0x80, 0x00, 0x00, 0x00},
                                   {0x1b, 0x00, 0x00, 0x00},
                                   {0x36, 0x00, 0x00, 0x00} };
        }
        private void initSomeNum()
        {
            if (keyLengthMode == Constants._128_BITS_MODE)
            {
                wordOfExKey = Constants._128_BITS_EX_WORD;
                wordOfKey = Constants._128_BITS_WORD;
                numOfRound = Constants._128_BITS_NUM_ROUND;
            }
            else if (keyLengthMode == Constants._192_BITS_MODE)
            {
                wordOfExKey = Constants._192_BITS_EX_WORD;
                wordOfKey = Constants._192_BITS_WORD;
                numOfRound = Constants._192_BITS_NUM_ROUND;
            }
            else
            {
                wordOfExKey = Constants._256_BITS_EX_WORD;
                wordOfKey = Constants._256_BITS_WORD;
                numOfRound = Constants._256_BITS_NUM_ROUND;
            }
        }
        private byte gfMulBy01(byte b)
        {
            return b;
        }
        private byte gfMulBy02(byte b)
        {
            if (b < 0x80)
                return (byte)(int)(b << 1);
            else
                return XOR((byte)(int)(b << 1), 0x1b);
        }
        private byte gfMulBy03(byte b)
        {
            return XOR(gfMulBy02(b), b);
        }
        private byte gfMulBy09(byte b)
        {
            return XOR(gfMulBy02(gfMulBy02(gfMulBy02(b))), b);
        }
        private byte gfMulBy0b(byte b)
        {
            return XOR(gfMulBy02(gfMulBy02(gfMulBy02(b))), XOR(gfMulBy02(b), b));
        }
        private byte gfMulBy0d(byte b)
        {
            return XOR(gfMulBy02(gfMulBy02(gfMulBy02(b))), XOR(gfMulBy02(gfMulBy02(b)),b));
        }
        private byte gfMulBy0e(byte b)
        {
            return XOR(gfMulBy02(gfMulBy02(gfMulBy02(b))), XOR(gfMulBy02(gfMulBy02(b)), gfMulBy02(b)));
        }
    }
}
