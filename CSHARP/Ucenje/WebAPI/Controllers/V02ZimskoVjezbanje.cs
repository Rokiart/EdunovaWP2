using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int[] Zad1(int x)
         //ruta prima jedan parametar te vraca brojeve od 0 do 100!  
        {
            x = 100;
            int[] niz = new int[x];
            for(int i=0;i<x;i++)
            {

               niz[i]= i+1;
            }  return niz;
           
          

        }
        //*************************************************************************
        //Ruta ne prima niti jedan parametar i vraća zbroj prvih 100 brojeva
        [HttpGet]
        [Route("zad2")]
        public int Zad2()
        {
            int x = 0;

            for (int i = 0; i <= 100; i++)
            {
               x += i;
            }

            return x;
        }
        //**************************************************************************
        // Ruta ne prima niti jedan parametar i vraća niz s svim parnim brojevima od 1 do 57
        [HttpPost]
        [Route("zad3")]
        public int[] Zad3()
        {
            int[] x = new int[(58 / 2)];
            int unosx = 0;
            for (int i = 0; i <= 57; i += 2)
            {
                x [unosx] = i;
                unosx++;
            }
            return x;
        }
        //**************************************************************************
        //Ruta ne prima niti jedan parametar i vraća zbroj svih parnih brojeva od 2 do 18
        [HttpPost]
        [Route("zad4")]
        public int Zad4()

        {
            int x = 0;

            for (int i = 0; i <= 18; i += 2)
            {
                x += i;
            }
            return x;
        }
        //**************************************************************************
        //Ruta prima jedan parametar koji je cijli broj i vraća zbroj svih brojava od 1 do primljenog broja
        [HttpGet]
        [Route("zad5")]
        public int Zad5 (int zbroj)
        {
            int suma = 0;
            for (int i = 1; i <= zbroj; i++)
            {
                suma += i;
            }
            return suma;
        }
        //***************************************************************************
        // Ruta prima dva parametra koji su cijeli brojevi i vraća niz s svim parnim brojevima između primljenih brojeva
        [HttpGet]
        [Route("zad6")]
        public int Zad6(int pb,int db)
            // pb-prvi broj , db-drugi broj
        {
            int x = 0;

            for (int i = pb; i <= db; i += 2)
            {
                x += i;
            }
            return x;
        }
        //****************************************************************************
        //Ruta prima dva parametra koji su cijeli brojevi i vraća niz s svim neparnim brojevima između primljenih brojeva
        [HttpPost]
        [Route("zad7")]
        public int[] Zad7(int pb,int db)
        {
            int[] x = new int[(db / pb)];
            int unosx = 0;
            for (int i = pb; i <= db; i += 2)
            {
                x[unosx] = i+1;
                unosx++;
            }
            return x;
        }
        //****************************************************************************
        // Ruta prima dva parametra koji su cijeli brojevi i vraća zbroj svih brojeva između primljenih brojeva
        [HttpGet]
        [Route("zad8")]
        public int Zad8(int pb, int db)
        // pb-prvi broj , db-drugi broj
        {
            int x = 0;

            for (int i = pb; i <= db; i ++)
            {
                x += i;
            }
            return x;
        }
        //*****************************************************************************
        //Ruta prima dva parametra koji su cijeli brojevi i vraća zbroj svih brojeva između primljenih brojeva koji su cjelobrojno djeljivi s 3

        [HttpPost]
        [Route("zad9")]
        public int Zad9(int pb, int db)
        {
            int x = 0;

            for (int i = pb; i <= db; i++)
            {
               x= x += (i / 3)*3;


            }
            return x;
        }
        //*****************************************************************************
        //Ruta prima dva parametra koji su cijeli brojevi i vraća zbroj svih brojeva između primljenih brojeva koji su cjelobrojno djeljivi s 3 i 5
        [HttpPost]
        [Route("zad10")]
        public int Zad10(int pb, int db)
        {
            int x = 0;

            for (int i = pb; i <= db; i++)
            {
                int y = x += i;
                y
               


            }
            return x;
        }
    }


}
