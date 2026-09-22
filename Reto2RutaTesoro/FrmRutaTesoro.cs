using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2RutaTesoro
{
    public partial class FrmRutaTesoro : Form
    {
            private ListaSimple rutaTesoro;

            public FrmRutaTesoro()
            {
                InitializeComponent();
                rutaTesoro = new ListaSimple();
                ConfigurarDataGridView();
            }

            private void ConfigurarDataGridView()
            {
                dgvNodos.Columns.Clear();
                dgvNodos.Columns.Add("Id", "ID");
                dgvNodos.Columns.Add("Nombre", "Ubicación");
                dgvNodos.Columns.Add("Pista", "Pista");
                dgvNodos.Columns.Add("NivelPeligro", "Peligro");
                dgvNodos.ReadOnly = true;
                dgvNodos.AllowUserToAddRows = false;
            }

            private void ActualizarGrid()
            {
                dgvNodos.Rows.Clear();
                Nodo actual = rutaTesoro.Inicio;

                while (actual != null)
                {
                    dgvNodos.Rows.Add(actual.Id, actual.Nombre, actual.Pista, actual.NivelPeligro);
                    actual = actual.Siguiente;
                }
            }

            private void LimpiarCampos()
            {
                numId.Value = 1;
                txtNombre.Clear();
                txtPista.Clear();
                numPeligro.Value = 1;
            }

            private void btnInsertar_Click(object sender, EventArgs e)
            {
                int id = (int)numId.Value;
                string nombre = txtNombre.Text.Trim();
                string pista = txtPista.Text.Trim();
                int peligro = (int)numPeligro.Value;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(pista))
                {
                    MessageBox.Show("Por favor complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rutaTesoro.Insertar(id, nombre, pista, peligro))
                {
                    ActualizarGrid();
                    LimpiarCampos();
                    MessageBox.Show("Ubicación agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El ID especificado ya existe en la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                int id = (int)numId.Value;
                Nodo encontrado = rutaTesoro.Buscar(id);

                if (encontrado != null)
                {
                    txtNombre.Text = encontrado.Nombre;
                    txtPista.Text = encontrado.Pista;
                    numPeligro.Value = encontrado.NivelPeligro;
                    MessageBox.Show("Ubicación encontrada.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna ubicación con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void btnModificar_Click(object sender, EventArgs e)
            {
                int id = (int)numId.Value;
                string nombre = txtNombre.Text.Trim();
                string pista = txtPista.Text.Trim();
                int peligro = (int)numPeligro.Value;

                if (rutaTesoro.Modificar(id, nombre, pista, peligro))
                {
                    ActualizarGrid();
                    LimpiarCampos();
                    MessageBox.Show("Ubicación modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar. El ID no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                int id = (int)numId.Value;

                if (rutaTesoro.Eliminar(id))
                {
                    ActualizarGrid();
                    LimpiarCampos();
                    MessageBox.Show("Ubicación eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar. El ID no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

