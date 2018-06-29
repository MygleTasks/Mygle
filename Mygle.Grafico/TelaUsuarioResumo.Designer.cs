namespace Mygle.Grafico
{
    partial class TelaUsuarioResumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUsuarioResumo));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbResumo = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btCadastrarVenda = new System.Windows.Forms.Button();
            this.btDetalhe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbComissao = new System.Windows.Forms.Label();
            this.graUsuarioDia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graUsuarioMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graUsuarioDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graUsuarioMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbResumo
            // 
            this.lbResumo.AutoSize = true;
            this.lbResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResumo.Location = new System.Drawing.Point(263, 47);
            this.lbResumo.Name = "lbResumo";
            this.lbResumo.Size = new System.Drawing.Size(230, 31);
            this.lbResumo.TabIndex = 27;
            this.lbResumo.Text = "Resumo Usuário";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(8, 268);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(120, 40);
            this.btLogout.TabIndex = 26;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btCadastrarVenda
            // 
            this.btCadastrarVenda.Location = new System.Drawing.Point(8, 176);
            this.btCadastrarVenda.Name = "btCadastrarVenda";
            this.btCadastrarVenda.Size = new System.Drawing.Size(120, 40);
            this.btCadastrarVenda.TabIndex = 1;
            this.btCadastrarVenda.Text = "Cadastrar Venda";
            this.btCadastrarVenda.UseVisualStyleBackColor = true;
            this.btCadastrarVenda.Click += new System.EventHandler(this.btCadastrarVenda_Click);
            // 
            // btDetalhe
            // 
            this.btDetalhe.Location = new System.Drawing.Point(8, 222);
            this.btDetalhe.Name = "btDetalhe";
            this.btDetalhe.Size = new System.Drawing.Size(120, 40);
            this.btDetalhe.TabIndex = 3;
            this.btDetalhe.Text = "Detalhe";
            this.btDetalhe.UseVisualStyleBackColor = true;
            this.btDetalhe.Click += new System.EventHandler(this.btDetalhe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Total de Comissão: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(263, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Meta de Venda Mensal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(263, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Meta de Venda Diária";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbValorTotal.Location = new System.Drawing.Point(464, 648);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(0, 31);
            this.lbValorTotal.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 100);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // lbComissao
            // 
            this.lbComissao.AutoSize = true;
            this.lbComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComissao.ForeColor = System.Drawing.Color.Black;
            this.lbComissao.Location = new System.Drawing.Point(490, 590);
            this.lbComissao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComissao.Name = "lbComissao";
            this.lbComissao.Size = new System.Drawing.Size(0, 24);
            this.lbComissao.TabIndex = 70;
            // 
            // graUsuarioDia
            // 
            chartArea9.Name = "ChartArea1";
            this.graUsuarioDia.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.graUsuarioDia.Legends.Add(legend9);
            this.graUsuarioDia.Location = new System.Drawing.Point(263, 182);
            this.graUsuarioDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graUsuarioDia.Name = "graUsuarioDia";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "VendasDia";
            this.graUsuarioDia.Series.Add(series9);
            this.graUsuarioDia.Size = new System.Drawing.Size(270, 164);
            this.graUsuarioDia.TabIndex = 71;
            this.graUsuarioDia.Text = "chart1";
            // 
            // graUsuarioMes
            // 
            chartArea10.Name = "ChartArea1";
            this.graUsuarioMes.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.graUsuarioMes.Legends.Add(legend10);
            this.graUsuarioMes.Location = new System.Drawing.Point(263, 406);
            this.graUsuarioMes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graUsuarioMes.Name = "graUsuarioMes";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.IsValueShownAsLabel = true;
            series10.Legend = "Legend1";
            series10.Name = "VendasMes";
            this.graUsuarioMes.Series.Add(series10);
            this.graUsuarioMes.Size = new System.Drawing.Size(270, 164);
            this.graUsuarioMes.TabIndex = 72;
            this.graUsuarioMes.Text = "graGerenteMes";
            // 
            // TelaUsuarioResumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 636);
            this.Controls.Add(this.graUsuarioMes);
            this.Controls.Add(this.graUsuarioDia);
            this.Controls.Add(this.lbComissao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbResumo);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btCadastrarVenda);
            this.Controls.Add(this.btDetalhe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TelaUsuarioResumo";
            this.Text = "TelaResumoUsuario";
            this.Load += new System.EventHandler(this.TelaUsuarioResumo_Load);
            this.Shown += new System.EventHandler(this.TelaUsuarioResumo_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaUsuarioResumo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graUsuarioDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graUsuarioMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbResumo;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btCadastrarVenda;
        private System.Windows.Forms.Button btDetalhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbComissao;
        private System.Windows.Forms.DataVisualization.Charting.Chart graUsuarioDia;
        private System.Windows.Forms.DataVisualization.Charting.Chart graUsuarioMes;
    }
}