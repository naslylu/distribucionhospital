using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distribucionhospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Emergencia.Clear();
            txt_Cirugia.Clear();
            txt_Suministros.Clear();
            txt_Administracion.Clear();
            txt_Laboratorio.Clear();
            txt_Imagenes.Clear();
            txt_Presupuesto.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Distribuir_Click(object sender, EventArgs e)
        {
             try
            {
                double Presupuesto = Convert.ToDouble(txt_Presupuesto.Text);

                double Emergencia = Presupuesto * 0.30;
                double Cirugia = Presupuesto * 0.15;
                double Suministros = Presupuesto * 0.25;
                double Administracion = Presupuesto * 0.18;
                double Laboratorio = Presupuesto * 0.05;
                double Imagenes = Presupuesto * 0.07;

                txt_Emergencia.Text = Emergencia.ToString("C");
                txt_Cirugia.Text = Cirugia.ToString("C");
                txt_Suministros.Text = Suministros.ToString("C");
                txt_Administracion.Text = Administracion.ToString("C");
                txt_Laboratorio.Text = Laboratorio.ToString("C");
                txt_Imagenes.Text = Imagenes.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +  ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
