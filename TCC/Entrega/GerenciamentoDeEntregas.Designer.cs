namespace TCC.Entrega
{
    partial class GerenciamentoDeEntregas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoDeEntregas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnVisualizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(722, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(113, 108);
            this.btnConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.TabStop = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(722, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 108);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(722, 368);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(113, 108);
            this.btnVisualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.TabStop = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmar";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.Location = new System.Drawing.Point(731, 225);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(96, 22);
            this.lblCancelar.TabIndex = 7;
            this.lblCancelar.Text = "Cancelar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(733, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Visualizar";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(807, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 37);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Deletar";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(722, 249);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(113, 108);
            this.btnDeletar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // GerenciamentoDeEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciamentoDeEntregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoDeEntregas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnConfirmar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnVisualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnDeletar;
    }
}