using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void StreamReader()
        {
            string enderecoDoArquivo = "contas.txt";

            //Quando temos unsings aninhado, podemos remover as chaves do mais externo e teremos a ordenação confirme abaixo
            using (FileStream fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();
                    var conta = ConverterStringParaContaCorrente(linha);
                    var msg = $"{conta.Titular.Nome}: ag: {conta.Agencia}, num: {conta.Numero}, Saldo {conta.Saldo}";
                    Console.WriteLine(msg);
                }

            }


            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            //Convertendo o resultado encontrado
            var agenciaComInt = int.Parse(agencia);
            var numeroComInt = int.Parse(numero);
            var saldoComDouble = double.Parse(saldo);

            var conta = new ContaCorrente(agenciaComInt, numeroComInt);
            conta.Depositar(saldoComDouble);
            conta.Titular = new Cliente() { Nome = nomeTitular };
            return conta;
        }
    }
}
