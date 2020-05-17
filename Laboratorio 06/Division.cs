using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;


namespace Laboratorio_06
{
    [Serializable]
    class Division
    {
        public string Nombre;
        public Persona Encargado;
        public List<Area> Lista_Areas = new List<Area>();

        public Division(string nombre, Persona encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
        }

        public string Informacion_Division()
        {
            string a = "Nombre de la division: " + Nombre + "\nNombre del encargado: " + Encargado.Nombre + " " + Encargado.Apellido+"\n";
            foreach (var item in Lista_Areas)
            {
                a += item.Informacion_Area();
            }
            return a;
        }
    }
}
