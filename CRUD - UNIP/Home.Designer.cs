namespace CRUD___UNIP
{
    partial class Home
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
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txb_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.txb_logradouro = new System.Windows.Forms.TextBox();
            this.txb_telefone = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txb_numero = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txb_cep = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txb_bairro = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txb_cidade = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txb_estado = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.txb_pesquisa = new System.Windows.Forms.TextBox();
            this.txb_editar = new System.Windows.Forms.TextBox();
            this.txb_excluir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(124, 19);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(407, 20);
            this.txb_Nome.TabIndex = 0;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AccessibleName = "";
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(12, 20);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(106, 16);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "NOME COMPLETO:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(456, 158);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 20);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txb_cpf
            // 
            this.txb_cpf.Location = new System.Drawing.Point(273, 158);
            this.txb_cpf.Name = "txb_cpf";
            this.txb_cpf.Size = new System.Drawing.Size(172, 20);
            this.txb_cpf.TabIndex = 7;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(235, 159);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(33, 16);
            this.lbl_cpf.TabIndex = 8;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(12, 159);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(68, 16);
            this.lbl_telefone.TabIndex = 10;
            this.lbl_telefone.Text = "TELEFONE:";
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logradouro.Location = new System.Drawing.Point(12, 54);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(89, 16);
            this.lbl_logradouro.TabIndex = 12;
            this.lbl_logradouro.Text = "LOGRADOURO:";
            // 
            // txb_logradouro
            // 
            this.txb_logradouro.Location = new System.Drawing.Point(107, 53);
            this.txb_logradouro.Name = "txb_logradouro";
            this.txb_logradouro.Size = new System.Drawing.Size(424, 20);
            this.txb_logradouro.TabIndex = 11;
            // 
            // txb_telefone
            // 
            this.txb_telefone.Location = new System.Drawing.Point(86, 158);
            this.txb_telefone.Name = "txb_telefone";
            this.txb_telefone.Size = new System.Drawing.Size(143, 20);
            this.txb_telefone.TabIndex = 15;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(12, 89);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(59, 16);
            this.lbl_numero.TabIndex = 17;
            this.lbl_numero.Text = "NUMERO:";
            // 
            // txb_numero
            // 
            this.txb_numero.Location = new System.Drawing.Point(77, 88);
            this.txb_numero.Name = "txb_numero";
            this.txb_numero.Size = new System.Drawing.Size(60, 20);
            this.txb_numero.TabIndex = 16;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(145, 90);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(33, 16);
            this.lbl_cep.TabIndex = 19;
            this.lbl_cep.Text = "CEP:";
            // 
            // txb_cep
            // 
            this.txb_cep.Location = new System.Drawing.Point(184, 88);
            this.txb_cep.Name = "txb_cep";
            this.txb_cep.Size = new System.Drawing.Size(121, 20);
            this.txb_cep.TabIndex = 18;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(315, 90);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(54, 16);
            this.lbl_bairro.TabIndex = 21;
            this.lbl_bairro.Text = "BAIRRO:";
            // 
            // txb_bairro
            // 
            this.txb_bairro.Location = new System.Drawing.Point(375, 88);
            this.txb_bairro.Name = "txb_bairro";
            this.txb_bairro.Size = new System.Drawing.Size(156, 20);
            this.txb_bairro.TabIndex = 20;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(12, 123);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(53, 16);
            this.lbl_cidade.TabIndex = 23;
            this.lbl_cidade.Text = "CIDADE:";
            // 
            // txb_cidade
            // 
            this.txb_cidade.Location = new System.Drawing.Point(71, 122);
            this.txb_cidade.Name = "txb_cidade";
            this.txb_cidade.Size = new System.Drawing.Size(220, 20);
            this.txb_cidade.TabIndex = 22;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(297, 124);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(55, 16);
            this.lbl_estado.TabIndex = 25;
            this.lbl_estado.Text = "ESTADO:";
            // 
            // txb_estado
            // 
            this.txb_estado.Location = new System.Drawing.Point(358, 123);
            this.txb_estado.Name = "txb_estado";
            this.txb_estado.Size = new System.Drawing.Size(173, 20);
            this.txb_estado.TabIndex = 24;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(15, 200);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(90, 29);
            this.btn_editar.TabIndex = 26;
            this.btn_editar.Text = "Editar por id:";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(183, 200);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(94, 29);
            this.btn_excluir.TabIndex = 27;
            this.btn_excluir.Text = "Excluir por id:";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(351, 200);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(107, 29);
            this.btn_pesquisa.TabIndex = 6;
            this.btn_pesquisa.Text = "Pesquisar por id:";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // txb_pesquisa
            // 
            this.txb_pesquisa.Location = new System.Drawing.Point(464, 205);
            this.txb_pesquisa.Name = "txb_pesquisa";
            this.txb_pesquisa.Size = new System.Drawing.Size(67, 20);
            this.txb_pesquisa.TabIndex = 13;
            // 
            // txb_editar
            // 
            this.txb_editar.Location = new System.Drawing.Point(111, 205);
            this.txb_editar.Name = "txb_editar";
            this.txb_editar.Size = new System.Drawing.Size(67, 20);
            this.txb_editar.TabIndex = 28;
            // 
            // txb_excluir
            // 
            this.txb_excluir.Location = new System.Drawing.Point(283, 205);
            this.txb_excluir.Name = "txb_excluir";
            this.txb_excluir.Size = new System.Drawing.Size(62, 20);
            this.txb_excluir.TabIndex = 29;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 249);
            this.Controls.Add(this.txb_excluir);
            this.Controls.Add(this.txb_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txb_estado);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txb_cidade);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txb_bairro);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txb_cep);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txb_numero);
            this.Controls.Add(this.txb_telefone);
            this.Controls.Add(this.txb_pesquisa);
            this.Controls.Add(this.lbl_logradouro);
            this.Controls.Add(this.txb_logradouro);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txb_cpf);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txb_Nome);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txb_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_logradouro;
        private System.Windows.Forms.TextBox txb_logradouro;
        private System.Windows.Forms.TextBox txb_telefone;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txb_numero;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txb_cep;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txb_bairro;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txb_cidade;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txb_estado;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.TextBox txb_pesquisa;
        private System.Windows.Forms.TextBox txb_editar;
        private System.Windows.Forms.TextBox txb_excluir;
    }
}

