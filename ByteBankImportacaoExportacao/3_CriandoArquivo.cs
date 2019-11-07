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
        static void CriarArquivo()
        {
            string caminhoNovoArquivo = "contasExportada.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,7895,4785.40, Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriaArquivoComWrite()
        {
            var caminhoNovoArquivo = "contasExportada.csv";
            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo,FileMode.CreateNew))
            using(var escritor = new StreamWriter(fluxoDeArquivo,Encoding.UTF8))
            {
                escritor.Write("456,65465,456.0,Peter");
            }
        }
    }
}
