namespace AppSistemaGaragem
{
    partial class Form1
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
            this.tbListaEntrada = new System.Windows.Forms.TextBox();
            this.tbListaSaida = new System.Windows.Forms.TextBox();
            this.lblListaEntrada = new System.Windows.Forms.Label();
            this.lblListaSaida = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btEntrada = new System.Windows.Forms.Button();
            this.btSaida = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbListaEntrada
            // 
            this.tbListaEntrada.Enabled = false;
            this.tbListaEntrada.Location = new System.Drawing.Point(226, 80);
            this.tbListaEntrada.Multiline = true;
            this.tbListaEntrada.Name = "tbListaEntrada";
            this.tbListaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaEntrada.Size = new System.Drawing.Size(276, 358);
            this.tbListaEntrada.TabIndex = 0;
            // 
            // tbListaSaida
            // 
            this.tbListaSaida.Enabled = false;
            this.tbListaSaida.Location = new System.Drawing.Point(512, 80);
            this.tbListaSaida.Multiline = true;
            this.tbListaSaida.Name = "tbListaSaida";
            this.tbListaSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaSaida.Size = new System.Drawing.Size(276, 358);
            this.tbListaSaida.TabIndex = 1;
            // 
            // lblListaEntrada
            // 
            this.lblListaEntrada.AutoSize = true;
            this.lblListaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEntrada.Location = new System.Drawing.Point(251, 32);
            this.lblListaEntrada.Name = "lblListaEntrada";
            this.lblListaEntrada.Size = new System.Drawing.Size(217, 24);
            this.lblListaEntrada.TabIndex = 2;
            this.lblListaEntrada.Text = "Veículos na Garagem:";
            // 
            // lblListaSaida
            // 
            this.lblListaSaida.AutoSize = true;
            this.lblListaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaSaida.Location = new System.Drawing.Point(541, 32);
            this.lblListaSaida.Name = "lblListaSaida";
            this.lblListaSaida.Size = new System.Drawing.Size(209, 24);
            this.lblListaSaida.TabIndex = 3;
            this.lblListaSaida.Text = "Veículos que Saíram:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(49, 156);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(117, 20);
            this.tbPlaca.TabIndex = 4;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(84, 132);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(44, 13);
            this.lblPlaca.TabIndex = 5;
            this.lblPlaca.Text = "PLACA:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(81, 204);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 13);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "HORÁRIO:";
            // 
            // dtpHora
            // 
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(72, 225);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(73, 20);
            this.dtpHora.TabIndex = 7;
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(67, 297);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(81, 20);
            this.dtpData.TabIndex = 9;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(88, 276);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 13);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "DATA:";
            // 
            // btEntrada
            // 
            this.btEntrada.Location = new System.Drawing.Point(22, 367);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(87, 38);
            this.btEntrada.TabIndex = 10;
            this.btEntrada.Text = "ENTRADA";
            this.btEntrada.UseVisualStyleBackColor = true;
            // 
            // btSaida
            // 
            this.btSaida.Location = new System.Drawing.Point(115, 367);
            this.btSaida.Name = "btSaida";
            this.btSaida.Size = new System.Drawing.Size(87, 38);
            this.btSaida.TabIndex = 11;
            this.btSaida.Text = "SAÍDA";
            this.btSaida.UseVisualStyleBackColor = true;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(33, 80);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(155, 20);
            this.lblDados.TabIndex = 12;
            this.lblDados.Text = "Dados do Veículo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btSaida);
            this.Controls.Add(this.btEntrada);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.lblListaSaida);
            this.Controls.Add(this.lblListaEntrada);
            this.Controls.Add(this.tbListaSaida);
            this.Controls.Add(this.tbListaEntrada);
            this.Name = "Form1";
            this.Text = "Sistema de Garagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbListaEntrada;
        private System.Windows.Forms.TextBox tbListaSaida;
        private System.Windows.Forms.Label lblListaEntrada;
        private System.Windows.Forms.Label lblListaSaida;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.Button btSaida;
        private System.Windows.Forms.Label lblDados;
    }
}

