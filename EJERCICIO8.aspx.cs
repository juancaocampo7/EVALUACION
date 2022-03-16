using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EVALUACION
{
    public partial class EJERCICIO8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double invtotal, monhip, inversion, inversocio, totalhip, restdinero;
                    
                    //DATOS DE ENTRADA
                        invtotal = Convert.ToDouble(txtinvtotal.Text);
                        monhip = Convert.ToDouble(txtmonthiptca.Text);
                            
                            //PROCEDIMIENTO 
                                 if (monhip < 1000000) 
                                 { 
                                    inversion = invtotal * 0.50;
                                    inversocio = invtotal * 0.50;
                                    lblinversion.Text = System.Convert.ToString(inversion);
                                    lblinvsocio.Text = System.Convert.ToString(inversocio);
                                 }
                                        else
                                        if (monhip >= 1000000 && invtotal < monhip)
                                        {
                                            totalhip = monhip;
                                            restdinero = invtotal - totalhip;
                                            inversion = restdinero * 0.50;
                                            inversocio = restdinero * 0.50;
                                            lblinversion.Text = System.Convert.ToString(0);
                                            lblinvsocio.Text = System.Convert.ToString(0);
                                            lblrestdinero.Text = System.Convert.ToString(0);
                                        }
                                            else 
                                            if (monhip >= 1000000)
                                            {
                                                totalhip = monhip;
                                                restdinero = invtotal - totalhip;
                                                inversion = restdinero * 0.50;
                                                inversocio = restdinero * 0.50;
                                                lblinversion.Text = System.Convert.ToString(inversion);
                                                lblinvsocio.Text = System.Convert.ToString(inversocio);
                                                lblrestdinero.Text = System.Convert.ToString(restdinero);   
                                            }   
                                        
        }                           
    }
}