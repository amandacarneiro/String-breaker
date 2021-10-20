using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Text for test. This is a test.";
            int m = 5;

            List<string> retorno = ListOfString(s, m);
        }

        public static List<string> ListOfString(String incaming, int maximum)
        {
            int v = incaming.Length;
            List<string> listDone = new List<string>();
            char[] breakeList;
            char[] newItem = new char[maximum + 1];
            int countChar = 0;
            if (v <= maximum)
            {
                listDone.Add(incaming);
            }
            else if (v > maximum)
            {
                breakeList = incaming.ToArray<char>();

                for (int i = 0; i < incaming.Length; i++)
                {
                    if (i >= countChar)
                    {
                        countChar++;
                        newItem[countChar] = breakeList[i];
                    }
                    if (countChar >= maximum)
                    {

                        listDone.Add(new string(newItem));
                        countChar = 0;
                        newItem = new char[maximum + 1];
                    }
                }

            }
            return listDone;
        }
    }
}
