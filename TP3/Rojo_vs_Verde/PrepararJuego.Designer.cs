
namespace Evento_deportivo
{
    partial class PrepararJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrepararJuego));
            this.cmb_Juego = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Listo = new System.Windows.Forms.Button();
            this.cmb_Profesor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Identificador = new System.Windows.Forms.TextBox();
            this.lbl_Identificador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Juego
            // 
            this.cmb_Juego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Juego.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_Juego.FormattingEnabled = true;
            this.cmb_Juego.Location = new System.Drawing.Point(53, 99);
            this.cmb_Juego.Name = "cmb_Juego";
            this.cmb_Juego.Size = new System.Drawing.Size(257, 36);
            this.cmb_Juego.TabIndex = 0;
            this.cmb_Juego.SelectedIndexChanged += new System.EventHandler(this.cmb_Juego_SelectedIndexChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Lavender;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(53, 369);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(315, 42);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
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
            this.btn_Listo.Location = new System.Drawing.Point(428, 369);
            this.btn_Listo.Name = "btn_Listo";
            this.btn_Listo.Size = new System.Drawing.Size(315, 42);
            this.btn_Listo.TabIndex = 4;
            this.btn_Listo.Text = "Listo";
            this.btn_Listo.UseVisualStyleBackColor = false;
            this.btn_Listo.Click += new System.EventHandler(this.btn_Listo_Click);
            // 
            // cmb_Profesor
            // 
            this.cmb_Profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Profesor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_Profesor.FormattingEnabled = true;
            this.cmb_Profesor.Location = new System.Drawing.Point(53, 236);
            this.cmb_Profesor.Name = "cmb_Profesor";
            this.cmb_Profesor.Size = new System.Drawing.Size(257, 36);
            this.cmb_Profesor.TabIndex = 5;
            this.cmb_Profesor.SelectedIndexChanged += new System.EventHandler(this.cmb_Profesor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profesor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Juego:";
            // 
            // txt_Identificador
            // 
            this.txt_Identificador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Identificador.Location = new System.Drawing.Point(486, 99);
            this.txt_Identificador.MaxLength = 17;
            this.txt_Identificador.Name = "txt_Identificador";
            this.txt_Identificador.Size = new System.Drawing.Size(257, 37);
            this.txt_Identificador.TabIndex = 10;
            this.txt_Identificador.TextChanged += new System.EventHandler(this.txt_Identificador_TextChanged);
            // 
            // lbl_Identificador
            // 
            this.lbl_Identificador.AutoSize = true;
            this.lbl_Identificador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Identificador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Identificador.Location = new System.Drawing.Point(486, 68);
            this.lbl_Identificador.Name = "lbl_Identificador";
            this.lbl_Identificador.Size = new System.Drawing.Size(167, 28);
            this.lbl_Identificador.TabIndex = 9;
            this.lbl_Identificador.Text = "Identificador:";
            // 
            // PrepararJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_Identificador);
            this.Controls.Add(this.txt_Identificador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Profesor);
            this.Controls.Add(this.btn_Listo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cmb_Juego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrepararJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrepararJuego";
            this.Load += new System.EventHandler(this.PrepararJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Juego;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Listo;
        private System.Windows.Forms.ComboBox cmb_Profesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Identificador;
        private System.Windows.Forms.Label lbl_Identificador;
    }
}