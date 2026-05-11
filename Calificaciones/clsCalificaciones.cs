using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones.Calificaciones
{
    //se ha creado la clase calificaciones 
    internal class Materia
    {
        //segun el proceso de abstraccion se detecta que cada materia contiene los siguientes atributos y metodos 
        //atributos
        private string nombre;
        private float parcial1;
        private float parcial2;
        private float parcial3;

        //propiedades de los atributos

        public float Parcial1
        {
            get { return parcial1; }
            set
            {
                if(value>=0 && value <= 10)
                {
                    parcial1 = value;
                }
                else
                {
                    parcial1 = -1f;
                }
            }
        }

        public float Parcial2
        {
            get { return parcial2; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    parcial2 = value;
                }
                else
                {
                    parcial2 = -1f;
                }
            }
        }

        public float Parcial3
        {
            get { return parcial3; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    parcial3 = value;
                }
                else
                {
                    parcial3 = -1f;
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        //constructor vacio
        public Materia()
        {
            parcial1 = 0.0f;
            parcial2 = 0.0f;
            parcial3 = 0.0f;
            nombre = "";
        }

        //constructor parametrizado 
        public Materia(string nombre, float P1, float p2, float p3)
        {
            parcial1 = P1;
            parcial2 = p2;
            parcial3 = p3;
            this.nombre = nombre;
        }

        //metodos
        public float CalcularPromedio()
        {
            float res = 0;
            res = (parcial1 + parcial2 + parcial3) / 3;
            return res;
        }

    }
}
