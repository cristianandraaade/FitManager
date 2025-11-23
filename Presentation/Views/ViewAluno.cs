using FitManager.Core.Entities;

namespace FitManager.Presentation.Views
{
    public static class ViewAluno
    {
        public static void Listar(IEnumerable<Aluno> alunos)
        {
            Console.WriteLine("\n--- LISTA DE ALUNOS ---");
            foreach (var a in alunos)
            {
                Console.WriteLine($"[{a.Id}] {a.Nome} - {a.Idade} anos - {a.Peso}kg - {a.Altura}m");
            }
        }

        public static void Mostrar(Aluno aluno)
        {
            Console.WriteLine("\n--- DETALHES DO ALUNO ---");
            Console.WriteLine($"ID: {aluno.Id}");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"Peso: {aluno.Peso}");
            Console.WriteLine($"Altura: {aluno.Altura}");
            Console.WriteLine($"IMC: {aluno.CalcularIMC():F2}");
        }
    }
}
