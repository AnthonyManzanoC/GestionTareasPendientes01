namespace GestionTareasPendientes01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTareas
            // 
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.Location = new System.Drawing.Point(275, 143);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(179, 160);
            this.lstTareas.TabIndex = 0;
            this.lstTareas.SelectedIndexChanged += new System.EventHandler(this.lstTareas_SelectedIndexChanged);
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(306, 43);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(120, 20);
            this.txtTarea.TabIndex = 1;
            this.txtTarea.TextChanged += new System.EventHandler(this.txtTarea_TextChanged);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(306, 95);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarTarea.TabIndex = 3;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(275, 333);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTarea.TabIndex = 5;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(379, 333);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarLista.TabIndex = 6;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.lstTareas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Button btnLimpiarLista;
    }
}

