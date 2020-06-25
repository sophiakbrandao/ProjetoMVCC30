using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMVCC30.DAL;
using ProjetoMVCC30.DTO;
using ProjetoMVCC30.BLL;


namespace ProjetoMVCC30
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_clienteC30DTO objDTO = new tbl_clienteC30DTO();
                tbl_ClienteC30BLL objBLL = new tbl_ClienteC30BLL();

                objDTO.Cpf_cliente = txtCpfC30.Text.Trim();
                objDTO.Nome_cliente = txtNomeC30.Text.Trim();
                objDTO.Nome_mae = txtMaeC30.Text.Trim();

                if (objBLL.Autenticar(objDTO.Cpf_cliente,objDTO.Nome_cliente,objDTO.Nome_mae))
                {
                    MessageBox.Show("Beneficiário localizado no banco de dados");
                }
                else
                {
                    MessageBox.Show("Beneficiário não Localizado no banco de dados");
                }
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Erro: \n" + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message);
            }

        }

        private void txtNomeC30_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpfC30_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
