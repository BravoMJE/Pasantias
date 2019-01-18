namespace PasantiasProyecto
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnIniciarSecion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtUsername);
            this.bunifuGradientPanel1.Controls.Add(this.btnIniciarSecion);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(600, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnIniciarSecion
            // 
            this.btnIniciarSecion.ActiveBorderThickness = 1;
            this.btnIniciarSecion.ActiveCornerRadius = 20;
            this.btnIniciarSecion.ActiveFillColor = System.Drawing.Color.Violet;
            this.btnIniciarSecion.ActiveForecolor = System.Drawing.Color.Red;
            this.btnIniciarSecion.ActiveLineColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIniciarSecion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSecion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarSecion.BackgroundImage")));
            this.btnIniciarSecion.ButtonText = "Iniciar Secion";
            this.btnIniciarSecion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSecion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSecion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSecion.IdleBorderThickness = 1;
            this.btnIniciarSecion.IdleCornerRadius = 20;
            this.btnIniciarSecion.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.btnIniciarSecion.IdleForecolor = System.Drawing.Color.Lime;
            this.btnIniciarSecion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnIniciarSecion.Location = new System.Drawing.Point(153, 267);
            this.btnIniciarSecion.Margin = new System.Windows.Forms.Padding(5);
            this.btnIniciarSecion.Name = "btnIniciarSecion";
            this.btnIniciarSecion.Size = new System.Drawing.Size(250, 41);
            this.btnIniciarSecion.TabIndex = 1;
            this.btnIniciarSecion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUsername.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Location = new System.Drawing.Point(153, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 42);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.text = "Bunifu TextBox";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIniciarSecion;
        private Bunifu.Framework.UI.BunifuTextbox txtUsername;
    }
}