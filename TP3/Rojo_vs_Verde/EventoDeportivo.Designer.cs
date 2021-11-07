
namespace Evento_deportivo
{
    partial class EventoDeportivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventoDeportivo));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PrepararJuego = new System.Windows.Forms.Button();
            this.btn_Jugar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(74, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Administrar personas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_PrepararJuego
            // 
            this.btn_PrepararJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PrepararJuego.BackColor = System.Drawing.Color.Lavender;
            this.btn_PrepararJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_PrepararJuego.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_PrepararJuego.FlatAppearance.BorderSize = 2;
            this.btn_PrepararJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrepararJuego.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PrepararJuego.Location = new System.Drawing.Point(428, 173);
            this.btn_PrepararJuego.Name = "btn_PrepararJuego";
            this.btn_PrepararJuego.Size = new System.Drawing.Size(289, 76);
            this.btn_PrepararJuego.TabIndex = 1;
            this.btn_PrepararJuego.Text = "Preparar juegos";
            this.btn_PrepararJuego.UseVisualStyleBackColor = false;
            this.btn_PrepararJuego.Click += new System.EventHandler(this.btn_PrepararJuego_Click);
            // 
            // btn_Jugar
            // 
            this.btn_Jugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Jugar.BackColor = System.Drawing.Color.Lavender;
            this.btn_Jugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Jugar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Jugar.FlatAppearance.BorderSize = 2;
            this.btn_Jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Jugar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Jugar.Location = new System.Drawing.Point(74, 173);
            this.btn_Jugar.Name = "btn_Jugar";
            this.btn_Jugar.Size = new System.Drawing.Size(289, 76);
            this.btn_Jugar.TabIndex = 2;
            this.btn_Jugar.Text = "Jugar";
            this.btn_Jugar.UseVisualStyleBackColor = false;
            this.btn_Jugar.Click += new System.EventHandler(this.btn_Jugar_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Lavender;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(428, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Estadisticas";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 143);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EventoDeportivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Jugar);
            this.Controls.Add(this.btn_PrepararJuego);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventoDeportivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evento deportivo";
            this.Load += new System.EventHandler(this.EventoDeportivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_PrepararJuego;
        private System.Windows.Forms.Button btn_Jugar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}