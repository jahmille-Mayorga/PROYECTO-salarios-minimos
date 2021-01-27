using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_salarios_minimos
{
    class Empleado
    {
        private string nombre;
        private string id;
        private double salario;
        private string tipo;
        public Empleado(string n = "none", string i = "none", double s = 0, string t = "none")
        {
            SetNombre(n);
            SetId(i);
            SetSalario(s);
            SetTipo(t);
        }
        public void SetNombre(string n)
        {
            nombre = n;
        }
        public void SetId(string i)
        {
            id = i;
        }
        public void SetSalario(double s)
        {
            salario = s;
        }
        public void SetTipo(string t)
        {
            tipo = t;
        }
        public string GetNombre() => nombre;
        public string GetId() => id;
        public string GetTipo() => tipo;
        public double GetSalario() => salario;
        public string Datos() => $"Nombre: {GetNombre()}\n ID: {GetId()} \n Tipo: {GetTipo()} \n Salario: {GetSalario()} \n";

        public double SalarioMinimo()
        {
            if (GetTipo() == "TONCG")
                return 309143.36;
            else if (GetTipo() == "TOSCG")
                return 322589.87;
            else
                return 349623.39;
        }
        public bool Ajuste()
        {
            if (GetSalario() < SalarioMinimo())
            {
                SetSalario(SalarioMinimo());
                return true;
            }
            return false;
        }
       public double Porcentaje1()
        {
            if (GetTipo() == "TONCG")
                return 3.50;
            else if (GetTipo() == "TOSCG")
                return 3.10;
            else
                return 2.98;
        }
        public double Porcentaje2()
        {
            if (GetTipo() == "TONCG")
                return 3.10;
            else if (GetTipo() == "TOSCG")
                return 3.98;
            else
                return 2.50;
        }
        public double ValorIncremento()
        {
            Ajuste();
            if (GetSalario() == SalarioMinimo())
                return GetSalario() * Porcentaje1();
            return GetSalario() * Porcentaje2();
        }
        public void IncrementoSalarial()
        {
            SetSalario(GetSalario() + ValorIncremento());
        }
        public string CompararSalario(Empleado e)
        {
            if (GetSalario() > e.GetSalario())
                return "Mayor";
            else if (GetSalario() < e.GetSalario())
                return "Menor";
            else
                return "Igual";
        }
    }
}
