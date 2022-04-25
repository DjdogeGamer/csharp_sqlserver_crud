namespace csharp_sql_server_crud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CampoID = new System.Windows.Forms.TextBox();
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.CampoIdade = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.NovoBotao = new System.Windows.Forms.Button();
            this.EditarBotao = new System.Windows.Forms.Button();
            this.ExcluirBotao = new System.Windows.Forms.Button();
            this.ConsultarBotao = new System.Windows.Forms.Button();
            this.ExibirBotao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CampoID
            // 
            this.CampoID.Location = new System.Drawing.Point(122, 40);
            this.CampoID.Name = "CampoID";
            this.CampoID.Size = new System.Drawing.Size(602, 23);
            this.CampoID.TabIndex = 3;
            // 
            // CampoNome
            // 
            this.CampoNome.Location = new System.Drawing.Point(122, 76);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.Size = new System.Drawing.Size(602, 23);
            this.CampoNome.TabIndex = 4;
            // 
            // CampoIdade
            // 
            this.CampoIdade.Location = new System.Drawing.Point(122, 113);
            this.CampoIdade.Name = "CampoIdade";
            this.CampoIdade.Size = new System.Drawing.Size(602, 23);
            this.CampoIdade.TabIndex = 5;
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(122, 219);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 25;
            this.dgvDados.Size = new System.Drawing.Size(602, 190);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // NovoBotao
            // 
            this.NovoBotao.Location = new System.Drawing.Point(122, 166);
            this.NovoBotao.Name = "NovoBotao";
            this.NovoBotao.Size = new System.Drawing.Size(105, 23);
            this.NovoBotao.TabIndex = 7;
            this.NovoBotao.Text = "Novo";
            this.NovoBotao.UseVisualStyleBackColor = true;
            this.NovoBotao.Click += new System.EventHandler(this.NovoBotao_Click);
            // 
            // EditarBotao
            // 
            this.EditarBotao.Location = new System.Drawing.Point(248, 166);
            this.EditarBotao.Name = "EditarBotao";
            this.EditarBotao.Size = new System.Drawing.Size(105, 23);
            this.EditarBotao.TabIndex = 8;
            this.EditarBotao.Text = "Editar";
            this.EditarBotao.UseVisualStyleBackColor = true;
            this.EditarBotao.Click += new System.EventHandler(this.EditarBotao_Click);
            // 
            // ExcluirBotao
            // 
            this.ExcluirBotao.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.ExcluirBotao.ForeColor = System.Drawing.Color.Black;
            this.ExcluirBotao.Location = new System.Drawing.Point(619, 166);
            this.ExcluirBotao.Name = "ExcluirBotao";
            this.ExcluirBotao.Size = new System.Drawing.Size(105, 23);
            this.ExcluirBotao.TabIndex = 9;
            this.ExcluirBotao.Text = "Exlcuir";
            this.ExcluirBotao.UseVisualStyleBackColor = true;
            this.ExcluirBotao.Click += new System.EventHandler(this.ExcluirBotao_Click);
            // 
            // ConsultarBotao
            // 
            this.ConsultarBotao.Location = new System.Drawing.Point(368, 166);
            this.ConsultarBotao.Name = "ConsultarBotao";
            this.ConsultarBotao.Size = new System.Drawing.Size(105, 23);
            this.ConsultarBotao.TabIndex = 10;
            this.ConsultarBotao.Text = "Consultar";
            this.ConsultarBotao.UseVisualStyleBackColor = true;
            this.ConsultarBotao.Click += new System.EventHandler(this.ConsultarBotao_Click);
            // 
            // ExibirBotao
            // 
            this.ExibirBotao.Location = new System.Drawing.Point(494, 166);
            this.ExibirBotao.Name = "ExibirBotao";
            this.ExibirBotao.Size = new System.Drawing.Size(105, 23);
            this.ExibirBotao.TabIndex = 11;
            this.ExibirBotao.Text = "Exbir";
            this.ExibirBotao.UseVisualStyleBackColor = true;
            this.ExibirBotao.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExibirBotao);
            this.Controls.Add(this.ConsultarBotao);
            this.Controls.Add(this.ExcluirBotao);
            this.Controls.Add(this.EditarBotao);
            this.Controls.Add(this.NovoBotao);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.CampoIdade);
            this.Controls.Add(this.CampoNome);
            this.Controls.Add(this.CampoID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox CampoID;
        private TextBox CampoNome;
        private TextBox CampoIdade;
        private DataGridView dgvDados;
        private Button NovoBotao;
        private Button EditarBotao;
        private Button ExcluirBotao;
        private Button ConsultarBotao;
        private Button ExibirBotao;
    }
}