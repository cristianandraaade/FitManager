using FitManager.Core.Entities;

namespace FitManager.Core.Interfaces
{
    public interface IAlunoRepository
    {
        List<Aluno> ObterTodos();
        Aluno ObterPorId (int id);
        void Adicionar (Aluno aluno);
        void Atualizar (Aluno aluno);
        void Remover (int id);

        //função que vai gravar no json
        void Salvar();
    }
}