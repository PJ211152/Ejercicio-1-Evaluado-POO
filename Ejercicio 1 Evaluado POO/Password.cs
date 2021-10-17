using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Evaluado_POO
{
    class Password
    {
        private string contraseña;
        private int longitud;
        private int longitud_def;

        public Password()
        {
            contraseña = "12345678";
            longitud_def = 8;
            { longitud = longitud_def; }
        }

        public string Contraseña
        {
            get { return contraseña; }
        }

        public int Longitud
        {
            
            get { return longitud; }
            set { longitud = value; }
        }

        public string generarpassword() //Metodo para generar contraseña
        {
            Random random = new Random(); //llamando a la clase aleatoria
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890", clavegenerada = "";
            int L = Longitud;
            int tamaño = cadena.Length;
            char letra;

            for (int i = 0; i < L; i++) //For para generar la contraseña
            {
                letra = cadena[random.Next(tamaño)];
                clavegenerada += letra.ToString();
            }
            return clavegenerada;

        }

        string contraseñatemporal;
        public string Contraseñatemporal
        {
            get { return contraseñatemporal; }
            set { contraseñatemporal = value; }
        }



        public bool Esfuerte()   //metodo para comprobar la fuerza y segurudad de la contraseña
        {

            char caracter;
            int mayus = 0, minus = 0, numero = 0;
            int tamaño = Longitud;
            bool fuerte = false;
            for (int i = 0; i < tamaño; i++)
            {
                caracter = contraseñatemporal[i];
                string letra = Convert.ToString(caracter);

                if (letra.All(char.IsDigit))
                {
                    numero = numero + 1;
                }
                if (letra.All(char.IsLower))
                {
                    minus = minus + 1;
                }
                if (letra.All(char.IsUpper))
                {
                    mayus = mayus + 1;
                }
            }

            if (numero >= 5)
            {
                if (mayus >= 2)
                {
                    if (minus >= 1)
                    {
                        fuerte = true;
                    }
                    else
                    {
                        fuerte = false;
                    }
                }
                else
                {
                    fuerte = false;
                }
            }
            else
            {
                fuerte = false;
            }
            return fuerte;
        }
      }
    }
