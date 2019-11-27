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
    public class PAdministrador
    {
        private string arquivo = "Adm.xml";
        public List<MAdministrador> Open()
        {
            List<MAdministrador> adm;
            XmlSerializer x = new XmlSerializer(typeof(List<MAdministrador));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                adm = (List<MAdministrador>)x.Deserialize(f);
            }
            catch
            {
                adm = new List<MAdministrador>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return adm;
        }
        public void Save(List<MAdministrador> adm)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MAdministrador>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, adm);
            f.Close();
        }
    }
}
