using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DES;

namespace NDes
{
    public class NDes
    {
        public static string BytesToBit(byte[] byte1)
        {
            string strResult = string.Empty;
            string strTemp;
            for (int i = 0; i < byte1.Length; i++)
            {
                strTemp = System.Convert.ToString(byte1[i], 2);
                strTemp = strTemp.Insert(0, new string('0', 8 - strTemp.Length));
                strResult += strTemp;
            }
            return strResult;
        }
        /*public static string BitToBytes(string str1) { 
            byte[] byte1 = Encoding.UTF8.GetBytes(str1);
            //string str2 = Encoding.UTF8.GetString(byte1);
            byte[] bstr2 = Convert.FromBase64String(str1);
            string str2 = Encoding.UTF8.GetString(bstr2);
            return str2;
        }*/
        public static string BitToBytes(string s)
        {
            System.Text.RegularExpressions.CaptureCollection cs =
                System.Text.RegularExpressions.Regex.Match(s, @"([01]{8})+").Groups[1].Captures;
            byte[] data = new byte[cs.Count];
            for (int i = 0; i < cs.Count; i++)
            {
                data[i] = Convert.ToByte(cs[i].Value, 2);
            }
            //return Encoding.Unicode.GetString(data, 0, data.Length);
            return Encoding.UTF8.GetString(data);
        }

        public static int[] Getdivisor(string number) 
        {
            int i, m;
            int j = 0;
            int k = 0;
            m = Convert.ToInt16(number);
            for (i = 1; i <= m; i++)
            {
                if (m % i == 0)
                {
                    k++;
                }
            }
            int[] divisor = new int[k];
            for (i = 1; i <= m; i++)
            {
                if (m % i == 0)
                {
                    divisor[j] = i;
                    j++;
                }
            }
            return divisor;
        }
        public static string leftmovekey(string k1, int n) 
        {
            string str1 = string.Empty;
            string str2 = string.Empty;
            string stringresult = string.Empty;
            byte[] byte1 = Encoding.UTF8.GetBytes(k1);
            string k = NDes.BytesToBit(byte1);
                str1 = k.Substring(0, n);
                str2 = k.Substring(n, k.Length - n);
            stringresult = str2 + str1;
            string stringresult2 = NDes.BitToBytes(stringresult);
            return stringresult2;
        }
        public static string rightmovekey(string k1, int n) {
            string str1 = string.Empty;
            string str2 = string.Empty;
            string stringresult = string.Empty;
            byte[] byte1 = Encoding.UTF8.GetBytes(k1);
            string k = NDes.BytesToBit(byte1);
            str1 = k.Substring(0, k.Length - n);
            str2 = k.Substring(k.Length - n, n);
            stringresult = str2 + str1;
            string stringresult2 = NDes.BitToBytes(stringresult);
            return stringresult2;
        }
        public static string NDESEncrypt(string encryptString, string encKey, string number) 
        {
            int[] divisors = NDes.Getdivisor(number);
            //int[] divisors = new int[] { 1, 3 };
            int m = int.Parse(number);
            int i, j;
            string cipherresult=string.Empty;
            string t = string.Empty;
            string subkey = string.Empty;
            for (i = 1; i <= m; i++) 
            {
                if (i <= divisors.Length)
                {
                    if (i % 2 == 0)
                    {
                        subkey = rightmovekey(encKey,divisors[i-1]);
                        t=encryptString;
                        cipherresult = DES.DEScipher.Encrypt(t, subkey);
                        encryptString = cipherresult;
                    }
                    else { 
                        subkey = leftmovekey(encKey,divisors[i-1]);
                        t=encryptString;
                        cipherresult = DES.DEScipher.Encrypt(t, subkey);
                        encryptString = cipherresult;
                    }
                }
                else {
                    j = i;
                    do
                    {
                        j = j - divisors.Length;
                    } while (j > divisors.Length);
                    
                    if (i % 2 == 0)
                    {
                        subkey = NDes.rightmovekey(encKey, divisors[j-1]);
                        t = encryptString;
                        cipherresult = DES.DEScipher.Encrypt(t, subkey);
                        encryptString = cipherresult;
                    }
                    else{
                        subkey = NDes.leftmovekey(encKey, divisors[j-1]);
                        t = encryptString;
                        cipherresult = DES.DEScipher.Encrypt(t, subkey);
                        encryptString = cipherresult;
                    }
                }
            }
            return encryptString;
        }
        public static string NDESDecrypt(string decryptString, string encKey, string number) {
            int[] divisors = NDes.Getdivisor(number);
            int m = int.Parse(number);
            int i, j;
            string decipherresult = string.Empty;
            string t = string.Empty;
            string subkey = string.Empty;
            for (i = m; i > 0; i--)
            {
                if (i <= divisors.Length)
                {
                    if (i % 2 == 0)
                    {
                        subkey = rightmovekey(encKey, divisors[i - 1]);
                        t = decryptString;
                        decipherresult = DES.DEScipher.Decrypt(t, subkey);
                        decryptString = decipherresult;
                    }
                    else
                    {
                        subkey = leftmovekey(encKey, divisors[i - 1]);
                        t = decryptString;
                        decipherresult = DES.DEScipher.Decrypt(t, subkey);
                        decryptString = decipherresult;
                    }
                }
                else
                {
                    j = i;
                    do
                    {
                        j = j - divisors.Length;
                    } while (j > divisors.Length);
                    if (i % 2 == 0)
                    {
                        subkey = NDes.rightmovekey(encKey, divisors[j-1]);
                        t = decryptString;
                        decipherresult = DES.DEScipher.Decrypt(t, subkey);
                        decryptString = decipherresult;
                    }
                    else
                    {
                        subkey = NDes.leftmovekey(encKey, divisors[j-1]);
                        t = decryptString;
                        decipherresult = DES.DEScipher.Decrypt(t, subkey);
                        decryptString = decipherresult;
                    }
                }
            }
            return decryptString;
        }
    }
}
