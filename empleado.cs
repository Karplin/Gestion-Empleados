using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_empleados
{
    public abstract class empleado
    {


        public int codigo { get; set; } 
        public int horas_laboral, precio, salario;
        public string nombre, departamento, cargo, medio_cobro;


        public abstract void Ponchar(int hola, string hi );
        public abstract void Trabajar();
        public abstract void Cobrar(int salario);
    


    }



}
