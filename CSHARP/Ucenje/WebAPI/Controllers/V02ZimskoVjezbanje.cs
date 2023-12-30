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
         //bilo koji unos ispisuje brojeve od 0 do 100!  
        {
            x = 100;
            int[] niz = new int[x];
            for(int i=0;i<x;i++)
            {

               niz[i]= i+1;
            }  return niz;
           
          

        }
//*************************************************************************
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
        [HttpPost]
        [Route("zad3")]
        public int[] Zad3()
        {
            int[] x = new int[(57 % 2)];
            int unosx = 0;
            for (int i = 0; i <= 57; i += 2)
            {
                x[unosx] = i;
                unosx++;
            }
            return x;
        }
        //**************************************************************************
        //[HttpPost]
        //[Route("Zad4")]

        //public int[] Zad4()
        //{
        //    int[] NizParnihBrojeva = new int[(58 / 2)];
        //    int index = 0;
        //    for (int i = 0; i <= 57; i += 2)
        //    {
        //        NizParnihBrojeva[index] = i;
        //        index++;
        //    }
        //    return NizParnihBrojeva;
        //}

    }


}
