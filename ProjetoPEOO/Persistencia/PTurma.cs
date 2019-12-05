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
    public class PTurma
    {
        private string arquivo = "Turma.xml";
        public List<MTurma> Open()
        {
            List<MTurma> turma;
            XmlSerializer x = new XmlSerializer(typeof(List<MTurma>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                turma = (List<MTurma>)x.Deserialize(f);
            }
            catch
            {
                turma = new List<MTurma>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return turma;
        }
        public void Save(List<MTurma> turma)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MTurma>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, turma);
            f.Close();
        }
    }
}
