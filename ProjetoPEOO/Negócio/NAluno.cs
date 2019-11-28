using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negócio
{
    public class NAluno
    {
        private List<MAluno> a = new List<MAluno>();
        PAluno i;

        public void InserirAluno(MAluno x)
        {
            a = i.Open();
            a.Add(x);
            i.Save(a);

        }

        public List<MAluno> ListarAluno()
        {
            i = new PAluno();
            a = i.Open();
            return a;
        }

        public void AtualizarAluno(MAluno x)
        {
            i = new PAluno();
            List<MAluno> att = i.Open();

            for (int j = 0; j < att.Count; j++)
            {
                if (att[j].Id == x.Id)
                {
                    att.RemoveAt(j);
                    break;
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
                if (excluir[j].Id == x.Id)
                {
                    excluir.RemoveAt(j);
                    break;
                }
            }
            i.Save(excluir);
        }
    }
}
