using FitManager.Core.Entities;
using FitManager.Core.Interfaces;
using FitManager.Presentation.Views;

namespace FitManager.Presentation.Menus
{
    public class MenuAluno
    {
        private readonly IAlunoService _service;

        public MenuAluno(IAlunoService service)
        {
            _service = service;
        }

        public void Exibir()
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU ALUNOS ---");
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("3 - Editar");
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ViewAluno.Listar(_service.Listar());
                        break;

                    case "2":
                        Cadastrar();
                        break;

                    case "3":
                        Editar();
                        break;

                    case "4":
                        Excluir();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        private void Cadastrar()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());

            _service.Cadastrar(new Aluno
            {
                Nome = nome,
                Idade = idade,
                Peso = peso,
                Altura = altura
            });

            Console.WriteLine("Aluno cadastrado!");
        }

        private void Editar()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            var aluno = _service.BuscarPorId(id);

            Console.Write($"Nome ({aluno.Nome}): ");
            aluno.Nome = Console.ReadLine();

            Console.Write($"Idade ({aluno.Idade}): ");
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.Write($"Peso ({aluno.Peso}): ");
            aluno.Peso = double.Parse(Console.ReadLine());

            Console.Write($"Altura ({aluno.Altura}): ");
            aluno.Altura = double.Parse(Console.ReadLine());

            _service.Editar(aluno);

            Console.WriteLine("Aluno atualizado!");
        }

        private void Excluir()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            _service.Excluir(id);

            Console.WriteLine("Aluno removido!");
        }
    }
}
