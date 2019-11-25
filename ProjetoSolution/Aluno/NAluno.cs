using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class NAluno
    {
        private List<Aluno> a = new List<Aluno>();
        private PAluno i;

        public void InserirAluno(Aluno x)
        {
            a.Add(x);
        }

        public List<Aluno> ListarAluno()
        {
            i = new PAluno();
            return i.Open().a.ToList();
        }

        public void AtualizarAluno(Aluno x)
        {
            i = new PAluno();
            List<PAluno> att = i.Open();

            for (int j = 0; j < att.Count; j++)
            {
                if (att[j].GetAlunoId() == x.GetAlunoId())
                {
                    att.RemoveAt(j);
                }
            }
            att.Add(x);
            i.Save(att);
        }

        public void ExcluirAluno(Aluno x)
        {
            i = new PAluno();
            List<Aluno> excluir = i.Open();

            for (int j = 0; j < excluir.Count; j++)
            {
                if (excluir[i].AlunoId == x.AlunoId())
                {
                    excluir.RemoveAt(j);
                }
            }
            i.Save(excluir);
        }
    }
}
