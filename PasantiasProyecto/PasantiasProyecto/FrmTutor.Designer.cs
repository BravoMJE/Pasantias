namespace PasantiasProyecto
{
    partial class FrmTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTutor));
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnOcultar = new System.Windows.Forms.PictureBox();
            this.btnMaximixar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnOpcione = new System.Windows.Forms.PictureBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.btnInformeFinal = new System.Windows.Forms.Button();
            this.btnInformeMitad = new System.Windows.Forms.Button();
            this.PnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximixar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpcione)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PnlIzquierdo.Controls.Add(this.btnInformeMitad);
            this.PnlIzquierdo.Controls.Add(this.btnInformeFinal);
            this.PnlIzquierdo.Controls.Add(this.pictureBox1);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlIzquierdo.ForeColor = System.Drawing.Color.White;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(251, 650);
            this.PnlIzquierdo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.btnMinimizar);
            this.PnlTitulo.Controls.Add(this.btnOcultar);
            this.PnlTitulo.Controls.Add(this.btnMaximixar);
            this.PnlTitulo.Controls.Add(this.btnCerrar);
            this.PnlTitulo.Controls.Add(this.btnOpcione);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(251, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1049, 50);
            this.PnlTitulo.TabIndex = 1;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1002, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Visible = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultar.Image")));
            this.btnOcultar.Location = new System.Drawing.Point(976, 0);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(20, 20);
            this.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultar.TabIndex = 3;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnMaximixar
            // 
            this.btnMaximixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximixar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximixar.Image")));
            this.btnMaximixar.Location = new System.Drawing.Point(1002, 0);
            this.btnMaximixar.Name = "btnMaximixar";
            this.btnMaximixar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximixar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximixar.TabIndex = 2;
            this.btnMaximixar.TabStop = false;
            this.btnMaximixar.Click += new System.EventHandler(this.btnMaximixar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1028, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnOpcione
            // 
            this.btnOpcione.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcione.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcione.Image")));
            this.btnOpcione.Location = new System.Drawing.Point(6, 9);
            this.btnOpcione.Name = "btnOpcione";
            this.btnOpcione.Size = new System.Drawing.Size(35, 35);
            this.btnOpcione.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpcione.TabIndex = 0;
            this.btnOpcione.TabStop = false;
            this.btnOpcione.Click += new System.EventHandler(this.btnOpcione_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(251, 50);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1049, 600);
            this.PnlContenedor.TabIndex = 2;
            // 
            // btnInformeFinal
            // 
            this.btnInformeFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInformeFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeFinal.Location = new System.Drawing.Point(31, 232);
            this.btnInformeFinal.Name = "btnInformeFinal";
            this.btnInformeFinal.Size = new System.Drawing.Size(173, 65);
            this.btnInformeFinal.TabIndex = 0;
            this.btnInformeFinal.Text = "Informe Final";
            this.btnInformeFinal.UseVisualStyleBackColor = true;
            // 
            // btnInformeMitad
            // 
            this.btnInformeMitad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInformeMitad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeMitad.Location = new System.Drawing.Point(31, 384);
            this.btnInformeMitad.Name = "btnInformeMitad";
            this.btnInformeMitad.Size = new System.Drawing.Size(173, 77);
            this.btnInformeMitad.TabIndex = 1;
            this.btnInformeMitad.Text = "Informe Mitad Periodo";
            this.btnInformeMitad.UseVisualStyleBackColor = true;
            // 
            // FrmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTutor";
            this.Text = "FrmTutor";
            this.PnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximixar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpcione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox btnOpcione;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMaximixar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnOcultar;
        private System.Windows.Forms.Button btnInformeMitad;
        private System.Windows.Forms.Button btnInformeFinal;
    }
}