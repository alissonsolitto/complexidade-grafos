using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsListaAdjacencias
{
    public class clsVertice : IEquatable<clsVertice>
    {
        [Serializable]
        public struct VColor
        {
            public int red;
            public int green;
            public int blue;
        }

        public String Nome { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        private Random randon { get; set; }

        public VColor color;

        private List<clsVertice> Arestas { get; }
        
        public clsVertice(String Nome)
        {
            this.Nome    = Nome;
            this.Left    = 0;
            this.Top     = 0;

            this.Arestas = new List<clsVertice>();
            this.randon  = new Random();
            this.color   = new VColor();

            this.setCor();           
        }

        private void setCor()
        {            
            color.red   = randon.Next(0, 150);
            color.green = randon.Next(0, 150);
            color.blue  = randon.Next(0, 150);
        }

        public void setAddAresta(clsVertice v)
        {
            Arestas.Add(v);
        }

        public void setDelAresta(clsVertice v)
        {
            Arestas.Remove(v);
        }

        public List<clsVertice> getArestas()
        {
            return Arestas;
        }

        public override String ToString()
        {
            return this.Nome;
        }

        public bool Equals(clsVertice other)
        {
            if (other == null) return false;
            return (this.Nome.Equals(other.Nome));
        }
    }
}
