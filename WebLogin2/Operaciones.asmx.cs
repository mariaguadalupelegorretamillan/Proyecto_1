using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebLogin1
{
  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    public class Operaciones : System.Web.Services.WebService
    {

        public Operaciones()
        {
         
        }
        [WebMethod]
        public int Sumar(int x, int y)
        {
            return x + y;
        }
        [WebMethod]
        public int Restar(int x, int y)
        {
            return x - y;
        }
        [WebMethod]
        public int Multiplicar(int x, int y)
        {
            return x * y;
        }
        [WebMethod]
        public int Dividir(int x, int y)
        {
            return x / y;
        }

    }
}
