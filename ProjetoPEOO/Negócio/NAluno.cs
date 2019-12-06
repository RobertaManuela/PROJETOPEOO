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
            i = new PAluno();
            List<MAluno> a = i.Open();
            int id = 1;
            if (a.Count > 0) id = a.Max(y => y.Id) + 1;
            x.Id = id;
            x.Matricula = "2019101111" + x.Id.ToString();
            a.Add(x);
            i.Save(a);
        }

        public List<MAluno> ListarAluno()
        {
            i = new PAluno();
            return i.Open().OrderBy(a => a.Nome).ToList();
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
            List<MAluno> a = i.Open();
            foreach(MAluno j in a)
            {
                if (j.Matricula == x.Matricula)
                {
                    a.Remove(j);
                    break;
                }
            }
            i.Save(a);
        }
    }
}
