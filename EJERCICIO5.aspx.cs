using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EVALUACION
{
    public partial class EJERCICIO5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double nummat,costmat,prom,cole,desc,totalcole,iva;
                    
                    //DATOS DE ENTRADA
                        nummat = Convert.ToDouble(txtnummat.Text);
                        costmat = Convert.ToDouble(txtcostmat.Text);
                        prom = Convert.ToDouble(txtprom.Text);

                            //PROCEDIMIENTO
                                if (prom >= 9)
                                {
                                    cole = nummat * costmat;
                                    desc = cole * 0.30;
                                    totalcole = cole - desc;
                                    lbltotalcole.Text = System.Convert.ToString(totalcole);
                                }
                                else
                                    if (prom <= 9)
                                    {
                                        cole = nummat * costmat;
                                        iva = cole * 0.10;
                                        totalcole = cole + iva; 
                                        lbltotalcole.Text = System.Convert.ToString(totalcole);
                                    }
        }                        
    }
}