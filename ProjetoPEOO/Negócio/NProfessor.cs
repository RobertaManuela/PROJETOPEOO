using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negócio
{
    class NProfessor
    {
        private List<MProfessor> a = new List<MProfessor>();
        PProfessor i;

        public void InserirProfessor(MProfessor x)
        {
            a.Add(x);
        }

        public List<MProfessor> ListarProfessor()
        {
            i = new PProfessor();
            a = i.Open();
            return a;
        }

        public void AtualizarProfessor(MProfessor x)
        {
            i = new PProfessor();
            List<MProfessor> att = i.Open();

            for (int j = 0; j < att.Count; j++)
            {
                if (att[j].GetId() == x.GetId())
                {
                    att.RemoveAt(j);
                    break;
                }
            }
            att.Add(x);
            i.Save(att);
        }

        public void ExcluirProfessor(MProfessor x)
        {
            i = new PProfessor();
            List<MProfessor> excluir = i.Open();

            for (int j = 0; j < excluir.Count; j++)
            {
                if (excluir[j].Id == x.Id())
                {
                    excluir.RemoveAt(j);
                    break;
                }
            }
            i.Save(excluir);
        }
    }
}
