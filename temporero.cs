using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_empleados
{
    class temporero : empleado
    {

       string medio_cobro = "Cheque";
        public override string ToString()
        {
            return "Codigo: " + codigo + " Nombre: " + nombre + " Horas laboradas: " +
            horas_laboral + " Precio por Hora: " + precio + " Salario: " +salario + " Departamento: " + departamento + " Cargo: " + cargo + " Medio de cobro: " + medio_cobro;
        }
        public override void Ponchar(int tempo, string nombretemp)
        {
            Console.WriteLine("Codigo: " + tempo + " Nombre: "+ nombretemp+" Fecha y Hora: " +DateTime.Now);
        }

        public override void Trabajar()
        {
            Console.WriteLine("");
            Console.WriteLine("Temporero trabajando!");
            Console.WriteLine("");
        }
        public override void Cobrar(int salario)
        {
            Console.WriteLine("Tipo: Temporero--"+ "--Salario: " + salario+ " --Medio a cobrar: " + medio_cobro);
        }






    }
}
