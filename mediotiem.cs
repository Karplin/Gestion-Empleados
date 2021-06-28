using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_empleados
{
    class mediotiem : empleado


    {
       string medio_cobro = "Cuenta bancaria";
        public override string ToString()
        {
            return "Codigo: " + codigo + " Nombre: " + nombre + " Horas laboradas: " + horas_laboral + " Precio por Hora: " +
             precio  + " Salario: " + salario +  " Departamento: " + departamento + " Cargo: " + cargo + " Medio de cobro: " + medio_cobro;
        }

        public override void Ponchar(int codigomedio, string nombremedio)
        {
            Console.WriteLine("Codigo: " + codigomedio + " Nombre: " +nombremedio + " Fecha y Hora: "+DateTime.Now);
        }

        public override void Trabajar()
        {
            Console.WriteLine("");

            Console.WriteLine("Medio tiempo trabajando!");

            Console.WriteLine("");
        }
        public override void Cobrar(int salario)
        {
         
            Console.WriteLine("Tipo: Medio Tiempo--" + "--Salario: " + salario + " --Medio a cobrar:" + medio_cobro);
        }




    }
}
