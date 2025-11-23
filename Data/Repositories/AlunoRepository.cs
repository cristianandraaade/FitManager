using System.Text.Json;
using FitManager.Core.Entities;
using FitManager.Core.Interfaces;

namespace FitManager.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly string _caminhoArquivo = "Data/Storage/alunos.json";
        private List<Aluno> _alunos = new();

        public AlunoRepository()
        {
            Carregar();
        }

        private void Carregar()
        {
            if (!File.Exists(_caminhoArquivo))
            {
                Directory.CreateDirectory("Data/Storage");
                Salvar();
            }

            string json = File.ReadAllText(_caminhoArquivo);
            if (!string.IsNullOrWhiteSpace(json))
                _alunos = JsonSerializer.Deserialize<List<Aluno>>(json) ?? new List<Aluno>();
        }

        public void Salvar()
        {
            string json = JsonSerializer.Serialize(_alunos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_caminhoArquivo, json);
        }

        public List<Aluno> ObterTodos() => _alunos;

        public Aluno? ObterPorId(int id) =>
            _alunos.FirstOrDefault(a => a.Id == id);

        public void Adicionar(Aluno aluno)
        {
            aluno.Id = _alunos.Count == 0 ? 1 : _alunos.Max(a => a.Id) + 1;
            _alunos.Add(aluno);
            Salvar();
        }

        public void Atualizar(Aluno aluno)
        {
            var existente = ObterPorId(aluno.Id);
            if (existente == null) return;

            existente.Nome = aluno.Nome;
            existente.Idade = aluno.Idade;
            existente.Peso = aluno.Peso;
            existente.Altura = aluno.Altura;

            Salvar();
        }

        public void Remover(int id)
        {
            var aluno = ObterPorId(id);
            if (aluno != null)
            {
                _alunos.Remove(aluno);
                Salvar();
            }
        }
    }
}
