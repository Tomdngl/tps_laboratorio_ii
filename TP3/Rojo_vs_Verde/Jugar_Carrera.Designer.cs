
namespace Evento_deportivo
{
    partial class Jugar_Carrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar_Carrera));
            this.lst_participantes = new System.Windows.Forms.ListBox();
            this.lbl_Identificador = new System.Windows.Forms.Label();
            this.cmb_equipos = new System.Windows.Forms.ComboBox();
            this.lbl_ganador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_puntos = new System.Windows.Forms.TextBox();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.btn_Listo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_participantes
            // 
            this.lst_participantes.FormattingEnabled = true;
            this.lst_participantes.ItemHeight = 15;
            this.lst_participantes.Location = new System.Drawing.Point(299, 75);
            this.lst_participantes.Name = "lst_participantes";
            this.lst_participantes.Size = new System.Drawing.Size(473, 244);
            this.lst_participantes.TabIndex = 18;
            // 
            // lbl_Identificador
            // 
            this.lbl_Identificador.AutoSize = true;
            this.lbl_Identificador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Identificador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Identificador.Location = new System.Drawing.Point(299, 35);
            this.lbl_Identificador.Name = "lbl_Identificador";
            this.lbl_Identificador.Size = new System.Drawing.Size(169, 28);
            this.lbl_Identificador.TabIndex = 19;
            this.lbl_Identificador.Text = "Participantes:";
            // 
            // cmb_equipos
            // 
            this.cmb_equipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_equipos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_equipos.FormattingEnabled = true;
            this.cmb_equipos.Location = new System.Drawing.Point(22, 103);
            this.cmb_equipos.Name = "cmb_equipos";
            this.cmb_equipos.Size = new System.Drawing.Size(257, 36);
            this.cmb_equipos.TabIndex = 20;
            // 
            // lbl_ganador
            // 
            this.lbl_ganador.AutoSize = true;
            this.lbl_ganador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ganador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ganador.Location = new System.Drawing.Point(22, 72);
            this.lbl_ganador.Name = "lbl_ganador";
            this.lbl_ganador.Size = new System.Drawing.Size(206, 28);
            this.lbl_ganador.TabIndex = 21;
            this.lbl_ganador.Text = "Equipo ganador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Puntos:";
            // 
            // txt_puntos
            // 
            this.txt_puntos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_puntos.Location = new System.Drawing.Point(22, 199);
            this.txt_puntos.MaxLength = 6;
            this.txt_puntos.Name = "txt_puntos";
            this.txt_puntos.Size = new System.Drawing.Size(257, 37);
            this.txt_puntos.TabIndex = 24;
            // 
            // lbl_nota
            // 
            this.lbl_nota.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nota.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nota.Location = new System.Drawing.Point(22, 252);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(271, 99);
            this.lbl_nota.TabIndex = 25;
            this.lbl_nota.Text = "*Los puntos se suman por cada integrante ganador";
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
            this.btn_Listo.Location = new System.Drawing.Point(444, 390);
            this.btn_Listo.Name = "btn_Listo";
            this.btn_Listo.Size = new System.Drawing.Size(315, 42);
            this.btn_Listo.TabIndex = 26;
            this.btn_Listo.Text = "Listo";
            this.btn_Listo.UseVisualStyleBackColor = false;
            this.btn_Listo.Click += new System.EventHandler(this.btn_Listo_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(22, 390);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(315, 42);
            this.btn_cancelar.TabIndex = 27;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Jugar_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Listo);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.txt_puntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ganador);
            this.Controls.Add(this.cmb_equipos);
            this.Controls.Add(this.lbl_Identificador);
            this.Controls.Add(this.lst_participantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jugar_Carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugar_Carrera";
            this.Load += new System.EventHandler(this.Jugar_Carrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_participantes;
        private System.Windows.Forms.Label lbl_Identificador;
        private System.Windows.Forms.ComboBox cmb_equipos;
        private System.Windows.Forms.Label lbl_ganador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_puntos;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.Button btn_Listo;
        private System.Windows.Forms.Button btn_cancelar;
    }
}