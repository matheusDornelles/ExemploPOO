using System;

namespace Helper
{
    public class FiledHelper
    {
        public void ListarDiretorios(string Caminho)
        {
           var RetornoCaminho = Directory.GetDirectories(Caminho, "*" , SearchOption.AllDirectories);

           foreach (var retorno in RetornoCaminho)
           {
               System.Console.WriteLine(retorno);
           }
        }

        public void ListarArquivos(string caminho)
        {
            var RetornoArquivos = Directory.GetFiles(caminho , "*2*" , SearchOption.AllDirectories);

            foreach (var retorno in RetornoArquivos)
           {
               System.Console.WriteLine(retorno);
           }

        }
         public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);   
            System.Console.WriteLine(retorno.FullName);
        }
        public void ApagarDiretório(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho,apagarArquivos);
        }
        public void CriarAquivoTexto(string caminho, string conteudo)
        {
            if (File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
            
        }
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {          
            using(var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }

            }
        }  

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarArquivoTextoStream(string caminho, List<string> conteudo)
        {          
            using(var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }

            }
        }
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }
        public void CopiarArquivo(string caminho, string NovoCaminho, bool sobrescrever)
        {
            File.Copy( caminho, NovoCaminho, sobrescrever);
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

    }
}