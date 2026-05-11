using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones.Calificaciones
{
    //se ha creado la clase calificaciones 
    internal class clsCalificaciones
    {
        //segun el proceso de abstraccion se detecta que cada materia contiene los siguientes atributos y metodos 
        //atributos
        private string Nombre;
        private float Parcial_1;
        private float Parcial_2;
        private float Parcial_3;
        
        //constructor vacio
        public clsCalificaciones()
        {
            Parcial_1 = 0.0f;
            Parcial_2 = 0.0f;
            Parcial_3 = 0.0f;
            Nombre = "";
        }

        //constructor parametrizado 
        public clsCalificaciones(string nombre, float P1, float p2, float p3)
        {
            Parcial_1 = P1;
            Parcial_2 = p2;
            Parcial_3 = p3;
            Nombre = nombre;
        }

        //metodos
        public float promedio()
        {
            float res = 0;
            res = (Parcial_1 + Parcial_2 + Parcial_3) / 3;
            return res;
        }

    }
}
