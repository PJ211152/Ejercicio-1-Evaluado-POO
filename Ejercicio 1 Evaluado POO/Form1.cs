using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Evaluado_POO
{
    public partial class Form1 : Form
    {
        Password clave = new Password();
        public Form1()
        {
            InitializeComponent();
            clave.Longitud = 8;
            txb_longitud.MaxLength = clave.Longitud;
            txb_NewContraseña.MaxLength = clave.Longitud;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Comprobar_Click(object sender, EventArgs e)
        {
            try
            {
                int Nlongitud = Convert.ToInt32(txb_longitud.Text);
                if (txb_longitud.TextLength != 0)
                {
                    if (Nlongitud>=8 && Nlongitud<=32)
                    {
                        
                        clave.Longitud = Nlongitud;
                        MessageBox.Show("la longitud a cambiado a " + clave.Longitud);
                        lbl_Longitud.Text = "Longitud actual: " + clave.Longitud;
                        txb_longitud.MaxLength = clave.Longitud;
                        txb_NewContraseña.MaxLength = clave.Longitud;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una longitud entre 8 y 32");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Introduzca valores validos");
                
            }
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            
            txb_GenContraseña.Text = clave.generarpassword();

            
        }

        private void btn_Nueva_Click(object sender, EventArgs e)
        {   
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_Fuerte1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int largo = txb_GenContraseña.Text.Length;
            

            if(txb_GenContraseña.TextLength == 0)
            {
                MessageBox.Show("Genere una contraseña primero");
            }
            else
            {
                clave.Contraseñatemporal = txb_GenContraseña.Text;

                if (largo == clave.Longitud)
                {
                    if (clave.Esfuerte() == true)
                    {
                        lbl_Fuerte1.ForeColor = Color.Green;
                        lbl_Fuerte1.Text = "La contraseña es segura";
                    }
                    else
                    {
                        lbl_Fuerte1.ForeColor = Color.Red;
                        lbl_Fuerte1.Text = "La contraseña es insegura";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int largo = txb_NewContraseña.Text.Length;

            if (txb_NewContraseña.TextLength == 0)
            {
                MessageBox.Show("Escriba una contraseña primero");
            }
            else
            {
                clave.Contraseñatemporal = txb_NewContraseña.Text;

                if (largo >= 8)
                {
                    if (clave.Esfuerte() == true)
                    {
                        lbl_Fuerte2.ForeColor = Color.Green;
                        lbl_Fuerte2.Text="La contraseña es segura";
                    }
                    else
                    {
                        lbl_Fuerte2.ForeColor = Color.Red;
                        lbl_Fuerte2.Text = "La contraseña es insegura";
                    }
                }
            }
        }

        private void btn_SetPassword1_Click(object sender, EventArgs e)
        {
            



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txb_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la longitud a cambiado a " + clave.Longitud);
        }
    }
}

