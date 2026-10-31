using CadParcial2Cmla;
using ClnParcialCmla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2Cmla
{
    public partial class FrmPrograma : Form
    {
        private bool esNuevo;
        public FrmPrograma()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var programas = HorarioProgramaCln.listarPa(txtParametro.Text.Trim());
            dgvListarProgramas.DataSource = programas;

            dgvListarProgramas.Columns["id"].Visible = false;
            dgvListarProgramas.Columns["idCanal"].Visible = false;
            dgvListarProgramas.Columns["estado"].Visible = false;

            dgvListarProgramas.Columns["canal"].HeaderText = "Canal";
            dgvListarProgramas.Columns["titulo"].HeaderText = "Título";
            dgvListarProgramas.Columns["tipo"].HeaderText = "Tipo";
            dgvListarProgramas.Columns["horaInicio"].HeaderText = "Hora Inicio";
            dgvListarProgramas.Columns["horaFin"].HeaderText = "Hora Fin";
            dgvListarProgramas.Columns["diaSemana"].HeaderText = "Día de Semana";
            dgvListarProgramas.Columns["conductorPrincipal"].HeaderText = "Conductor Principal";
            dgvListarProgramas.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvListarProgramas.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            if (programas.Count > 0) dgvListarProgramas.CurrentCell = dgvListarProgramas.Rows[0].Cells["titulo"];

            btnEditar.Enabled = programas.Count > 0;
            btnEliminar.Enabled = programas.Count > 0;
        }

        private void cargarCanales()
        {
            cbxCanal.DataSource = CanalCln.listar();
            cbxCanal.ValueMember = "id";
            cbxCanal.DisplayMember = "nombre";
            cbxCanal.SelectedIndex = -1;
        }

        private void cargarTipos()
        {
            cbxTipo.DataSource = HorarioProgramaCln.listar();
            cbxTipo.ValueMember = "id";
            cbxTipo.DisplayMember = "tipo";
            cbxTipo.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            Size = new Size(870, 344);
            listar();
            cargarCanales();
            cargarTipos();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void resetearCampos()
        {
            cbxCanal.SelectedIndex = -1;
            txtTitulo.Clear();
            cbxTipo.SelectedIndex = -1;
            mtbxHoraInicio.Clear();
            mtbxHoraFin.Clear();
            txtDiaSemana.Clear();
            txtConductorPrincipal.Clear();
            resetearErrores();
        }

        private void resetearErrores()
        {
            erpTipo.Clear();
            erpConductorPrincipal.Clear();
            erpCanal.Clear();
            erpTitulo.Clear();
            erpHoraInicio.Clear();
            erpHoraFin.Clear();
            erpDiaSemana.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(870, 550);
            pnlAcciones.Enabled = false;
            resetearCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(870, 550);
            pnlAcciones.Enabled = false;

            int id = (int)dgvListarProgramas.CurrentRow.Cells["id"].Value;
            var horario = HorarioProgramaCln.obtenerUno(id);

            cbxCanal.SelectedValue = horario.idCanal;
            cbxTipo.SelectedValue = horario.tipo;
            txtTitulo.Text = horario.titulo;
            mtbxHoraInicio.Text = horario.horaInicio.ToString(@"hh\:mm");
            mtbxHoraFin.Text = horario.horaFin.ToString(@"hh\:mm");
            txtDiaSemana.Text = horario.diaSemana;
            txtConductorPrincipal.Text = horario.conductorPrincipal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(870, 344);
            pnlAcciones.Enabled = true;
        }

        private bool validarCampos()
        {
            bool esValido = true;
            resetearErrores();

            if (cbxCanal.SelectedIndex == -1)
            {
                erpCanal.SetError(cbxCanal, "Seleccione un canal obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                erpTitulo.SetError(txtTitulo, "El título del programa es obligatorio");
                esValido = false;
            }
            if (cbxTipo.SelectedIndex == -1)
            {
                erpTipo.SetError(cbxTipo, "Seleccione un Tipo obligatorio");
                esValido = false;
            }
            if (!mtbxHoraInicio.MaskFull)
            {
                erpHoraInicio.SetError(mtbxHoraInicio, "Ingrese una hora de inicio completa");
                esValido = false;
            }
            if (!mtbxHoraFin.MaskFull)
            {
                erpHoraFin.SetError(mtbxHoraFin, "Ingrese una hora de fin completa");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaSemana.Text))
            {
                erpDiaSemana.SetError(txtDiaSemana, "Seleccione o escriba el día de la semana");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtConductorPrincipal.Text))
            {
                erpConductorPrincipal.SetError(txtConductorPrincipal, "El conductor principal es obligatorio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                var horario = new HorarioPrograma
                {
                    idCanal = (int)cbxCanal.SelectedValue,
                    tipo = cbxTipo.Text.Trim(),
                    titulo = txtTitulo.Text.Trim(),
                    horaInicio = TimeSpan.Parse(mtbxHoraInicio.Text.Trim()),
                    horaFin = TimeSpan.Parse(mtbxHoraFin.Text.Trim()),
                    diaSemana = txtDiaSemana.Text.Trim(),
                    conductorPrincipal = txtConductorPrincipal.Text.Trim(),
                    usuarioRegistro = "usrparcial2"
                };

                try
                {
                    if (esNuevo)
                    {
                        horario.fechaRegistro = DateTime.Now;
                        horario.estado = (short)Estado.Activo;
                        HorarioProgramaCln.crear(horario);
                    }
                    else
                    {
                        horario.id = (int)dgvListarProgramas.CurrentRow.Cells["id"].Value;
                        HorarioProgramaCln.actualizar(horario);
                    }
                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Horario de programa guardado correctamente", "::: Mensaje - Parcial2Cmla :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "::: Error - Parcial2Cmla :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListarProgramas.CurrentRow.Cells["id"].Value;
            string titulo = dgvListarProgramas.CurrentRow.Cells["titulo"].Value.ToString();

            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el programa '{titulo}'?",
                "::: Confirmación - Parcial2Cmla :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                HorarioProgramaCln.eliminar(id, "usrparcial2");
                listar();
                MessageBox.Show("Programa dado de baja correctamente", "::: Mensaje - Parcial2Cmla :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListarProgramas.Columns[e.ColumnIndex].Name == "horaInicio" || dgvListarProgramas.Columns[e.ColumnIndex].Name == "horaFin")
            {
                if (e.Value != null && e.Value is TimeSpan span)
                {
                    e.Value = span.ToString(@"hh\:mm");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
