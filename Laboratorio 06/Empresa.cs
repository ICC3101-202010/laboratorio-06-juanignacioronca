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

        public Empresa(string nombre, string rUT)
        {
            Nombre = nombre;
            RUT = rUT;
        }
    }
}
