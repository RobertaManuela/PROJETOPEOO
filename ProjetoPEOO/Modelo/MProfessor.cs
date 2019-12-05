using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MProfessor
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public DateTime Nascimento { get; set; }
        public string Senha { get; set; }
        public string Formacao { get; set; }
        public string Foto { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Email: {Email} | Nascimento: {Nascimento} | Matrícula: {Matricula} | Senha: {Senha} | Formação: {Formacao} |";
        }
    }


}
