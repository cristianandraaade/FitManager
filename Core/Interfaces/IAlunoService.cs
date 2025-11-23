using FitManager.Core.Entities;

namespace FitManager.Core.Interfaces
{
    public interface IAlunoService
    {
        List<Aluno> Listar();
        Aluno BuscarPorId(int id);
        void Cadastrar(Aluno aluno);
        void Editar(Aluno aluno);
        void Excluir(int id);
    }
}
