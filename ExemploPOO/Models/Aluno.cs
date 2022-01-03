namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public string? Documento { get; set; }

         public override void Apresentar ()
        {
            Console.WriteLine($"olá meu nome é {Nome} e tenho {Idade} anos e minha nota foi {Nota}");

        }
    }
}