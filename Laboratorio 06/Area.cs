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
    class Area
    {
        public string Nombre;
        public Persona Encargado;
        public List<Departamento> Lista_Departamentos = new List<Departamento>();

        public Area(string nombre, Persona encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
        }

        public string Informacion_Area()
        {
            string a = "Nombre del area: " + Nombre + "\nNombre del encargado: " + Encargado.Nombre + " " + Encargado.Apellido+"\n";
            foreach (var item in Lista_Departamentos)
            {
                a += item.Informacion_Departamento();
            }
            return a;
        }
    }
}
