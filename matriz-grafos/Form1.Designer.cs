namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMatriz = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGerarMatriz = new System.Windows.Forms.Button();
            this.txtNumVertice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxVerticeFinal = new System.Windows.Forms.ComboBox();
            this.cbxVerticeInicial = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxVerticeGrau = new System.Windows.Forms.ComboBox();
            this.btnGrauVertice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMatriz
            // 
            this.pnlMatriz.Location = new System.Drawing.Point(12, 81);
            this.pnlMatriz.Name = "pnlMatriz";
            this.pnlMatriz.Size = new System.Drawing.Size(1228, 569);
            this.pnlMatriz.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnGerarMatriz);
            this.groupBox1.Controls.Add(this.txtNumVertice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1228, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gerar Árvore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGerarMatriz
            // 
            this.btnGerarMatriz.Location = new System.Drawing.Point(363, 24);
            this.btnGerarMatriz.Name = "btnGerarMatriz";
            this.btnGerarMatriz.Size = new System.Drawing.Size(120, 23);
            this.btnGerarMatriz.TabIndex = 5;
            this.btnGerarMatriz.Text = "Gerar Matriz";
            this.btnGerarMatriz.UseVisualStyleBackColor = true;
            this.btnGerarMatriz.Click += new System.EventHandler(this.btnGerarMatriz_Click);
            // 
            // txtNumVertice
            // 
            this.txtNumVertice.Location = new System.Drawing.Point(257, 24);
            this.txtNumVertice.MaxLength = 2;
            this.txtNumVertice.Name = "txtNumVertice";
            this.txtNumVertice.Size = new System.Drawing.Size(100, 22);
            this.txtNumVertice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o número de vértices do grafo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cbxVerticeFinal);
            this.groupBox2.Controls.Add(this.cbxVerticeInicial);
            this.groupBox2.Location = new System.Drawing.Point(12, 656);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existe aresta entre os dois vértices?";
            // 
            // cbxVerticeFinal
            // 
            this.cbxVerticeFinal.FormattingEnabled = true;
            this.cbxVerticeFinal.Location = new System.Drawing.Point(139, 31);
            this.cbxVerticeFinal.Name = "cbxVerticeFinal";
            this.cbxVerticeFinal.Size = new System.Drawing.Size(121, 24);
            this.cbxVerticeFinal.TabIndex = 10;
            // 
            // cbxVerticeInicial
            // 
            this.cbxVerticeInicial.FormattingEnabled = true;
            this.cbxVerticeInicial.Location = new System.Drawing.Point(6, 31);
            this.cbxVerticeInicial.Name = "cbxVerticeInicial";
            this.cbxVerticeInicial.Size = new System.Drawing.Size(121, 24);
            this.cbxVerticeInicial.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGrauVertice);
            this.groupBox3.Controls.Add(this.cbxVerticeGrau);
            this.groupBox3.Location = new System.Drawing.Point(362, 656);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 76);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grau do vértice?";
            // 
            // cbxVerticeGrau
            // 
            this.cbxVerticeGrau.FormattingEnabled = true;
            this.cbxVerticeGrau.Location = new System.Drawing.Point(13, 30);
            this.cbxVerticeGrau.Name = "cbxVerticeGrau";
            this.cbxVerticeGrau.Size = new System.Drawing.Size(121, 24);
            this.cbxVerticeGrau.TabIndex = 11;
            // 
            // btnGrauVertice
            // 
            this.btnGrauVertice.Location = new System.Drawing.Point(139, 31);
            this.btnGrauVertice.Name = "btnGrauVertice";
            this.btnGrauVertice.Size = new System.Drawing.Size(53, 23);
            this.btnGrauVertice.TabIndex = 12;
            this.btnGrauVertice.Text = "?";
            this.btnGrauVertice.UseVisualStyleBackColor = true;
            this.btnGrauVertice.Click += new System.EventHandler(this.btnGrauVertice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 739);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlMatriz);
            this.Name = "Form1";
            this.Text = "Grafos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMatriz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerarMatriz;
        private System.Windows.Forms.TextBox txtNumVertice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxVerticeFinal;
        private System.Windows.Forms.ComboBox cbxVerticeInicial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGrauVertice;
        private System.Windows.Forms.ComboBox cbxVerticeGrau;
    }
}

