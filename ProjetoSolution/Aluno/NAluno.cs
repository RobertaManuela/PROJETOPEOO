using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class NAluno
    {
        private List<MAluno> a = new List<MAluno>();
        private PAluno i;

        public void InserirAluno(MAluno x)
        {
            a.Add(x);
        }

        public List<MAluno> ListarAluno()
        {
            i = new PAluno();
            return i.Open().a.ToList();
        }

        public void AtualizarAluno(MAluno x)
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

        public void ExcluirAluno(MAluno x)
        {
            i = new PAluno();
            List<MAluno> excluir = i.Open();

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
