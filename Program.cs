using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaDeBonoResultados;
using LogicaDePresentismo;
using LogicaDeSueldo;

namespace GuiaObj_SueldoDePepe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Pepe = new Empleado();
            Pepe.Categoria = "Gerente";
            Pepe.CantFaltas = 0;
            Pepe.GetResultadoPresentismo = new BonoPresentismo();
            Pepe.GetBonoResultados = new BonoResultados.Bono10Porciento();

            Console.WriteLine("Sueldo de Pepe: $" + Pepe.CalcularSueldo());
        }
    }
}
