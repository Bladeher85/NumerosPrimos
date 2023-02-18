using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nPrimos
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool EsPrimo(int numero)
        {
            //Creamos un ciclo para validar que cumpla con lo requerido
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int total = 0;
            //creamos una instancia
            List<NumerosPrimos> lista = new List<NumerosPrimos>();
            string log = File.ReadAllText(@"C:\logs\milog.txt");
            int contador = 1;
            log += string.Format("Numero ingresado ={0} \n",numero);

            //recorremos las posiciones
            for (int i = 2; i <=numero; i++)
            {
                if (EsPrimo(i))
                {
                    NumerosPrimos item = new NumerosPrimos();
                    item.index = contador;
                    item.numero = i;
                    lista.Add(item);
                    total =total+ i;
                    log += string.Format("Numero primo ={0} \n", i);
                    contador++;
                }
            }
            log += string.Format("Total ={0} \n", total);
            File.WriteAllText(@"C:\logs\milog.txt", log);
            gridDatos.DataSource = lista;
            gridDatos.DataBind();
            txtTotal.Text = string.Format("Total={0}",total);
        }
    }
    public class NumerosPrimos
    {
        public int index { get; set; }
        public int numero { get; set; }
    }
}