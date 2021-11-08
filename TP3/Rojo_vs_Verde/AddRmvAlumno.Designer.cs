
namespace Evento_deportivo
{
    partial class AddRmvAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRmvAlumno));
            this.lst_alumnos = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Rmv = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lst_participantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_alumnos
            // 
            this.lst_alumnos.FormattingEnabled = true;
            this.lst_alumnos.ItemHeight = 15;
            this.lst_alumnos.Location = new System.Drawing.Point(299, 12);
            this.lst_alumnos.Name = "lst_alumnos";
            this.lst_alumnos.Size = new System.Drawing.Size(473, 214);
            this.lst_alumnos.TabIndex = 0;
            this.lst_alumnos.SelectedIndexChanged += new System.EventHandler(this.lst_alumnos_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.Lavender;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Add.FlatAppearance.BorderSize = 2;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(281, 88);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Agregar";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Rmv
            // 
            this.btn_Rmv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Rmv.BackColor = System.Drawing.Color.Lavender;
            this.btn_Rmv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Rmv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Rmv.FlatAppearance.BorderSize = 2;
            this.btn_Rmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rmv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Rmv.Location = new System.Drawing.Point(12, 194);
            this.btn_Rmv.Name = "btn_Rmv";
            this.btn_Rmv.Size = new System.Drawing.Size(281, 88);
            this.btn_Rmv.TabIndex = 15;
            this.btn_Rmv.Text = "Remover";
            this.btn_Rmv.UseVisualStyleBackColor = false;
            this.btn_Rmv.Click += new System.EventHandler(this.btn_Rmv_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Volver.BackColor = System.Drawing.Color.Lavender;
            this.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Volver.FlatAppearance.BorderSize = 2;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.Location = new System.Drawing.Point(12, 361);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(281, 88);
            this.btn_Volver.TabIndex = 16;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lst_participantes
            // 
            this.lst_participantes.FormattingEnabled = true;
            this.lst_participantes.ItemHeight = 15;
            this.lst_participantes.Location = new System.Drawing.Point(299, 235);
            this.lst_participantes.Name = "lst_participantes";
            this.lst_participantes.Size = new System.Drawing.Size(473, 214);
            this.lst_participantes.TabIndex = 17;
            // 
            // AddRmvAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lst_participantes);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Rmv);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lst_alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRmvAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir / Remover alumno";
            this.Load += new System.EventHandler(this.AddRmvAlumno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_alumnos;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Rmv;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.ListBox lst_participantes;
    }
}