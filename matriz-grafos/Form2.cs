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
    public partial class Form2 : Form
    {
        private int Vertice;
        private int[,] matriz;

        public Form2(int[,] matriz, int Vertice)
        {
            this.matriz = matriz;
            this.Vertice = Vertice;
            InitializeComponent();
            AtualizaTreeView();
        }

        private void AtualizaTreeView()
        {
            tvGrafo.Nodes.Clear();

            for (int i = 0; i < Vertice; i++)
            {
                TreeNode tn = new TreeNode(String.Format("V{0}", i));

                for (int j = 0; j < Vertice; j++)
                {
                    if(matriz[i,j] == 1)
                    {
                        tn.Nodes.Add(String.Format("V{0}", j));
                    }
                }

                tvGrafo.Nodes.Add(tn);
            }

            tvGrafo.ExpandAll();
        }

    }
}
