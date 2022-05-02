namespace TCC.Gerenciamento_de_Cadastros
{
    partial class Funcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcoes));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolt = new System.Windows.Forms.PictureBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbTodos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.rbDesc);
            this.groupBox2.Controls.Add(this.rbCod);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 67);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesquisar Funções:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecione o Método para a pesquisa:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(431, 16);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(164, 21);
            this.rbDesc.TabIndex = 2;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "Descrição da Função";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Location = new System.Drawing.Point(349, 16);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(76, 21);
            this.rbCod.TabIndex = 1;
            this.rbCod.TabStop = true;
            this.rbCod.Text = "Código";
            this.rbCod.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(726, 336);
            this.dataGridView1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(742, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Alterar";
            this.label6.Click += new System.EventHandler(this.btnAlterarFuncao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(745, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Excluir";
            this.label7.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(742, 210);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(64, 91);
            this.btnAtualizar.TabIndex = 62;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAlterarFuncao_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(742, 85);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(64, 92);
            this.btnDeletar.TabIndex = 61;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Voltar";
            this.label5.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnVolt
            // 
            this.btnVolt.BackColor = System.Drawing.Color.Transparent;
            this.btnVolt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolt.Image = ((System.Drawing.Image)(resources.GetObject("btnVolt.Image")));
            this.btnVolt.Location = new System.Drawing.Point(742, 336);
            this.btnVolt.Name = "btnVolt";
            this.btnVolt.Size = new System.Drawing.Size(64, 88);
            this.btnVolt.TabIndex = 63;
            this.btnVolt.TabStop = false;
            this.btnVolt.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(280, 16);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(63, 21);
            this.rbTodos.TabIndex = 8;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // Funcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVolt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcoes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.RadioButton rbCod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnDeletar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnVolt;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}