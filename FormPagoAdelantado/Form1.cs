using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_de_clases;
namespace FormPagoAdelantado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_montoApagar.Text = string.Empty;
            l_mensajes.Text = string.Empty;
            tb_montoApagar.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            tb_montoApagar.Text = "";
            tb_porcDesc.Text = "";
            cb_dias.SelectedIndex = 0;
            tb_numMeses.Text = "";
            tb_pagoAdelantado.Text = "";
        }
        private void b_restaurar_Click(object sender, EventArgs e)
        {
            Limpiar();
            l_mensajes.Text = "";
            tb_montoApagar.Focus();
        }

        private void b_consultar_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = "";


            if ("".Equals(tb_montoApagar.Text))
            {
                l_mensajes.Text = "Debe ingresar el monto a pagar";
                tb_montoApagar.Focus();
            }
            else
            {
                int montoPagar;

                if (int.TryParse(tb_montoApagar.Text, out montoPagar))
                {
                    if (montoPagar > 0)
                    {
                        float porcDes;
                        if (float.TryParse(tb_porcDesc.Text, out porcDes))
                        {
                            if (porcDes > 0)
                            {
                                if (cb_dias.SelectedIndex > 0)
                                {
                                    int numMeses;
                                    if (int.TryParse(tb_numMeses.Text, out numMeses))
                                    {
                                        if (numMeses > 0)
                                        {
                                            // Creo instancia de pagoAdelantado

                                            PagoAdelantado pago = new PagoAdelantado();

                                            pago.MontoPagar = montoPagar;
                                            pago.PorcDesc = porcDes;

                                            int pagoDiasInt;
                                            int.TryParse(cb_dias.SelectedItem.ToString(), out pagoDiasInt);
                                            pago.Dias = pagoDiasInt;
                                            pago.NumeroMeses = numMeses;

                                            tb_pagoAdelantado.Text = pago.getPagoAdelantado().ToString();

                                        }
                                        else
                                        {
                                            l_mensajes.Text = "Debe ingresar un número de meses mayor a 0";
                                            tb_numMeses.Focus();
                                        }
                                    }
                                    else
                                    {
                                        l_mensajes.Text = " Debe ingresar un número de meses";
                                        tb_numMeses.Focus();
                                    }
                                }
                                else
                                {
                                    l_mensajes.Text = "Debe seleccionar la cantidad de días";
                                    cb_dias.Focus();
                                }
                            }
                            else
                            {
                                l_mensajes.Text = "Debe ingresar un numero mayor a 0";
                                tb_porcDesc.Focus();
                            }
                        }
                        else
                        {
                            l_mensajes.Text = "Debe ingresar un número real para el porcentaje de descuento";
                            tb_porcDesc.Focus();
                        }
                    }
                    else
                    {
                        l_mensajes.Text = " Debe ingresar un monto mayor a 0";
                        tb_montoApagar.Focus();
                    }
                }
                else
                {
                    l_mensajes.Text = "Debe ingresar un numero entero para el monto a pagar";
                }

            }
        }
    }
}
