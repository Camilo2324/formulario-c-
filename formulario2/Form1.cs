using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            string nombres = textBox1.Text;
            string apellidos = textBox2.Text;
            string edad = textBox3.Text;
            string estatura = textBox4.Text;
            string telefono = textBox5.Text;

            string genero = "";
            if (radioButton1.Checked)
            {
                genero = "Hombre";
            }
            else if (radioButton2.Checked)
            {
                genero = "Mujer";
            }

            string datos = ($"nombre: {nombres}\r\nApellidos:{apellidos}\r\nEdad:{edad}\r\nEstatura:{estatura}\r\nTelefono):{telefono}\r\nGenero:{genero}");
            string rutaArchivo = ("C:/Users/Camil/Documents/Practica 03 Formulario/datos.txt");

            bool archivoExistete = File.Exists(rutaArchivo);
            Console.WriteLine(archivoExistete);

            if (archivoExistete == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {

                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    if (archivoExistete)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }


            }

        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}

