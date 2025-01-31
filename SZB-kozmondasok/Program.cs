using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZB_kozmondasok
{
    internal class Program
    {
        static void asd ()
        {
            List<string> lista = new List<string>();
            List<string[]> listab = new List<string[]>();

            StreamReader be = new StreamReader("szoveg1.txt");
            StreamReader bee = new StreamReader("szoveg2.txt");
            
            string sor;
            string[] reszek;

            sor = be.ReadLine();
            while (sor != null) 
            {
                reszek = sor.Split('.');
                lista.Add(reszek[0]);
                sor = be.ReadLine();
            }
            be.Close();




        }
        static void Main(string[] args)
        {
            /* 
            Közmondasok
            SZB - 2025.01.28.
            */
            string fejlec = "Közmondasok";
            Console.WriteLine(fejlec);
            for (int i = 0; i < fejlec.Length; i++) Console.Write('-');
            Console.WriteLine();

            




            Console.WriteLine("Nyomj meg bármit a kilépéshez!");
            Console.ReadKey();
        }
    }
}
