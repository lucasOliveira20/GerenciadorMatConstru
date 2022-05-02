namespace TCC.Gerenciamento_de_Cadastros
{
    partial class Fabricantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fabricantes));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolt = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.PictureBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbTodos);
            this.groupBox2.Controls.Add(this.rbMarca);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.rbNome);
            this.groupBox2.Controls.Add(this.rbCod);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 67);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Location = new System.Drawing.Point(482, 18);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(67, 21);
            this.rbMarca.TabIndex = 7;
            this.rbMarca.TabStop = true;
            this.rbMarca.Text = "Marca";
            this.rbMarca.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesquisar Fabricantes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecione o Método para a pesquisa:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(410, 18);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(66, 21);
            this.rbNome.TabIndex = 2;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Location = new System.Drawing.Point(328, 18);
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
            this.dataGridView1.Location = new System.Drawing.Point(8, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 348);
            this.dataGridView1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Voltar";
            this.label5.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "Alterar";
            this.label6.Click += new System.EventHandler(this.btnALT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Excluir";
            this.label7.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnVolt
            // 
            this.btnVolt.BackColor = System.Drawing.Color.Transparent;
            this.btnVolt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolt.Image = ((System.Drawing.Image)(resources.GetObject("btnVolt.Image")));
            this.btnVolt.Location = new System.Drawing.Point(492, 338);
            this.btnVolt.Name = "btnVolt";
            this.btnVolt.Size = new System.Drawing.Size(64, 88);
            this.btnVolt.TabIndex = 45;
            this.btnVolt.TabStop = false;
            this.btnVolt.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(494, 210);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(64, 91);
            this.btnAtualizar.TabIndex = 44;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnALT_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(494, 78);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(64, 92);
            this.btnDeletar.TabIndex = 43;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(259, 18);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(63, 21);
            this.rbTodos.TabIndex = 8;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // Fabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVolt);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fabricantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabricantes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnVolt;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnDeletar;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}