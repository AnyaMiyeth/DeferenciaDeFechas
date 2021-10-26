using System;

namespace DeferenciaDeFechas
{
    class Program
    {
        static void Main(string[] args)
        {
           
                DateTime fechaInicio = DateTime.Now;
                DateTime fechaFin = fechaInicio.AddDays(31);
                var diferenciaFechas = fechaFin - fechaInicio;
                var diasTrascurridos = diferenciaFechas.Days;
                decimal mesesFraccionTranscurrdios = diasTrascurridos / 30m;
                var mes = Math.Ceiling(mesesFraccionTranscurrdios);


                Console.WriteLine($"Fecha Inicio {fechaInicio}");
                Console.WriteLine($"Fecha Fin {fechaFin}");
                Console.WriteLine($"Mes o fraccion {mesesFraccionTranscurrdios}");
                Console.WriteLine($"Meses {mes}");
                Console.ReadKey();
            
        }
    }
}
