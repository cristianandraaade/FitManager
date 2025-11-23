namespace FitManager.Core.Entities
{
    public class Aluno
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int Idade {get; set;}
        public double Peso {get; set;}
        public double Altura {get; set;}

        public double CalcularIMC()
        {
            if(Altura <= 0) return 0;
            return Peso / (Altura * Altura);
        }
    }
    
}