using EjemploMovil.Clases;
using EjemploMovil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;                       

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjemploMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmIMC : ContentPage
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string Nombre;
            double Peso, Altura;

            //obtener los datos del xaml
            Nombre = txtNombre.Text;
            Peso = Convert.ToDouble(txtPeso.Text);
            Altura = Convert.ToDouble(txtAltura.Text);

            //Asignar los valores a las variables del objeto
            viewIMC vIMC = new viewIMC();

            vIMC.Nombre = Nombre;
            vIMC.Peso = Peso;
            vIMC.Altura = Altura;

            //Enviar objeto a la clase e invocar metodo para calcular
            clsIMC oIMC = new clsIMC();
            oIMC.vIMC = vIMC;
            oIMC.CalcularIMC();

            //Asignar a lblIMC el valor del IMC calculado
            lblIMC.Text = oIMC.vIMC.IMC.ToString("#,###.#");
            //Asignar a lblRecomendaciones ela recomendacion
            lblRecomendaciones.Text = oIMC.vIMC.Recomendacion;
 
        }
    }
}