using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_salarios_minimos
{
    class Validacion
    {
        public string ValidarNombre(string nombre)
        {
            while(string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacio: ");
                nombre= Console.ReadLine();
            }
            return nombre;
        }
        public string ValidarId(string id)
        {
            /*Hay paginas que rellenan nombres y fecha de nacimiento con solo poner la cedula
             me gustaria saber esa funcion
             */
            while(string.IsNullOrEmpty(id)||id.Length!=9)
            {
                Console.WriteLine("Cedula invalida. Digite de nuevo: ");
                id = Console.ReadLine();
            }
            return id;
        }
        public double ValidarSalario(string salario)
        {
            double number;
            while (double.TryParse(salario,out number)==false)
            {
                Console.WriteLine("Eso no es un numero, digite de nuevo: ");
                salario = Console.ReadLine();
            }
            double salario2 = double.Parse(salario);
            return salario2;
        }
        public string ValidarTipo(string tipo)
        {
            while(tipo!= "TONCG" && tipo!= "TOSCG" && tipo!="TOCG")
            {
                Console.WriteLine("Eso no es un tipo de empleado valido, digite de nuevo: ");
                tipo = Console.ReadLine();
            }
            return tipo;
        }
        public int ValidarInteger(string integer)
        {
            int number;
            while (int.TryParse(integer, out number)==false)
            {
                Console.WriteLine("Eso no es un numero, digite de nuevo: ");
                integer=Console.ReadLine();
            }
            int integer2 = int.Parse(integer);
            return integer2;
        }
    }
}
