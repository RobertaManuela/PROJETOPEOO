using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MDisciplina
    {
        public string Nivel { get; set; }
        public int IdDisciplina { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nivel} |";
        }
    }
}
