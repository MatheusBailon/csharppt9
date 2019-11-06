using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            int numeroDeBytesLidos = -1;
            string enderecoDoArquivo = "contas.txt";

            //Para abrir um arquivo, basta passar o endereço dele e o modlo em que ele será utilizado, neste caso FileMode.Open
            //FileStream = Classe que trata arquivos.
            FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo,FileMode.Open);
            var tam = fluxoDoArquivo.Length;

            //Para ler um arquivo de 1KB
            var buffer = new byte[1024];
            while (tam > 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                tam -= numeroDeBytesLidos;
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            //Encoding.Default => pega a codificação de texto padrão do arquivo gerado, ou melhor do sistema
            //Operacional utilizado e retorna uma instancia desse padrão, que no nosso caso é o UTF
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
} 
 