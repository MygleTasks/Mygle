namespace Mygle.Grafico
{
    partial class TelaGerenteResumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerenteResumo));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbResumo = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btDetalhe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCategorias = new System.Windows.Forms.Button();
            this.lbValorVendido = new System.Windows.Forms.Label();
            this.graGerenteMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graGerenteDia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btMeta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteDia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(626, 781);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(324, 298);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(526, 719);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 46);
            this.label2.TabIndex = 51;
            this.label2.Text = "Meta de Venda Mensal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(526, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 46);
            this.label1.TabIndex = 50;
            this.label1.Text = "Meta de Venda Diária";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(626, 350);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 298);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // lbResumo
            // 
            this.lbResumo.AutoSize = true;
            this.lbResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbResumo.Location = new System.Drawing.Point(526, 90);
            this.lbResumo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbResumo.Name = "lbResumo";
            this.lbResumo.Size = new System.Drawing.Size(451, 63);
            this.lbResumo.TabIndex = 46;
            this.lbResumo.Text = "Resumo Gerente";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(16, 694);
            this.btLogout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(240, 77);
            this.btLogout.TabIndex = 5;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btUsuarios
            // 
            this.btUsuarios.Location = new System.Drawing.Point(16, 427);
            this.btUsuarios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(240, 77);
            this.btUsuarios.TabIndex = 2;
            this.btUsuarios.Text = "Usuários";
            this.btUsuarios.UseVisualStyleBackColor = true;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btDetalhe
            // 
            this.btDetalhe.BackColor = System.Drawing.Color.Gainsboro;
            this.btDetalhe.Location = new System.Drawing.Point(16, 338);
            this.btDetalhe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btDetalhe.Name = "btDetalhe";
            this.btDetalhe.Size = new System.Drawing.Size(240, 77);
            this.btDetalhe.TabIndex = 1;
            this.btDetalhe.Text = "Detalhe";
            this.btDetalhe.UseVisualStyleBackColor = false;
            this.btDetalhe.Click += new System.EventHandler(this.btDetalhe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 192);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btCategorias
            // 
            this.btCategorias.Location = new System.Drawing.Point(16, 515);
            this.btCategorias.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(240, 77);
            this.btCategorias.TabIndex = 3;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = true;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // lbValorVendido
            // 
            this.lbValorVendido.AutoSize = true;
            this.lbValorVendido.Location = new System.Drawing.Point(1290, 788);
            this.lbValorVendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorVendido.Name = "lbValorVendido";
            this.lbValorVendido.Size = new System.Drawing.Size(0, 25);
            this.lbValorVendido.TabIndex = 60;
            this.lbValorVendido.Click += new System.EventHandler(this.lbValorVendido_Click);
            // 
            // graGerenteMes
            // 
            chartArea1.Name = "ChartArea1";
            this.graGerenteMes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graGerenteMes.Legends.Add(legend1);
            this.graGerenteMes.Location = new System.Drawing.Point(526, 781);
            this.graGerenteMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graGerenteMes.Name = "graGerenteMes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Vendas";
            this.graGerenteMes.Series.Add(series1);
            this.graGerenteMes.Size = new System.Drawing.Size(540, 315);
            this.graGerenteMes.TabIndex = 61;
            this.graGerenteMes.Text = "chart1";
            // 
            // graGerenteDia
            // 
            chartArea2.Name = "ChartArea1";
            this.graGerenteDia.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graGerenteDia.Legends.Add(legend2);
            this.graGerenteDia.Location = new System.Drawing.Point(526, 350);
            this.graGerenteDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graGerenteDia.Name = "graGerenteDia";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "VendasDia";
            this.graGerenteDia.Series.Add(series2);
            this.graGerenteDia.Size = new System.Drawing.Size(540, 315);
            this.graGerenteDia.TabIndex = 62;
            this.graGerenteDia.Text = "chart1";
            this.graGerenteDia.Click += new System.EventHandler(this.graGerenteDia_Click);
            // 
            // btMeta
            // 
            this.btMeta.Location = new System.Drawing.Point(16, 606);
            this.btMeta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btMeta.Name = "btMeta";
            this.btMeta.Size = new System.Drawing.Size(240, 77);
            this.btMeta.TabIndex = 4;
            this.btMeta.Text = "Meta";
            this.btMeta.UseVisualStyleBackColor = true;
            this.btMeta.Click += new System.EventHandler(this.btMeta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1004, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Vendido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1002, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Restante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1004, 796);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Vendido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1004, 825);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 67;
            this.label6.Text = "Restante";
            // 
            // TelaGerenteResumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 1223);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMeta);
            this.Controls.Add(this.graGerenteDia);
            this.Controls.Add(this.graGerenteMes);
            this.Controls.Add(this.lbValorVendido);
            this.Controls.Add(this.btCategorias);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbResumo);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btUsuarios);
            this.Controls.Add(this.btDetalhe);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TelaGerenteResumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaResumoGerente";
            this.Load += new System.EventHandler(this.TelaGerenteResumo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaGerenteResumo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbResumo;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Button btDetalhe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCategorias;
        private System.Windows.Forms.Label lbValorVendido;
        private System.Windows.Forms.DataVisualization.Charting.Chart graGerenteMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart graGerenteDia;
        private System.Windows.Forms.Button btMeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}