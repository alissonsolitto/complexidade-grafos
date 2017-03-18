using clsListaAdjacencias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmGrafo : Form
    {
        private PictureBox pictureBox1 = new PictureBox();

        public clsGrafo clsGrafo { get; set; }        

        public frmGrafo(clsGrafo clsGrafo)
        {
            this.clsGrafo = clsGrafo;
            InitializeComponent();
        }       

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
                        
            this.Controls.Add(pictureBox1);
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            int numVertice = 0;
            int left    = -200; //Para começar da posição zero.
            int top     = 0;
            int top2    = 100;
            int largura = 50;
            int altura  = 50;
            int divLargura = (largura / 2);
            int divAltura = (altura / 2);

            Graphics g = e.Graphics;            

            //Desenhando as vértices
            foreach (clsVertice vertice in clsGrafo.getVertices())
            {
                vertice.Left = left += 200;
                vertice.Top = numVertice % 2 == 0 ? top : top2;
                
                SolidBrush sb = new SolidBrush(Color.FromArgb(vertice.color.red, vertice.color.green, vertice.color.blue));                
                g.FillEllipse(sb, vertice.Left, vertice.Top, largura, altura);
                
                numVertice++;

                if (numVertice >= 4)
                {
                    top        += 200;
                    top2       += 200;
                    left       = -200;
                    numVertice = 0;
                }
            }

            //Desenhando as arestas
            foreach (clsVertice vertice in clsGrafo.getVertices())
            {                
                foreach (clsVertice aresta in vertice.getArestas())
                {
                    Pen pen = new Pen(Color.FromArgb(vertice.color.red, vertice.color.green, vertice.color.blue));
                    pen.Width = 3;

                    g.DrawLine(pen, vertice.Left + divLargura, vertice.Top + divAltura, aresta.Left + divLargura, aresta.Top + divAltura);
                    g.DrawString(aresta.Nome, new Font("Arial", 10), System.Drawing.Brushes.White, aresta.Left + 5, aresta.Top + 15);                    
                }

                g.DrawString(vertice.Nome, new Font("Arial", 10), System.Drawing.Brushes.White, vertice.Left + 5, vertice.Top + 15);
            }
        }
    }
}
