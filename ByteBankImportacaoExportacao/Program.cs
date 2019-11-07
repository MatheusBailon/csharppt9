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
            File.WriteAllText("escrevendoComAClasseEstaticaFile.txt", "Teste de escrita pela File");

            Console.WriteLine("Arquivo Criado com sucesso!!");


            var byteArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Total bytes {byteArquivo.Length}");


            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas[0]);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("Digite algo irmão");
            var text = Console.ReadLine();

            Console.WriteLine($"Aplicação finalizada {text}");
            Console.ReadLine();
        }

        

        
    }
} 
 