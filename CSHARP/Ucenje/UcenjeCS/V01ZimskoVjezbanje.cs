

using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()

        //Razmjena novca
        //{
        //    int n, k;
        //    Console.WriteLine("Unesi iznos");
        //    n = int.Parse(Console.ReadLine());

        //    k = n / 10;n = n % 10;
        //    Console.WriteLine("{0} po 10 eura",k);
        //    k = n / 5;n = n % 5;
        //    Console.WriteLine("{0} po 5 eur",k);
        //    Console.WriteLine( "{0} po 1 eur",n);
        //}
        //*****************************************************************************
        //{
        //   //for(int i=1; i<101; i++)
        //   // {
        //   //     Console.Write(" "+i);
        //   // }
        //*****************************************************************************
        //}
        //{
        //    for (int i = 101; i > 0; i--) 
        //    {
        //        Console.Write(" "+i);
        //    }
        //}
        //*****************************************************************************
        //{
        //    for (int i = 0; i < 100; i=i+7)

        //    {
        //        Console.Write(" " + i);
        //    }
        //}
        {
            //************************************************************************
            //Random broj = new Random();
            //int i = broj.Next(0, 200);
            //if (i < 100) 
            //{
            //    Console.WriteLine(i+" Broj je nanji od 100");
            //}

            //if (i > 100) 
            //{
            //    Console.WriteLine(i+" Broj je veci od 100");
            //}

            //************************************************************************


            // int b;

            // b = 1;
            // var i = new Random();
            //for (int ctr = 0; ctr <= 200; ctr++) ;
            // b = b++;
            // Console.WriteLine("{0,15:N0}", i.Next(200), " Manji je od 100 " + " , " + "Broj pokušaja = " + b);


            //while (i <= 100)
            //{
            //    Console.WriteLine("{0,8:N0}",i.Next() , " Manji je od 100 " + " , " + "Broj pokušaja = " + b);
            //    b = b++;

            //    {


            //        break;


            //    }

            //}

            //while (i >= 100)
            //{
            //    Console.Write(i + " Veci je od 100  " + " ,  Broj pokušaja = " + b);
            //    {
            //        break;
            //    }

            //}

            //********************************************************************
            //var rand = new Random();
            //Console.WriteLine("Five random integers between 0 and 100:");
            //for (int ctr = 0; ctr <= 4; ctr++)
            //    Console.Write("{0,8:N0}", rand.Next(101));
            //Console.WriteLine();
            //*********************************************************************



        
            Console.WriteLine("Unesi broj od 1 do 100 ?");
            int i = 0;
            int b = 0;
            i += int.Parse(Console.ReadLine());
            b = b+1;

            Console.WriteLine(i);
            Console.WriteLine("broj pokušaja = "+ b);
            for (i=0)


        }
    }
}
