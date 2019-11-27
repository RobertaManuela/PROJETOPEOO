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
    public class PProfessor
    {
        private string arquivo = "Professor.xml";
        public List<MProfessor> Open()
        {
            List<MProfessor> prof;
            XmlSerializer x = new XmlSerializer(typeof(List<MProfessor));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                prof = (List<MProfessor>)x.Deserialize(f);
            }
            catch
            {
                prof = new List<MProfessor>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return prof;
        }
        public void Save(List<MProfessor> prof)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MProfessor>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, prof);
            f.Close();
        }
    }
}
