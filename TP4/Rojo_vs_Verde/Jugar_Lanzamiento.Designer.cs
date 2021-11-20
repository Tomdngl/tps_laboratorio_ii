
namespace Evento_deportivo
{
    partial class Jugar_Lanzamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar_Lanzamiento));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Listo = new System.Windows.Forms.Button();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.txt_puntos = new System.Windows.Forms.TextBox();
            this.lbl_Identificador = new System.Windows.Forms.Label();
            this.lst_participantes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AciertosRojo = new System.Windows.Forms.TextBox();
            this.txt_AciertosVerde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.Lavender;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(17, 387);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(315, 42);
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Listo
            // 
            this.btn_Listo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Listo.BackColor = System.Drawing.Color.Lavender;
            this.btn_Listo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Listo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Listo.FlatAppearance.BorderSize = 2;
            this.btn_Listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Listo.Location = new System.Drawing.Point(439, 387);
            this.btn_Listo.Name = "btn_Listo";
            this.btn_Listo.Size = new System.Drawing.Size(315, 42);
            this.btn_Listo.TabIndex = 34;
            this.btn_Listo.Text = "Listo";
            this.btn_Listo.UseVisualStyleBackColor = false;
            this.btn_Listo.Click += new System.EventHandler(this.btn_Listo_Click);
            // 
            // lbl_nota
            // 
            this.lbl_nota.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nota.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nota.Location = new System.Drawing.Point(17, 112);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(271, 99);
            this.lbl_nota.TabIndex = 33;
            this.lbl_nota.Text = "*Los puntos se suman por aciertos del equipo ganador";
            // 
            // txt_puntos
            // 
            this.txt_puntos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_puntos.Location = new System.Drawing.Point(17, 72);
            this.txt_puntos.MaxLength = 6;
            this.txt_puntos.Name = "txt_puntos";
            this.txt_puntos.Size = new System.Drawing.Size(257, 37);
            this.txt_puntos.TabIndex = 32;
            // 
            // lbl_Identificador
            // 
            this.lbl_Identificador.AutoSize = true;
            this.lbl_Identificador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Identificador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Identificador.Location = new System.Drawing.Point(294, 32);
            this.lbl_Identificador.Name = "lbl_Identificador";
            this.lbl_Identificador.Size = new System.Drawing.Size(169, 28);
            this.lbl_Identificador.TabIndex = 29;
            this.lbl_Identificador.Text = "Participantes:";
            // 
            // lst_participantes
            // 
            this.lst_participantes.FormattingEnabled = true;
            this.lst_participantes.ItemHeight = 15;
            this.lst_participantes.Location = new System.Drawing.Point(294, 72);
            this.lst_participantes.Name = "lst_participantes";
            this.lst_participantes.Size = new System.Drawing.Size(473, 244);
            this.lst_participantes.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Puntos:";
            // 
            // txt_AciertosRojo
            // 
            this.txt_AciertosRojo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_AciertosRojo.Location = new System.Drawing.Point(127, 252);
            this.txt_AciertosRojo.MaxLength = 6;
            this.txt_AciertosRojo.Name = "txt_AciertosRojo";
            this.txt_AciertosRojo.Size = new System.Drawing.Size(119, 37);
            this.txt_AciertosRojo.TabIndex = 37;
            // 
            // txt_AciertosVerde
            // 
            this.txt_AciertosVerde.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_AciertosVerde.Location = new System.Drawing.Point(127, 308);
            this.txt_AciertosVerde.MaxLength = 6;
            this.txt_AciertosVerde.Name = "txt_AciertosVerde";
            this.txt_AciertosVerde.Size = new System.Drawing.Size(119, 37);
            this.txt_AciertosVerde.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Rojo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Aciertos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Verde:";
            // 
            // Jugar_Lanzamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AciertosVerde);
            this.Controls.Add(this.txt_AciertosRojo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Listo);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.txt_puntos);
            this.Controls.Add(this.lbl_Identificador);
            this.Controls.Add(this.lst_participantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jugar_Lanzamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugar_Lanzamiento";
            this.Load += new System.EventHandler(this.Jugar_Lanzamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Listo;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.TextBox txt_puntos;
        private System.Windows.Forms.Label lbl_Identificador;
        private System.Windows.Forms.ListBox lst_participantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AciertosRojo;
        private System.Windows.Forms.TextBox txt_AciertosVerde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}