using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MAluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public DateTime Nascimento { get; set; }
        public string Senha { get; set; }
        public int IdTurma { get; set; }
        public int Id { get; set; }
    }
}
