namespace EscuelaBaseDeDatos
{
    partial class Form1
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
            label1 = new Label();
            txtMatricula = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            nudSemestre = new NumericUpDown();
            label4 = new Label();
            txtGrupo = new TextBox();
            label6 = new Label();
            txtEspecialidad = new TextBox();
            btnGuardar = new Button();
            btnMostrar = new Button();
            button3 = new Button();
            dgvAlumnos = new DataGridView();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(122, 38);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 126);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 35);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Semestre:";
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(511, 33);
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(120, 23);
            nudSemestre.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 77);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 10;
            label4.Text = "Grupo:";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(531, 74);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(100, 23);
            txtGrupo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 122);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 12;
            label6.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(531, 119);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(100, 23);
            txtEspecialidad.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(691, 33);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(691, 74);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(703, 142);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 16;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 222);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(776, 216);
            dgvAlumnos.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(691, 118);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvAlumnos);
            Controls.Add(button3);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEspecialidad);
            Controls.Add(label6);
            Controls.Add(txtGrupo);
            Controls.Add(label4);
            Controls.Add(nudSemestre);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMatricula);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatricula;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label label5;
        private NumericUpDown nudSemestre;
        private Label label4;
        private TextBox txtGrupo;
        private Label label6;
        private TextBox txtEspecialidad;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button button3;
        private DataGridView dgvAlumnos;
        private Button btnLimpiar;
    }
}
