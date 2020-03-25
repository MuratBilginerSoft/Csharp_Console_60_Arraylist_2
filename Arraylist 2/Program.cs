using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 adet sayının tek ve çift olanlarını ayrı ayrı dizilere atan, dizilerin içinde kaç adet sayı oldugunu ve ortalamalarını gösteren Console örneği.

            #region Parameters


            int toplamc = 0;
            int toplamt = 0;

            int ortc,ortt;


            #endregion

            #region Definitions

            ArrayList Sayılar = new ArrayList();
            ArrayList TS = new ArrayList();
            ArrayList CS = new ArrayList();

            Random r = new Random();


            #endregion

            for (int i = 0; i < 10; i++)
            {
                Sayılar.Add(r.Next(100));
            }

            foreach (var item in Sayılar)
            {
                if (Convert.ToInt32(item)%2==0)
                {
                    CS.Add(item);
                }

                else
                {
                    TS.Add(item);
                }
            }

            Console.WriteLine(CS.Count);
            Console.WriteLine(TS.Count);

            foreach (var item in TS)
            {
                toplamt += Convert.ToInt32(item);
            }

            ortt = toplamt / TS.Count;

            foreach (var item in CS)
            {
                toplamc += Convert.ToInt32(item);
            }

            ortc = toplamc / CS.Count;

            foreach (var item in CS)
            {
                Console.Write(item+"-");
            }

            Console.WriteLine();

            foreach (var item in TS)
            {
                Console.Write(item + "-");
            }

            Console.WriteLine();
            Console.WriteLine(ortc);
            Console.WriteLine(ortt);

            Console.ReadKey();

        }
    }
}
