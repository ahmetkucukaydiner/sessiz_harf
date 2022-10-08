using System;
using System.Security.Cryptography;

namespace sessiz_harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.
            //Örnek: Input: Merhaba Umut Arya
            //Output: True False True
            Console.WriteLine("Bir metin giriniz: ");
            string str = Console.ReadLine();
            SesliMi(str);
        }

        static void SesliMi(string str)
        {
            string sesli = "aeuüiıöo";
            string[] strList = str.Split(' ');
            bool[] vowel = new bool[strList.Length];

            int row = 0;

            foreach (var item in strList)
            {
                int count = 0;
                foreach (var letter in item)
                {
                    if(sesli.Contains(letter))
                    {
                        count = 0;
                    }
                    else
                    {
                        count++;
                        if (count == 2)
                        {
                            vowel[row] = true;
                            break;
                        }
                            
                    }
                }
                row++;
            }
            foreach (var item in vowel)
            {
                Console.Write(item + " ");
            }
            
        }
        
    }
}
