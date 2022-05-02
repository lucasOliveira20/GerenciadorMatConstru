namespace TCC.Gerenciamento_de_Vendas
{
    partial class FormPagamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbDataCad = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mtbTroco = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbRecebido = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbForma);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 281);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbDataCad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.mtbTroco);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mtbTotal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mtbRecebido);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 212);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // mtbDataCad
            // 
            this.mtbDataCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDataCad.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataCad.Location = new System.Drawing.Point(180, 175);
            this.mtbDataCad.Mask = "00/00/0000 00:00";
            this.mtbDataCad.Name = "mtbDataCad";
            this.mtbDataCad.Size = new System.Drawing.Size(152, 30);
            this.mtbDataCad.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Data da venda:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(383, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 25);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Entrega?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mtbTroco
            // 
            this.mtbTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTroco.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTroco.Location = new System.Drawing.Point(180, 124);
            this.mtbTroco.Name = "mtbTroco";
            this.mtbTroco.ReadOnly = true;
            this.mtbTroco.Size = new System.Drawing.Size(152, 31);
            this.mtbTroco.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Troco:";
            // 
            // mtbTotal
            // 
            this.mtbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTotal.Location = new System.Drawing.Point(180, 19);
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.ReadOnly = true;
            this.mtbTotal.Size = new System.Drawing.Size(152, 31);
            this.mtbTotal.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor Total:";
            // 
            // mtbRecebido
            // 
            this.mtbRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbRecebido.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRecebido.Location = new System.Drawing.Point(180, 69);
            this.mtbRecebido.Name = "mtbRecebido";
            this.mtbRecebido.Size = new System.Drawing.Size(152, 31);
            this.mtbRecebido.TabIndex = 11;
            this.mtbRecebido.TextChanged += new System.EventHandler(this.mtbRecebido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Recebido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Forma de Pagamento:";
            // 
            // cbForma
            // 
            this.cbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbForma.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Location = new System.Drawing.Point(236, 24);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(260, 29);
            this.cbForma.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 53);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(389, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 53);
            this.button2.TabIndex = 23;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPagamento_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtbTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbRecebido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbForma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbDataCad;

    }
}