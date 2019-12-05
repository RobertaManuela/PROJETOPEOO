using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negócio
{
    public class NDisciplina
    {
        private List<MDisciplina> a = new List<MDisciplina>();
        PDisciplina i;

        public void InserirDisciplina(MDisciplina x)
        {
            i = new PDisciplina();
            List<MDisciplina> a = i.Open();
            int id = 1;
            if (a.Count > 0) id = a.Max(y => y.IdDisciplina) + 1;
            x.IdDisciplina = id;
            a.Add(x);
            i.Save(a);
        }

        public List<MDisciplina> ListarDisciplina()
        {
            i = new PDisciplina();
            a = i.Open();
            return a;
        }

        public void ExcluirDisciplina(MDisciplina x)
        {

            i = new PDisciplina();
            List<MDisciplina> a = i.Open();
            foreach (MDisciplina j in a)
            {
                if (j.IdDisciplina == x.IdDisciplina)
                {
                    a.Remove(j);
                    break;
                }
            }
            i.Save(a);
        }
    }
}
