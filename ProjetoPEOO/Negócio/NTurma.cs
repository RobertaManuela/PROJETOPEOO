using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negócio
{
    public class NTurma
    {
        private List<MTurma> a = new List<MTurma>();
        PTurma i;

        public void InserirTurma(MTurma x)
        {
            i = new PTurma();
            List<MTurma> a = i.Open();
            int id = 1;
            if (a.Count > 0) id = a.Max(y => y.Id) + 1;
            x.Id= id;
            a.Add(x);
            i.Save(a);
        }

        public List<MTurma> ListarTurma()
        {
            i = new PTurma();
            a = i.Open();
            return a;
        }

        public void ExcluirTurma(MTurma x)
        {

            i = new PTurma();
            List<MTurma> a = i.Open();
            foreach (MTurma j in a)
            {
                if (j.Id == x.Id)
                {
                    a.Remove(j);
                    break;
                }
            }
            i.Save(a);
        }
    }
}
