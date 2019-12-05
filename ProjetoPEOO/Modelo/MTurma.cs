using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MTurma
    {
        public string Semestre { get; set; }
        public int IdProfessor { get; set; }
        public int IdDisciplina { get; set; }
        public int IdTurma { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Semestre: {Semestre} | Professor: {IdProfessor} | Disciplina: {IdDisciplina} |";
        }
    }
}
