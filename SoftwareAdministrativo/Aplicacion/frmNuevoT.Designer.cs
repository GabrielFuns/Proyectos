namespace Aplicacion
{
    partial class frmNuevoT
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtPedido = new System.Windows.Forms.TextBox();
            this.TxtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RbArreglo = new System.Windows.Forms.RadioButton();
            this.RbConfeccion = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpRecibido = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpEntregar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEntrega = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(0, 271);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(383, 23);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(0, 294);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(383, 23);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtPedido
            // 
            this.TxtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPedido.Location = new System.Drawing.Point(83, 47);
            this.TxtPedido.Name = "TxtPedido";
            this.TxtPedido.Size = new System.Drawing.Size(288, 24);
            this.TxtPedido.TabIndex = 12;
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDetalle.Location = new System.Drawing.Point(83, 77);
            this.TxtDetalle.Multiline = true;
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Size = new System.Drawing.Size(288, 75);
            this.TxtDetalle.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo Trabajo:";
            // 
            // RbArreglo
            // 
            this.RbArreglo.AutoSize = true;
            this.RbArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbArreglo.Location = new System.Drawing.Point(116, 14);
            this.RbArreglo.Name = "RbArreglo";
            this.RbArreglo.Size = new System.Drawing.Size(73, 22);
            this.RbArreglo.TabIndex = 13;
            this.RbArreglo.TabStop = true;
            this.RbArreglo.Text = "Arreglo";
            this.RbArreglo.UseVisualStyleBackColor = true;
            // 
            // RbConfeccion
            // 
            this.RbConfeccion.AutoSize = true;
            this.RbConfeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbConfeccion.Location = new System.Drawing.Point(245, 15);
            this.RbConfeccion.Name = "RbConfeccion";
            this.RbConfeccion.Size = new System.Drawing.Size(102, 22);
            this.RbConfeccion.TabIndex = 14;
            this.RbConfeccion.TabStop = true;
            this.RbConfeccion.Text = "Confeccion";
            this.RbConfeccion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Detalle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Recibido:";
            // 
            // DtpRecibido
            // 
            this.DtpRecibido.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpRecibido.Location = new System.Drawing.Point(83, 158);
            this.DtpRecibido.Name = "DtpRecibido";
            this.DtpRecibido.Size = new System.Drawing.Size(288, 20);
            this.DtpRecibido.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Entregar:";
            // 
            // DtpEntregar
            // 
            this.DtpEntregar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEntregar.Location = new System.Drawing.Point(83, 184);
            this.DtpEntregar.Name = "DtpEntregar";
            this.DtpEntregar.Size = new System.Drawing.Size(288, 20);
            this.DtpEntregar.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seña:";
            // 
            // TxtEntrega
            // 
            this.TxtEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEntrega.Location = new System.Drawing.Point(83, 210);
            this.TxtEntrega.Name = "TxtEntrega";
            this.TxtEntrega.Size = new System.Drawing.Size(288, 24);
            this.TxtEntrega.TabIndex = 21;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(83, 240);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(288, 24);
            this.TxtPrecio.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Precio:";
            // 
            // frmNuevoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 317);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtEntrega);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtpEntregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtpRecibido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RbConfeccion);
            this.Controls.Add(this.RbArreglo);
            this.Controls.Add(this.TxtPedido);
            this.Controls.Add(this.TxtDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Name = "frmNuevoT";
            this.Text = "Nuevo Trabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        public System.Windows.Forms.TextBox TxtPedido;
        public System.Windows.Forms.TextBox TxtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbArreglo;
        private System.Windows.Forms.RadioButton RbConfeccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpRecibido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpEntregar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtEntrega;
        public System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label7;
    }
}