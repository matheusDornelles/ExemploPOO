using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

using Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {   
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var NovoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste.txt");
            var listaString = new List<string> {"lista1, lista2, lista3"};
            var listaTextoString = new List <string> {"lista4, 5 e 6"};
            

            FiledHelper helper = new FiledHelper();

            helper.DeletarArquivo(caminhoArquivo);


           // helper.MoverArquivo(caminhoArquivo, NovoCaminhoArquivo, true);
           // helper.CopiarArquivo(caminhoArquivo, NovoCaminhoArquivo, true);




           // helper.LerArquivo(caminhoArquivo);
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarArquivoTextoStream(caminhoArquivo, listaTextoString);
    




            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivos(caminho);
            
            
            // System.Console.WriteLine("Criando diretorio : " + caminhoPathCombine)
            // helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretório(caminhoPathCombine, true);
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));

            

            
            
            
            
            
            
            
            
            
            
            
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

















        //    Corrente c = new Corrente();
        //    c.Creditar(100);

        //    c.ExibirSaldo();














            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma : " + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado da primeira soma : " + calc.Somar(10,10,10));











            // Aluno p1 = new Aluno(); 

            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 10;
            // p1.Documento = "7878";
            
            // p1.Apresentar();
        }












            // Retangulo r = new Retangulo();
            // r.DefinirMedidas (30,30);
            // System.Console.WriteLine($"Área :{r.ObterArea()}");  
           







            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;
            
            // p1.Apresentar();
        }
    }



