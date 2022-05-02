namespace TCC.Estoque
{
    partial class Cadastro_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Estoque));
            this.cbID_Prod = new System.Windows.Forms.ComboBox();
            this.cbID_loc = new System.Windows.Forms.ComboBox();
            this.cbID_forn = new System.Windows.Forms.ComboBox();
            this.mtbDataCad = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbID_Prod
            // 
            this.cbID_Prod.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbID_Prod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbID_Prod.FormattingEnabled = true;
            this.cbID_Prod.Location = new System.Drawing.Point(10, 42);
            this.cbID_Prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbID_Prod.Name = "cbID_Prod";
            this.cbID_Prod.Size = new System.Drawing.Size(195, 25);
            this.cbID_Prod.TabIndex = 79;
            // 
            // cbID_loc
            // 
            this.cbID_loc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbID_loc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbID_loc.FormattingEnabled = true;
            this.cbID_loc.Location = new System.Drawing.Point(232, 42);
            this.cbID_loc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbID_loc.Name = "cbID_loc";
            this.cbID_loc.Size = new System.Drawing.Size(210, 25);
            this.cbID_loc.TabIndex = 80;
            // 
            // cbID_forn
            // 
            this.cbID_forn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbID_forn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbID_forn.FormattingEnabled = true;
            this.cbID_forn.Location = new System.Drawing.Point(7, 124);
            this.cbID_forn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbID_forn.Name = "cbID_forn";
            this.cbID_forn.Size = new System.Drawing.Size(198, 25);
            this.cbID_forn.TabIndex = 81;
            // 
            // mtbDataCad
            // 
            this.mtbDataCad.Location = new System.Drawing.Point(461, 124);
            this.mtbDataCad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbDataCad.Mask = "00/00/0000 90:00";
            this.mtbDataCad.Name = "mtbDataCad";
            this.mtbDataCad.Size = new System.Drawing.Size(110, 22);
            this.mtbDataCad.TabIndex = 85;
            // 
            // txtQuantProd
            // 
            this.txtQuantProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantProd.Location = new System.Drawing.Point(415, 190);
            this.txtQuantProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantProd.Name = "txtQuantProd";
            this.txtQuantProd.Size = new System.Drawing.Size(156, 22);
            this.txtQuantProd.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Selecione a Localização do Produto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 87;
            this.label2.Text = "Selecione o Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Selecione o Fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Data de Cadastramento do Estoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Digite a Quantidade de Produtos a serem adicionados ao estoque:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQuantProd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtbDataCad);
            this.groupBox1.Controls.Add(this.cbID_forn);
            this.groupBox1.Controls.Add(this.cbID_loc);
            this.groupBox1.Controls.Add(this.cbID_Prod);
            this.groupBox1.Location = new System.Drawing.Point(7, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(586, 229);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 95;
            this.label7.Text = "Salvar";
            this.label7.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(529, 236);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(64, 64);
            this.btnDeletar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDeletar.TabIndex = 94;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 97;
            this.label6.Text = "Cancelar";
            this.label6.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Cadastro_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 332);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cadastro_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Estoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbID_Prod;
        private System.Windows.Forms.ComboBox cbID_loc;
        private System.Windows.Forms.ComboBox cbID_forn;
        private System.Windows.Forms.MaskedTextBox mtbDataCad;
        private System.Windows.Forms.TextBox txtQuantProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnDeletar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}