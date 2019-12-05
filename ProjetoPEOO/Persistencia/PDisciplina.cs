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
    public class PDisciplina
    {
        private string arquivo = "Disciplina.xml";
        public List<MDisciplina> Open()
        {
            List<MDisciplina> discs;
            XmlSerializer x = new XmlSerializer(typeof(List<MDisciplina>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                discs = (List<MDisciplina>)x.Deserialize(f);
            }
            catch
            {
                discs = new List<MDisciplina>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return discs;
        }

        public void Save(List<MDisciplina> a)
        {
            throw new NotImplementedException();
        }

        public void Save(List<MAluno> discs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MDisciplina>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, discs);
            f.Close();
        }
    }
}
