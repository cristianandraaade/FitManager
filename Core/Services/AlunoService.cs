using FitManager.Core.Entities;
using FitManager.Core.Interfaces;

namespace FitManager.Core.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _repo;

        public AlunoService(IAlunoRepository repo)
        {
            _repo = repo;
        }

        public List<Aluno> Listar() => _repo.ObterTodos();

        public Aluno BuscarPorId(int id)
        {
            var aluno = _repo.ObterPorId(id);
            if (aluno == null)
                throw new Exception("Aluno não encontrado.");
            return aluno;
        }

        public void Cadastrar(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome))
                throw new Exception("Nome não pode ser vazio.");

            _repo.Adicionar(aluno);
        }

        public void Editar(Aluno aluno)
        {
            BuscarPorId(aluno.Id); // garante que existe
            _repo.Atualizar(aluno);
        }

        public void Excluir(int id)
        {
            BuscarPorId(id);
            _repo.Remover(id);
        }
    }
}
