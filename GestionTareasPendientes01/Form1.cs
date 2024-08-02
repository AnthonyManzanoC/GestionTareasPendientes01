using System;
using System.Windows.Forms;

namespace GestionTareasPendientes01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
                txtTarea.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una tarea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta tarea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres limpiar toda la lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                lstTareas.Items.Clear();
            }
        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {
            // Este evento se puede utilizar si quieres hacer algo mientras el texto cambia.
        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este evento se puede utilizar si quieres hacer algo cuando se selecciona un elemento.
        }
    }
}
