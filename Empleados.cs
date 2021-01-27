using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_salarios_minimos
{
    class Empleados
    {
        private Empleado[] registro;
        private int cantidad;
        public void SetCantidad(int c)
        {
            cantidad = c;
        }
        public int GetCantidad() => cantidad;
        public Empleados(int n)
        {
            registro = new Empleado[n];
            cantidad = 0;
        }
        public int BuscarEmpleado(string id)//This'll use in the control class to insert and delete options
        {
            for(int i=0;i<GetCantidad();i++)
            {
                if (registro[i].GetId() == id)
                    return i;
            }
            return -1;
        }
        public bool HayCampo() =>registro.Length>cantidad;
        public bool InsertarEmpleado(Empleado NuevoEmpleado)
        {
            if(HayCampo())
            {
                registro[cantidad] = NuevoEmpleado;
                SetCantidad(GetCantidad() + 1);
                return true;
            }
            return false;
        }
       /* public bool NoEsID(string idDeTurno, string idBuscada) => idDeTurno != idBuscada;
        public bool EliminarEmpleado(string id)
        {
            registro=Array.FindAll(registro.,)
        }
       Tengo que encontrar la forma de eliminar elementos especificos de arrays en c#
       */
       public void IncrementarSalarios()
        {
            for(int i=0;i<GetCantidad();i++)
            {
                registro[i].IncrementoSalarial();
            }
        }
        public Empleado ConsultarEmpleado(string id)
        {
            int indice = BuscarEmpleado(id);
            if (indice != -1)
                return registro[indice];
            return null;
        }
        public string ListarCedulas()

        {
            string texto = "               Lista de cedulas\n ";
            for(int i=0;i<GetCantidad();i++)
            {
                texto = texto + registro[i].GetId()+ "\n";
            }
            return texto;
        }
        public string ListarSalarios()
        {
            string texto = "              Lista de salarios\n";
            for (int i = 0; i < GetCantidad(); i++)
            {
                texto = texto + registro[i].GetSalario()+" colones \n";
            }
            return texto;
        }
    }
  
}
