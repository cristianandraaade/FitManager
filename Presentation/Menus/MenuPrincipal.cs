using FitManager.Core.Interfaces;

namespace FitManager.Presentation.Menus
{
    public class MenuPrincipal
    {
        private readonly MenuAluno _menuAluno;

        public MenuPrincipal(MenuAluno menuAluno)
        {
            _menuAluno = menuAluno;
        }

        public void Exibir()
        {
            while (true)
            {
                Console.WriteLine("\n--- FITMANAGER ---");
                Console.WriteLine("1 - Gerenciar Alunos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        _menuAluno.Exibir();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
