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
    class Empresa
    {
        public string Nombre;
        public string RUT;
        public List<Division> Lista_de_divisiones = new List<Division>();

        public Empresa(string nombre, string rut)
        {
            Nombre = nombre;
            RUT = rut;
        }
        public string Informacion()
        {
            string txt = "\nNombre de la empresa: " + Nombre + "\nRut de la empresa: " + RUT+"\n";
            foreach (var item in Lista_de_divisiones)
            {
                txt+=item.Informacion_Division();
            }
            return txt;
        }
    }
}
