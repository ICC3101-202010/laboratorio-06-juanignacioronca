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
    class Bloque
    {
        public string Nombre;
        public Persona Encargado;
                public List<Persona> Personal = new List<Persona>();

        public Bloque(string nombre, Persona encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
        }

        public string Informacion_Bloque()
        {
            string a = "Nombre del bloque: " + Nombre + "\nNombre del encargado: " + Encargado.Nombre + " " + Encargado.Apellido+"\n";
            foreach (var item in Personal)
            {
                a += item.Informacion_Persona();
            }
            return a;
        }
    }
}
