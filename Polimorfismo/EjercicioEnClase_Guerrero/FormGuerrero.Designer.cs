namespace Interfaz
{
    partial class FormGuerrero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEspada = new System.Windows.Forms.Button();
            this.btnHacha = new System.Windows.Forms.Button();
            this.btnArco = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.lblMensajeAtaque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEspada
            // 
            this.btnEspada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEspada.Location = new System.Drawing.Point(509, 92);
            this.btnEspada.Name = "btnEspada";
            this.btnEspada.Size = new System.Drawing.Size(134, 41);
            this.btnEspada.TabIndex = 0;
            this.btnEspada.Text = "ESPADA";
            this.btnEspada.UseVisualStyleBackColor = true;
            this.btnEspada.Click += new System.EventHandler(this.btnEspada_Click);
            // 
            // btnHacha
            // 
            this.btnHacha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHacha.Location = new System.Drawing.Point(509, 191);
            this.btnHacha.Name = "btnHacha";
            this.btnHacha.Size = new System.Drawing.Size(134, 41);
            this.btnHacha.TabIndex = 1;
            this.btnHacha.Text = "HACHA";
            this.btnHacha.UseVisualStyleBackColor = true;
            this.btnHacha.Click += new System.EventHandler(this.btnHacha_Click);
            // 
            // btnArco
            // 
            this.btnArco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArco.Location = new System.Drawing.Point(509, 296);
            this.btnArco.Name = "btnArco";
            this.btnArco.Size = new System.Drawing.Size(134, 41);
            this.btnArco.TabIndex = 2;
            this.btnArco.Text = "ARCO";
            this.btnArco.UseVisualStyleBackColor = true;
            this.btnArco.Click += new System.EventHandler(this.btnArco_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtacar.Location = new System.Drawing.Point(127, 347);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(134, 41);
            this.btnAtacar.TabIndex = 3;
            this.btnAtacar.Text = "ATACAR";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // lblMensajeAtaque
            // 
            this.lblMensajeAtaque.AutoSize = true;
            this.lblMensajeAtaque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeAtaque.Location = new System.Drawing.Point(127, 403);
            this.lblMensajeAtaque.Name = "lblMensajeAtaque";
            this.lblMensajeAtaque.Size = new System.Drawing.Size(79, 21);
            this.lblMensajeAtaque.TabIndex = 4;
            this.lblMensajeAtaque.Text = "En reposo";
            // 
            // FormGuerrero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensajeAtaque);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnArco);
            this.Controls.Add(this.btnHacha);
            this.Controls.Add(this.btnEspada);
            this.Name = "FormGuerrero";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEspada;
        private Button btnHacha;
        private Button btnArco;
        private Button btnAtacar;
        private Label lblMensajeAtaque;
    }
}