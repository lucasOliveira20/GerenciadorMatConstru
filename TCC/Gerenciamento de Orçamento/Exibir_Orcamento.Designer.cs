namespace TCC.Gerenciamento_de_Orçamento
{
    partial class Exibir_Orcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_Orcamento));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolt = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.PictureBox();
            this.btnADD = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnADD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 399);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnVolt
            // 
            this.btnVolt.BackColor = System.Drawing.Color.Transparent;
            this.btnVolt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolt.Image = ((System.Drawing.Image)(resources.GetObject("btnVolt.Image")));
            this.btnVolt.Location = new System.Drawing.Point(724, 320);
            this.btnVolt.Name = "btnVolt";
            this.btnVolt.Size = new System.Drawing.Size(64, 88);
            this.btnVolt.TabIndex = 48;
            this.btnVolt.TabStop = false;
            this.btnVolt.Click += new System.EventHandler(this.btnVolt_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(722, 162);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(64, 92);
            this.btnDeletar.TabIndex = 46;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Transparent;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.Location = new System.Drawing.Point(715, 12);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(80, 73);
            this.btnADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnADD.TabIndex = 49;
            this.btnADD.TabStop = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Adicionar";
            this.label1.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(726, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 69;
            this.label7.Text = "Excluir";
            this.label7.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Voltar";
            this.label2.Click += new System.EventHandler(this.btnVolt_Click);
            // 
            // Exibir_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnVolt);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exibir_Orcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir_Orcamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnADD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnVolt;
        private System.Windows.Forms.PictureBox btnDeletar;
        private System.Windows.Forms.PictureBox btnADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}