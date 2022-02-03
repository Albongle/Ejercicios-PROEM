using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Negocio_ADONET
{
    public partial class FrmNegocio : Form
    {
        Negocio negocio;
        public FrmNegocio()
        {
            InitializeComponent();
            this.negocio = new Negocio("Negocio 24HS");    
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.txtIdBuscar.Text);
                //Cliente cliente = this.negocio[id];
                //MessageBox.Show(cliente.ToString(), "Cliente encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmNegocio_Load(object sender, EventArgs e)
        {
            //this.dgvClientes.DataSource = this.negocio.Clientes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestorCliente frmGestor = new FrmGestorCliente(FrmGestorCliente.EGestorCliente.Alta);
            frmGestor.ShowDialog();
            if(frmGestor.DialogResult == DialogResult.OK)
            {
                try
                {
                    this.negocio += frmGestor.Cliente;
                    this.dgvClientes.DataSource = null;
                    //this.dgvClientes.DataSource = this.negocio.Clientes;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Alta cancelada", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente? cliente = this.dgvClientes.CurrentRow.DataBoundItem as Cliente;
            if(cliente is not null)
            {
                FrmGestorCliente frmGestor = new FrmGestorCliente(FrmGestorCliente.EGestorCliente.Modificacion);
                frmGestor.Cliente = cliente;
                frmGestor.ShowDialog();
                if (frmGestor.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        this.negocio |= frmGestor.Cliente;
                        this.dgvClientes.DataSource = null;
                        //this.dgvClientes.DataSource = this.negocio.Clientes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Modificacion cancelada", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun cliente para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente? cliente = this.dgvClientes.CurrentRow.DataBoundItem as Cliente;
            
            if(cliente != null)
            {
                try
                {
                    this.negocio -= cliente;
                    this.dgvClientes.DataSource = null;
                    //this.dgvClientes.DataSource = this.negocio.Clientes;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
