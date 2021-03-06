namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else{
                System.Console.WriteLine("valores invalidos");
                
                
            }
        }
            
        public double ObterArea()
        {   
            if(valido)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("preencha um valor válido");
                return 0;
            }
        }
    }
}