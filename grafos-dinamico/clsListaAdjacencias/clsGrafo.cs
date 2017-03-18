using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsListaAdjacencias
{
    public class clsGrafo
    {        
        private List<clsVertice> Vertices { get; }

        public clsGrafo()
        {
            this.Vertices = new List<clsVertice>();
        }

        public List<clsVertice> getVertices()
        {
            return Vertices;
        }

        public void setAddVertice(clsVertice v)
        {
            Vertices.Add(v);            
        }

        public void setDelVertice(clsVertice v)
        {
            Vertices.Remove(v);
        }
    }
}
