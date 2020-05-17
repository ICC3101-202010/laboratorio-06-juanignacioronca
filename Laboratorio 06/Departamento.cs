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
    class Departamento
    {
        public string Nombre;
        public Persona Encargado;
        public List<Seccion> Lista_Secciones = new List<Seccion>();

        public Departamento(string nombre, Persona encargado)
        {
            Nombre = nombre;
            Encargado = encargado;
        }

        public string Informacion_Departamento()
        {
            string a = "Nombre del departamento: " + Nombre + "\nNombre del encargado: " + Encargado.Nombre + " " + Encargado.Apellido+"\n";
            foreach (var item in Lista_Secciones)
            {
                a += item.Informacion_Seccion();
            }
            return a;
        }
    }
}
