using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PROYECTO_salarios_minimos
{
    class ClaseControl
    {
        private Empleados contenedora;
        private Validacion validador;
        public ClaseControl()
        {
            WriteLine("Digite el numero maximo de empleados: ");
            validador = new Validacion();
            int n = validador.ValidarInteger(Console.ReadLine());
            contenedora = new Empleados(n);
            Menu();
        }
        public string Instrucciones() =>
            "                 Menu\n" +
            "(1)Insertar empleado\n" +
            "(2)Consultar lista de empleados\n" +
            "(3)Incrementar salarios\n" +
            "(4)Salir de sistema\n"+
            "Digite una opcion";
        public void InsertarEmpleado()
        {
           
            if(contenedora.HayCampo())
            {
                string nombre, cedula, tipo;
                double salario;
                Console.WriteLine("Digite el nombre del empleado:");
                nombre = validador.ValidarNombre(ReadLine());
                Console.WriteLine("Digite la cedula del empleado:");
                cedula = validador.ValidarId(ReadLine());
                Console.WriteLine("Digite el tipo de empleado:");
                tipo = validador.ValidarTipo(ReadLine());
                Console.WriteLine("Digite el salario del empleado:");
                salario = validador.ValidarSalario(ReadLine());
                contenedora.InsertarEmpleado(new Empleado(nombre, cedula, salario, tipo));
            }
            else
                WriteLine("No hay mas campo para insertar empleados");
        }
        public void ConsultarEmpleado()
        {
            if(contenedora.GetCantidad()==0)
                Console.WriteLine("No hay empleados que mostrar");
            else
            {
                string id;
                Console.WriteLine(contenedora.ListarCedulas());
                Console.WriteLine("Digite el ID del empleado a buscar: ");
                id = Console.ReadLine();
                Empleado empleadoDeTurno = contenedora.ConsultarEmpleado(id);
                while (empleadoDeTurno == null)
                {
                    Console.WriteLine("ID no encontrado, digite nuevamente");
                    id = Console.ReadLine();
                    empleadoDeTurno = contenedora.ConsultarEmpleado(id);
                }
                WriteLine(empleadoDeTurno.Datos());
            }
        }
        public void IncrementarSalarios()
        {
            if(contenedora.GetCantidad()==0)
            {
                Console.WriteLine("No hay empleados");
            }
            else
            {
                Console.WriteLine("Salarios antes del aumento \n");
                Console.WriteLine(contenedora.ListarSalarios());
                Console.WriteLine("Salarios despues del aumento \n");
                Console.WriteLine(contenedora.ListarSalarios());
            }
        }
        public void Menu()
        {
            WriteLine(Instrucciones());
            string opcion = Console.ReadLine();
            while(opcion!="4")
            {
                if(opcion=="1")
                {
                    InsertarEmpleado();
                }
                else if(opcion=="2")
                {
                    ConsultarEmpleado();
                }
                else if(opcion=="3")
                {
                    IncrementarSalarios();
                }
                else if(opcion=="4")
                {
                    WriteLine("Ha salido exitosamente");
                }
                else
                {
                    WriteLine("Opcion equivocada");
                }
                Console.ReadKey();
                Console.Clear();
                WriteLine(Instrucciones());
                opcion = Console.ReadLine();

            }

        }

    }
        
}
