using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsarStreamDeEntrada()
        {
            Console.WriteLine("Digite algo mano");

            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt",FileMode.Create))
            {
                var buffer = new byte[1024]; //1Kb


                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesLidos);
                    
                    fs.Flush(); //Despeja o buffer para a Stream

                    Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
                }
            }
        }
    }
}
