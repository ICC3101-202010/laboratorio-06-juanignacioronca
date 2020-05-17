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
    class Seccion
    {
        public string Nombre;
        public Persona Encargado;
        public List<Bloque> Lista_Bloques = new List<Bloque>();

        public Seccion(string nombre, Persona encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
        }

        public string Informacion_Seccion()
        {
            string a = "Nombre de la seccion: " + Nombre + "\nNombre del encargado: " + Encargado.Nombre + " " + Encargado.Apellido+"\n";
            foreach (var item in Lista_Bloques)
            {
                a += item.Informacion_Bloque();
            }
            return a;
        }
    }
}
