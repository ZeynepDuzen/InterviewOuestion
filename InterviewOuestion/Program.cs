using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewOuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir bakteri türü her saatin sonunda kendini 2'ye bolerek cogalmaktadir,
            //yeni bakteriler de aynı sekilde cogalmaktadir,
            //24 saatin sonunda bu ortamda kac bakteri olur?

            //baslangıcta bakteri sayisi 1
            //1.saatin sonunda 2,        -->   2¹
            //2.saatin sonunda 4,        -->   2²
            //3.saatin sonunda 8...      -->   2³

            int bakteri = 1;
            int i;

            for (i = 1; i <= 24; i++)
            {
                bakteri = bakteri * 2;
            }

            Console.WriteLine(" 24 saatin sonunda " + bakteri + " bakteri olusur ");

            Console.Read();
        }
    }
}
