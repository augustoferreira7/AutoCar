﻿namespace AutoCar
{
    partial class titulo
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
            this.tituloPr = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloPr
            // 
            this.tituloPr.AccessibleDescription = "";
            this.tituloPr.BackColor = System.Drawing.Color.Snow;
            this.tituloPr.Font = new System.Drawing.Font("Gentium Book Basic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tituloPr.Location = new System.Drawing.Point(-4, 1);
            this.tituloPr.MaxLength = 327;
            this.tituloPr.Multiline = true;
            this.tituloPr.Name = "tituloPr";
            this.tituloPr.Size = new System.Drawing.Size(966, 57);
            this.tituloPr.TabIndex = 20;
            this.tituloPr.Text = "compre seu veículo ";
            this.tituloPr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tituloPr.TextChanged += new System.EventHandler(this.tituloPr_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AutoCar.Properties.Resources.onix_c;
            this.pictureBox4.Location = new System.Drawing.Point(724, 74);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(5, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 111);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AutoCar.Properties.Resources.nivus;
            this.pictureBox3.Location = new System.Drawing.Point(499, 74);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(5, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCar.Properties.Resources.strada;
            this.pictureBox1.Location = new System.Drawing.Point(273, 74);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoCar.Properties.Resources.civic_c;
            this.pictureBox2.Location = new System.Drawing.Point(39, 74);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Gentium Book Basic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Honda Civic 2022 - EXL (2.0)",
            "Fiat Strada 2022 CVT",
            "Volkswagen nivus 2024 - 200 TSI",
            "Chevrolet Onix Turbo Premier"});
            this.comboBox1.Location = new System.Drawing.Point(424, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 23);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.Text = "Escolha seu novo Carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gentium Book Basic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 45);
            this.label2.TabIndex = 31;
            this.label2.Text = "Honda Civic 2022 - EXL (2.0)\r\nPreço: R$130.000,00\r\nPotência: 150";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gentium Book Basic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 45);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fiat Strada 2022 CVT\r\nPreço: R$116.000,00\r\nPotência: 107";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gentium Book Basic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 45);
            this.label4.TabIndex = 33;
            this.label4.Text = "Volkswagen nivus 2024 - 200 TSI\r\nPreço: R$142.000,00\r\nPotência: 127";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gentium Book Basic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(745, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 45);
            this.label5.TabIndex = 34;
            this.label5.Text = "Chevrolet Onix turbo premier\r\nPreço: R$123.000,00\r\nPotência: 116";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::AutoCar.Properties.Resources.yeappsTlxPVcavymiZ39__qg5cf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(962, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tituloPr);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "titulo";
            this.Text = "Locadora de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox tituloPr;
    }
}

