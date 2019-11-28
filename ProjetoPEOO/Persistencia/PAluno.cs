using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PAluno
    {
        private string arquivo = "Aluno.xml";
        public List<MAluno> Open()
        {
            List<MAluno> aluno;
            XmlSerializer x = new XmlSerializer(typeof(List<MAluno>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                aluno = (List<MAluno>)x.Deserialize(f);
            }
            catch
            {
                aluno = new List<MAluno>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return aluno;
        }
        public void Save(List<MAluno> aluno)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MAluno>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, aluno);
            f.Close();
        }
    }
}
