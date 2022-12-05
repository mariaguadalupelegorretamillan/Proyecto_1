using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLogin1.WSOperaciones;

namespace WebLogin1
{
    public partial class Default : System.Web.UI.Page
    {
        OperacionesSoapClient operaciones = new OperacionesSoapClient();
        int a, b, c;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSumar_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtPrimerNumero.Text);
            b = Convert.ToInt32(txtSegundoNumero.Text);
            c = operaciones.Sumar(a, b);
            EtiquetaResultado.Text = c.ToString();
        }
        protected void btnRestar_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtPrimerNumero.Text);
            b = Convert.ToInt32(txtSegundoNumero.Text);
            c = operaciones.Restar(a, b);
            EtiquetaResultado.Text = c.ToString();
        }
        protected void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtPrimerNumero.Text);
            b = Convert.ToInt32(txtSegundoNumero.Text);
            c = operaciones.Multiplicar(a, b);
            EtiquetaResultado.Text = c.ToString();
        }
        protected void btnDividir_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtPrimerNumero.Text);
            b = Convert.ToInt32(txtSegundoNumero.Text);
            c = operaciones.Dividir(a, b);
            EtiquetaResultado.Text = c.ToString();
        }
    }
}