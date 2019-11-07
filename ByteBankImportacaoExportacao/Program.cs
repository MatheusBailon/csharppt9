using ByteBankImportacaoExportacao.Modelos;
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
        static void Main(string[] args) 
        {
            string enderecoDoArquivo = "contas.txt";

            //Quando temos unsings aninhado, podemos remover as chaves do mais externo e teremos a ordenação confirme abaixo
            using(FileStream fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }


            Console.ReadLine();
        }

        
    }
} 
 