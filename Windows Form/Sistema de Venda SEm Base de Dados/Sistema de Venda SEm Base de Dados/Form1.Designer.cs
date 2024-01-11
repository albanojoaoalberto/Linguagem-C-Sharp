namespace Sistema_de_Venda_SEm_Base_de_Dados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbProdu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUm_Quant = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.RNao = new System.Windows.Forms.RadioButton();
            this.RSim = new System.Windows.Forms.RadioButton();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Desconto = new System.Windows.Forms.Label();
            this.lbl_quant = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_desig = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUm_Quant)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtId.Location = new System.Drawing.Point(22, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(328, 25);
            this.txtId.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtCliente.Location = new System.Drawing.Point(22, 102);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(328, 25);
            this.txtCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº do Clinte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // CbProdu
            // 
            this.CbProdu.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.CbProdu.FormattingEnabled = true;
            this.CbProdu.Items.AddRange(new object[] {
            "Bolacha Água e Sal",
            "Bolacha Hipopó",
            "Bolacha Maria",
            "Bolacha Maria",
            "Bolacha Girabola",
            "Speed Bidon",
            "Speed Lata"});
            this.CbProdu.Location = new System.Drawing.Point(22, 165);
            this.CbProdu.Name = "CbProdu";
            this.CbProdu.Size = new System.Drawing.Size(325, 28);
            this.CbProdu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designação";
            // 
            // NUm_Quant
            // 
            this.NUm_Quant.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.NUm_Quant.Location = new System.Drawing.Point(22, 224);
            this.NUm_Quant.Name = "NUm_Quant";
            this.NUm_Quant.Size = new System.Drawing.Size(328, 25);
            this.NUm_Quant.TabIndex = 4;
            this.NUm_Quant.ValueChanged += new System.EventHandler(this.NUm_Quant_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.lblDes);
            this.groupBox1.Controls.Add(this.RNao);
            this.groupBox1.Controls.Add(this.RSim);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(22, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bloco de Descontos";
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Location = new System.Drawing.Point(6, 64);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(312, 25);
            this.txtDesconto.TabIndex = 2;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(5, 97);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(321, 20);
            this.lblDes.TabIndex = 1;
            this.lblDes.Text = "................................................................................." +
    ".......................";
            // 
            // RNao
            // 
            this.RNao.AutoSize = true;
            this.RNao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RNao.Location = new System.Drawing.Point(70, 30);
            this.RNao.Name = "RNao";
            this.RNao.Size = new System.Drawing.Size(50, 24);
            this.RNao.TabIndex = 0;
            this.RNao.TabStop = true;
            this.RNao.Text = "Não";
            this.RNao.UseVisualStyleBackColor = true;
            this.RNao.CheckedChanged += new System.EventHandler(this.RNao_CheckedChanged);
            // 
            // RSim
            // 
            this.RSim.AutoSize = true;
            this.RSim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSim.Location = new System.Drawing.Point(6, 30);
            this.RSim.Name = "RSim";
            this.RSim.Size = new System.Drawing.Size(49, 24);
            this.RSim.TabIndex = 0;
            this.RSim.TabStop = true;
            this.RSim.Text = "Sim";
            this.RSim.UseVisualStyleBackColor = true;
            this.RSim.CheckedChanged += new System.EventHandler(this.RSim_CheckedChanged);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Location = new System.Drawing.Point(22, 410);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 42);
            this.btn_Novo.TabIndex = 6;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.Location = new System.Drawing.Point(102, 410);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(122, 42);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "Registrar";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_total);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbl_preco);
            this.groupBox2.Controls.Add(this.lbl_Desconto);
            this.groupBox2.Controls.Add(this.lbl_quant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_Id);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbl_Cliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_desig);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(368, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 442);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "FACTURA";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(165, 382);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 37);
            this.lbl_total.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 37);
            this.label12.TabIndex = 2;
            this.label12.Text = "TOTAL :";
            // 
            // lbl_Desconto
            // 
            this.lbl_Desconto.AutoSize = true;
            this.lbl_Desconto.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lbl_Desconto.Location = new System.Drawing.Point(105, 297);
            this.lbl_Desconto.Name = "lbl_Desconto";
            this.lbl_Desconto.Size = new System.Drawing.Size(0, 20);
            this.lbl_Desconto.TabIndex = 2;
            // 
            // lbl_quant
            // 
            this.lbl_quant.AutoSize = true;
            this.lbl_quant.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lbl_quant.Location = new System.Drawing.Point(105, 214);
            this.lbl_quant.Name = "lbl_quant";
            this.lbl_quant.Size = new System.Drawing.Size(0, 20);
            this.lbl_quant.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label11.Location = new System.Drawing.Point(21, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Desconto :";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lbl_Id.Location = new System.Drawing.Point(105, 84);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 20);
            this.lbl_Id.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label10.Location = new System.Drawing.Point(21, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Quantidade :";
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lbl_Cliente.Location = new System.Drawing.Point(105, 130);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(0, 20);
            this.lbl_Cliente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label7.Location = new System.Drawing.Point(21, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nº do Clinte :";
            // 
            // lbl_desig
            // 
            this.lbl_desig.AutoSize = true;
            this.lbl_desig.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lbl_desig.Location = new System.Drawing.Point(103, 174);
            this.lbl_desig.Name = "lbl_desig";
            this.lbl_desig.Size = new System.Drawing.Size(0, 20);
            this.lbl_desig.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label8.Location = new System.Drawing.Point(21, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cliente :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label9.Location = new System.Drawing.Point(19, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Designação :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label5.Location = new System.Drawing.Point(21, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Preço :";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lbl_preco.Location = new System.Drawing.Point(105, 253);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(0, 20);
            this.lbl_preco.TabIndex = 2;
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Location = new System.Drawing.Point(229, 410);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 42);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(818, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NUm_Quant);
            this.Controls.Add(this.CbProdu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sisitema de Vendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUm_Quant)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbProdu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUm_Quant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RNao;
        private System.Windows.Forms.RadioButton RSim;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Desconto;
        private System.Windows.Forms.Label lbl_quant;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_desig;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_update;
    }
}

