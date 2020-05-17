﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = -1;
            List<Empresa> Lista_empresas = new List<Empresa>();
            while (a!=0)
            {
                Console.WriteLine("Bienvenido:\n1. Para crear una nueva empresa\n2. Para leer empresas creadas previamente\n3. Mostrar informacion empresas\n0. Para salir.");
                a = Convert.ToInt32(Console.ReadLine());
                if (a==1)
                {
                    Console.WriteLine("Ingrese el nombre de la empresa");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut de la empresa");
                    string rut = Console.ReadLine();
                    Empresa empresa = new Empresa(nombre, rut);
                    Division division = new Division("Nombre Division", new Persona("Nombre", "Apellido", "Rut", "Encargado Division"));
                    Area area = new Area("Nombre Area", new Persona("Nombre", "Apellido", "Rut", "Encargado Area"));
                    Departamento departamento = new Departamento("Nombre Departamento", new Persona("Nombre", "Apellido", "Rut", "Encargado Departamento"));
                    Seccion seccion = new Seccion("Nombre Seccion", new Persona("Nombre", "Apellido", "Rut", "Encargado Seccion"));
                    Bloque bloque_1 = new Bloque("Nombre bloque 1", new Persona("Nombre 1", "Apellido 1", "Rut 1", "Cargo 1"));
                    Bloque bloque_2 = new Bloque("Nombre bloque 2", new Persona("Nombre 2", "Apellido 2", "Rut 2", "Cargo 2"));
                    bloque_1.Personal.Add(new Persona("Nombre", "Apellido", "Rut", "Empleado 1"));
                    bloque_1.Personal.Add(new Persona("Nombre", "Apellido", "Rut", "Empleado 2"));
                    bloque_2.Personal.Add(new Persona("Nombre", "Apellido", "Rut", "Empleado 1"));
                    bloque_2.Personal.Add(new Persona("Nombre", "Apellido", "Rut", "Empleado 2"));
                    seccion.Lista_Bloques.Add(bloque_1);
                    seccion.Lista_Bloques.Add(bloque_2);
                    departamento.Lista_Secciones.Add(seccion);
                    area.Lista_Departamentos.Add(departamento);
                    division.Lista_Areas.Add(area);
                    empresa.Lista_de_divisiones.Add(division);
                    Lista_empresas.Add(empresa);
                    Console.WriteLine("Empresa creada correctamente");
                    
                }
                else if (a==2)
                {
                    try
                    {
                        FileStream fs = new FileStream("Empresas.bin", FileMode.Open);
                        BinaryFormatter formatter = new BinaryFormatter();
                        Lista_empresas = (List<Empresa>)formatter.Deserialize(fs);
                        Console.WriteLine("Empresas agregadas correctamente");
                        fs.Close();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No hay empresas creadas, cree una.");
                        Console.WriteLine("Ingrese el nombre de la empresa");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut de la empresa");
                        string rut = Console.ReadLine();
                        Lista_empresas.Add(new Empresa(nombre, rut));
                        Console.WriteLine("Empresa agregada correctamente");
                    }
                    
                }
                else if (a==3)
                {
                    if (Lista_empresas.Count() == 0)
                    {
                        Console.WriteLine("No hay empresas creadas.");
                    }
                    else
                    {
                        foreach (var item in Lista_empresas)
                        {
                            Console.WriteLine(item.Informacion());
                        }
                    }
                }                
                else if (a==0)
                {
                    FileStream fs = new FileStream("Empresas.bin", FileMode.Create);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, Lista_empresas);
                    fs.Close();
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta, intente nuevamente");
                }
            }
        }
    }
}
