using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_empleados
{
     class tiempocom : empleado
    {
        string medio_cobro = "Cuenta Bancaria";
        
        public override string ToString()
        {
            return "Codigo: " + codigo +" Nombre: "+nombre+ " Horas laboradas: "+ horas_laboral + 
            " Precio por Hora: "+ precio  + " Salario: " + salario + " Departamento: " + departamento +" Cargo: "+ cargo + " Medio de cobro: "+ medio_cobro;
           
        }
         
       
        public override void Ponchar(int haha, string hoho)
        {
            Console.WriteLine("Codigo: " + haha  +" Nombre: " + hoho +" Fecha y Hora: "+DateTime.Now);
        }
        
        public override void Trabajar()
        {
            Console.WriteLine("");
            Console.WriteLine("Tiempo completo trabajando!");
            Console.WriteLine("");
        }
        public override void Cobrar(int salario)
        {
            Console.WriteLine(" Tipo: Tiempo Completo-- "+ " --Salario: " + salario + " --Medio a cobrar: " + medio_cobro);
        }


    }
}
