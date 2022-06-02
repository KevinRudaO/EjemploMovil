using EjemploMovil.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploMovil.Clases
{
    public class clsIMC
    {
        public viewIMC vIMC { get; set; }

        public void CalcularIMC()
        {
            vIMC.IMC = vIMC.Peso / Math.Pow(vIMC.Altura, 2);

            if (vIMC.IMC<18.5)
            {
                vIMC.Recomendacion = vIMC.Nombre + " Por debajo del peso normal";
                return;
            }
            else if (vIMC.IMC <= 24.9)
            {
                vIMC.Recomendacion = vIMC.Nombre + " Esta en el peso normal";
                return;
            }
            else if (vIMC.IMC < 30)
            {
                vIMC.Recomendacion = vIMC.Nombre + " Por encima del peso normal";
                return;
            }
            else
            {
                vIMC.Recomendacion = vIMC.Nombre + " Tiene problemas de peso";
                return;
            }

        }
    }
}
