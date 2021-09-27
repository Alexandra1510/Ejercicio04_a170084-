using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculadora_de_area
{
    /// <summary>
    /// Descripción breve de WebServicearea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicearea : System.Web.Services.WebService
    {
        calculos areas = new calculos();
       
        
        [WebMethod (Description ="Area del cuadrado")]
        //LLame al cuadrado de clase calculos
        public int Cuadrado(int Base)
        {
            areas.Base = Base;

            return areas.Cuadrado();
        }
        [WebMethod(Description = "Area del Triangulo")]
        public int Triangulo(int Base, int altura)
        {
            areas.Base = Base;
            areas.altura = altura;
            return areas.Triangulo();
        }
        [WebMethod(Description = "Area del Circulo")]

        public double Circulo(double radio)
        {
            areas.radio = radio;
            return areas.Circulo();
        }








    }
}
