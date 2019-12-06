﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negócio
    {
        public class NProfessor
        {
            private List<MProfessor> a = new List<MProfessor>();
            PProfessor i;

            public void InserirProfessor(MProfessor x)
            {
                i = new PProfessor();
                List<MProfessor> a = i.Open();
                int id = 1;
                if (a.Count > 0) id = a.Max(y => y.Id) + 1;
                x.Id = id;
                x.Matricula = "20191111" + x.Id.ToString();
                a.Add(x);
                i.Save(a);

            }

            public List<MProfessor> ListarProfessor()
            {
                i = new PProfessor();
                return i.Open().OrderBy(a => a.Nome).ToList();
        }

            public void AtualizarProfessor(MProfessor x)
            {
                i = new PProfessor();
                List<MProfessor> att = i.Open();
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

            public void ExcluirProfessor(MProfessor x)
            {

                i = new PProfessor();
                List<MProfessor> a = i.Open();
                foreach (MProfessor j in a)
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

   