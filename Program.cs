using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dop_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //карты)))))))))

            //k b ch p. 6 7 8 9 10 v d k t 
            string k6 = "крест_6", k7 = "крест_7", k8 = "крест_8", k9 = "крест_9", k10 = "крест_10", kv = "крестовый валет", kd = "крестовая дама", kk = "крестовый король", kt = "крестовый туз";
            string b6 = "буба_6", b7 = "буба_7", b8 = "буба_8", b9 = "буба_9", b10 = "буба_10", bv = "бубновый валет", bd = "бубновая дама", bk = "бубновый король", bt = "бубновый туз";
            string ch6 = "черви_6", ch7 = "черви_7", ch8 = "черви_8", ch9 = "черви_9", ch10 = "черви_10", chv = "червовый валет", chd = "червовая дама", chk = "червовый король", cht = "червовый туз";
            string p6 = "пика_6", p7 = "пика_7", p8 = "пика_8", p9 = "пика_9", p10 = "пика_10", pv = "пиковый валет", pd = "пиковая дама", pk = "пиковый король", pt = "пиковый король";

            int ik6 = 6, ik7 = 7, ik8 = 8, ik9 = 9, ik10 = 10, ikv = 11, ikd = 12, ikp = 13, ikt = 14;
            int ib6 = 6, ib7 = 7, ib8 = 8, ib9 = 9, ib10 = 10, ibv = 11, ibd = 12, ibp = 13, ibt = 14;
            int ich6 = 6, ich7 = 7, ich8 = 8, ich9 = 9, ich10 = 10, ichv = 11, ichd = 12, ichp = 13, icht = 14;
            int ip6 = 6, ip7 = 7, ip8 = 8, ip9 = 9, ip10 = 10, ipv = 11, ipd = 12, ipp = 13, ipt = 14;

            int f = 6;
            int[] kol1 = new int[f];
            Random random = new Random();

            for (int i = 0; i < f; i++)
            {
                kol1[i] = random.Next(6, 14);
                //Console.WriteLine(kol1[i]);
            }

            string[] skol1 = new string[f];
            for (int i = 0;i < f; i++)
            {
                skol1[i] = 
            }









            //switch (f)
            //{
            //    case 1:
            //        Console.WriteLine("");
            //        break;
            //}



            





















            Console.ReadKey();
        }
    }
}
