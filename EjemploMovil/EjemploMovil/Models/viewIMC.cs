using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploMovil.Models
{
   public class viewIMC
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC { get; set; }
        public string Error { get; set; }
        public string Recomendacion { get; set; }
    }
}
