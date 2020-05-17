using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio_06
{
    [Serializable]
    class Persona
    {
        public string Nombre;
        public string Apellido;
        public string RUT;
        public string Cargo;

        public Persona(string nombre, string apellido, string rUT, string cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            RUT = rUT;
            Cargo = cargo;
        }

        public string Informacion_Persona()
        {
            string a = "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nRut: " + RUT + "\nCargo: " + Cargo;
            return a;
            
        }
    }
}
