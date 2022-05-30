using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionFramework
{
    public class RevisionDiaria
    {
        public String Nombre_del_Equipo { get; set; }


        public RevisionDiaria() { }

        public RevisionDiaria(String pNombre)
        {
            this.Nombre_del_Equipo = pNombre;
        }
    }
}
