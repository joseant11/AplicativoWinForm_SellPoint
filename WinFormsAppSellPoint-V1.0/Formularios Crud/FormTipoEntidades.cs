using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Layers.Framework.ADO.NET.Presentation;
using Layers.Framework.ADO.NET.Data;
namespace WinFormsAppSellPoint_V1._0.Formularios_Crud
{
    public partial class FormTipoEntidades : Form
    {
        public FormTipoEntidades()
        {
            InitializeComponent();
            CargarGrupoEntidades();
        }

        //Metodo para llenar el comboBox con Grupos de Entidades
        public void CargarGrupoEntidades()
        {
            try
            {
                DataTable SQLdatatable = new DataTable();
                ClassData.SQLDataAdapter(
                    ClassData.sqlCommand("Select IdGrupoEntidad,Descripcion from GrupoEntidades",
                    CommandType.Text)).Fill(SQLdatatable);


                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();

                DataRow SQLDataRow = SQLdatatable.NewRow();
                SQLDataRow["Descripcion"] = "Selecciona un grupo de Entidad";
                SQLdatatable.Rows.InsertAt(SQLDataRow, 0);

                comboBoxGrupoEnt.ValueMember = "IdGrupoEntidad";
                comboBoxGrupoEnt.DisplayMember = "Descripcion";
                comboBoxGrupoEnt.DataSource = SQLdatatable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Evento del INSERT
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            ClassData.RegistroTipoEntidad(
                    comboBoxTipoEntidad.Text.ToString(), comboBoxGrupoEnt.Text,
                    textBoxComment.Text.ToString(), comboBoxEstatus.Text.ToString(),
                    Convert.ToByte(comboBoxEliminable.SelectedIndex));

            MessageBox.Show("Datos introducidos existosamente");
        }

        //Evento del SELECT
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable SQLdatatable = new DataTable();

                if (textBoxIdTipoEntidadesBuscar.Text.Trim() != "" || textBoxNombreTipoEntidadBuscar.Text.Trim() != "")
                {
                    ClassData.SQLDataAdapter(
                        ClassData.sqlCommand("SpBuscarTipoEntidad'"
                        + Convert.ToInt32(textBoxIdTipoEntidadesBuscar.Text) + "'," +
                        "'" + textBoxNombreTipoEntidadBuscar.Text + "'",
                        CommandType.Text)).Fill(SQLdatatable);
                }

                else
                {
                    ClassData.SQLDataAdapter(
                 ClassData.sqlCommand("SpBuscarTipoEntidadSinParametros",
                 CommandType.Text)).Fill(SQLdatatable);
                }

                dataGridView1.DataSource = SQLdatatable;
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Evento del UPDATE
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ClassData.EditarTipoEntidad(Convert.ToInt32(textBoxIdTipoEntidad.Text),
                comboBoxTipoEntidad.Text.ToString(), comboBoxGrupoEnt.Text,
                textBoxComment.Text.ToString(), comboBoxEstatus.Text.ToString(),
                comboBoxEliminable.SelectedIndex);

            MessageBox.Show("Datos editados existosamente");
        }

        //Evento del DELETE
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ClassData.EliminarTipoEntidad(Convert.ToInt32(textBoxIdTipoEntidadesBuscar.Text), textBoxNombreTipoEntidadBuscar.Text.ToString());

            MessageBox.Show("Datos eliminados existosamente");
        }

        //Evento para traer registros a los campos y luego poder editarlos
        private void buttonBuscarEntidad_Click(object sender, EventArgs e)
        {
            ClassData.LlenarTipoEntidad(Convert.ToInt32(textBoxIdTipoEntidad.Text));

            comboBoxTipoEntidad.Text = String.Empty;
            comboBoxTipoEntidad.Text =ClassData.Descripcion;
            comboBoxGrupoEnt.Text = String.Empty;
            comboBoxGrupoEnt.Text = ClassData.GrupoEntidad;
            textBoxComment.Text = ClassData.Comentario;
            comboBoxEstatus.Text = ClassData.Status;
            comboBoxEliminable.SelectedIndex = ClassData.NoEliminable;
        }
    }
}
