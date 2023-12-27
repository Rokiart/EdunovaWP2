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

        [HttpGet]
        [Route("zad2")]





    }


}
