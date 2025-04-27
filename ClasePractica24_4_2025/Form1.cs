using ClasePractica24_4_2025.Data;
using ClasePractica24_4_2025.Models;


namespace ClasePractica24_4_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            using var context = new ConsultorioContext();
            dgvPacientes.DataSource = context.Paciente.ToList();
        }

        //Rellenar los cuadros de texto con los parametros del paciente seleccionado
        private void ExtraerValores(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                int id = (int)dgvPacientes.CurrentRow.Cells["PacienteID"].Value;
                using var context = new ConsultorioContext();
                var paciente = context.Paciente.Find(id);
                if (paciente != null)
                {
                    CargarValoresenParametros(paciente);
                }
            }
        }
        //Metodo para cargar los parametros en los cuadros de texto
        private void CargarValoresenParametros(Paciente paciente)
        {
            txtPrimerNombre.Text = (string)dgvPacientes.CurrentRow.Cells["PrimerNombre"].Value;
            txtSegundoNombre.Text = (string)dgvPacientes.CurrentRow.Cells["SegundoNombre"].Value;
            txtPrimerApellido.Text = (string)dgvPacientes.CurrentRow.Cells["PrimerApellido"].Value;
            txtSegundoApellido.Text = (string)dgvPacientes.CurrentRow.Cells["SegundoApellido"].Value;
            txtEdad.Text = ((int)dgvPacientes.CurrentRow.Cells["Edad"].Value).ToString();
            dtpFechaConsulta.Value = (DateTime)dgvPacientes.CurrentRow.Cells["FechaConsulta"].Value;
            txtObservación.Text = (string)dgvPacientes.CurrentRow.Cells["Obsevarción"].Value;
        }

        private void LimpiarCampos()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtEdad.Clear();
            txtObservación.Clear();
            dgvPacientes.ClearSelection();
            dgvPacientes.CurrentCell = null;
        }

        //Unicamente permitir el ingreso de numeros en el parametro de la edad
        private void UnicamenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void AgregarPaciente(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrimerNombre.Text) || string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtObservación.Text))
            {
                MessageBox.Show($"Revise que los siguientes campos no estén vacios: \n\tPrimer Nombre, \n\tPrimer Apellido, \n\tEdad, \n\tObservación", "Campos primordiales vacios", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {

                using var context = new ConsultorioContext();
                var Paciente = new Paciente
                {
                    FechaConsulta = dtpFechaConsulta.Value,
                    PrimerNombre = txtPrimerNombre.Text,
                    SegundoNombre = txtSegundoNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    Obsevarción = txtObservación.Text,
                };
                context.Paciente.Add(Paciente);
                context.SaveChanges();
                CargarPacientes();
                LimpiarCampos();

            }
        }

        private void ActualizarPaciente(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                if (string.IsNullOrEmpty(txtPrimerNombre.Text) || string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtObservación.Text))
                {
                    MessageBox.Show($"Revise que los siguientes campos no estén vacios: \n\tPrimer Nombre, \n\tPrimer Apellido, \n\tEdad, \n\tObservación", "Campos primordiales vacios", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Está seguro que quiere actualizar al siguiente paciente?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        int id = (int)dgvPacientes.CurrentRow.Cells["PacienteID"].Value;
                        using var context = new ConsultorioContext();
                        var paciente = context.Paciente.Find(id);
                        if (paciente != null)
                        {
                            paciente.PrimerNombre = txtPrimerNombre.Text;
                            paciente.SegundoNombre = txtSegundoNombre.Text;
                            paciente.PrimerApellido = txtPrimerApellido.Text;
                            paciente.SegundoApellido = txtSegundoApellido.Text;
                            paciente.Edad = Convert.ToInt32(txtEdad.Text);
                            paciente.FechaConsulta = dtpFechaConsulta.Value;
                            paciente.Obsevarción = txtObservación.Text;

                            context.SaveChanges();
                            CargarPacientes();
                            LimpiarCampos();
                            MessageBox.Show("Paciente actualizado", "Actualización con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else { return; }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selección a un paciente para actualizar", "Selecione", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void EliminarPaciente(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar al siguiente paciente?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int id = (int)dgvPacientes.CurrentRow.Cells["PacienteID"].Value;
                    using var context = new ConsultorioContext();
                    var paciente = context.Paciente.Find(id);
                    if (paciente != null)
                    {

                        context.Remove(paciente);
                        context.SaveChanges();
                        CargarPacientes();
                        LimpiarCampos();

                    }
                }
                else { return; }
            }
            else
            {
                MessageBox.Show("Selección a un paciente para elimnar", "Selecione", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dgvPacientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPacientes.ClearSelection();
            dgvPacientes.CurrentCell = null;
        }

        private void BotonLimpiarCampos(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
