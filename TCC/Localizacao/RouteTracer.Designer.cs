namespace TCC.Localizacao
{
    partial class RouteTracer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteTracer));
            this.objMapa = new GMap.NET.WindowsForms.GMapControl();
            this.ZoomBar = new System.Windows.Forms.TrackBar();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblDescVeiculo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objMapa
            // 
            this.objMapa.Bearing = 0F;
            this.objMapa.CanDragMap = true;
            this.objMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.objMapa.GrayScaleMode = false;
            this.objMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.objMapa.LevelsKeepInMemmory = 5;
            this.objMapa.Location = new System.Drawing.Point(54, 149);
            this.objMapa.MarkersEnabled = true;
            this.objMapa.MaxZoom = 2;
            this.objMapa.MinZoom = 2;
            this.objMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.objMapa.Name = "objMapa";
            this.objMapa.NegativeMode = false;
            this.objMapa.PolygonsEnabled = true;
            this.objMapa.RetryLoadTile = 0;
            this.objMapa.RoutesEnabled = true;
            this.objMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.objMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.objMapa.ShowTileGridLines = false;
            this.objMapa.Size = new System.Drawing.Size(924, 476);
            this.objMapa.TabIndex = 0;
            this.objMapa.Zoom = 0D;
            // 
            // ZoomBar
            // 
            this.ZoomBar.Location = new System.Drawing.Point(12, 142);
            this.ZoomBar.Name = "ZoomBar";
            this.ZoomBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ZoomBar.Size = new System.Drawing.Size(45, 483);
            this.ZoomBar.TabIndex = 1;
            this.ZoomBar.ValueChanged += new System.EventHandler(this.ZoomBar_ValueChanged);
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
            this.btnFechar.Location = new System.Drawing.Point(949, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 37);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lblDescVeiculo);
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 131);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtEndereco.Location = new System.Drawing.Point(186, 56);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(497, 27);
            this.txtEndereco.TabIndex = 10;
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblDescVeiculo
            // 
            this.lblDescVeiculo.AutoSize = true;
            this.lblDescVeiculo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescVeiculo.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDescVeiculo.Location = new System.Drawing.Point(689, 98);
            this.lblDescVeiculo.Name = "lblDescVeiculo";
            this.lblDescVeiculo.Size = new System.Drawing.Size(0, 22);
            this.lblDescVeiculo.TabIndex = 9;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPlaca.Location = new System.Drawing.Point(513, 98);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(0, 22);
            this.lblPlaca.TabIndex = 8;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblData.Location = new System.Drawing.Point(225, 98);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 22);
            this.lblData.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNome.Location = new System.Drawing.Point(158, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 22);
            this.lblNome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Placa do Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Prevista de entrega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço do Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente:";
            // 
            // RouteTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 639);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.ZoomBar);
            this.Controls.Add(this.objMapa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RouteTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RouteTracer";
            this.Load += new System.EventHandler(this.RouteTracer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl objMapa;
        private System.Windows.Forms.TrackBar ZoomBar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescVeiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEndereco;
    }
}