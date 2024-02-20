using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEmpresas
{
    public partial class Form2 : Form
    {
        List<Empresas> listaEmpresas = new List<Empresas>();
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tx_razaoSocial.Text = string.Empty;
            tx_nomeFantasia.Text = string.Empty;
            masked_cnpj.Text = string.Empty;
            masked_telefoneEmpresa.Text = string.Empty;
            tx_bairro.Text = string.Empty;
            tx_rua.Text = string.Empty;
            cb_estado.Text = string.Empty;
            tx_numero.Text = string.Empty;
            tx_complemento.Text = string.Empty;
            masked_cep.Text = string.Empty;
            datetime_inicioAtt.Text = string.Empty;
            numeric_capitalSocial.Text = string.Empty;
            cb_situacaoCadastral.Text = string.Empty;
            cb_naturezaJuridica.Text = string.Empty;
            rdbt_tributarioSimples.Checked = false; //verifica e coloca como falso(ou seja, sem marcação)
            rdbt_tributarioNacional.Checked = false;
            rdbt_tributarioPresumido.Checked = false;
            rdbt_tributarioReal.Checked = false;
            rdbt_portePequeno.Checked = false;
            rdbt_porteMedio.Checked = false;
            rdbt_porteGrande.Checked = false;
            rdbt_tipoMatriz.Checked = false;
            rdbt_tipoFilial.Checked = false;
            tx_nomeProprietario.Text = string.Empty;
            masked_cpf.Text = string.Empty;
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampus())
                {
                    Empresas empresa = new Empresas();
                    empresa.CNPJ = masked_cnpj.Text;
                    empresa.RazaoSocial = tx_razaoSocial.Text;
                    empresa.NomeFantasia = tx_nomeFantasia.Text;
                    empresa.SituacaoCadastral = cb_situacaoCadastral.Text;
                    empresa.RegimeTributario = rdbt_tributarioSimples.Text;
                    empresa.RegimeTributario = rdbt_tributarioNacional.Text;
                    empresa.RegimeTributario = rdbt_tributarioPresumido.Text;
                    empresa.RegimeTributario = rdbt_tributarioReal.Text;
                    empresa.DataInicioATT = datetime_inicioAtt.Text;
                    empresa.TelefoneEmpresa = masked_telefoneEmpresa.Text;
                    empresa.CapitalSocial = numeric_capitalSocial.Text;
                    empresa.Bairro = tx_bairro.Text;
                    empresa.Rua = tx_rua.Text;
                    empresa.Numero = tx_numero.Text;
                    empresa.Estado = cb_estado.Text;
                    empresa.Complemento = tx_complemento.Text;
                    empresa.Cep = masked_cep.Text;
                    empresa.MatrizFilial = rdbt_tipoMatriz.Text;
                    empresa.MatrizFilial = rdbt_tipoFilial.Text;
                    empresa.PorteEmpresa = rdbt_portePequeno.Text;
                    empresa.PorteEmpresa = rdbt_porteMedio.Text;
                    empresa.PorteEmpresa = rdbt_porteGrande.Text;
                    empresa.NaturezaJuridica = cb_naturezaJuridica.Text;
                    empresa.NomeProprietario = tx_nomeProprietario.Text;

                    if (ValidarCPF.ValidaCPF(masked_cpf.Text))
                    {
                        empresa.CPFProprietario = masked_cpf.Text;
                        listaEmpresas.Add(empresa);
                        dataGridView1.DataSource = null;//add (DataSource tipo de lugar onde sera guardado as informações)
                        dataGridView1.Refresh();//os elementos no data grid (Refresh pra atualizar a tabela)
                        dataGridView1.DataSource = listaEmpresas;
                    }
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo errado aconteceu");
            }
        }


        private void bt_excluir_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;//pega o index(celula) da tabela
            listaEmpresas.RemoveAt(index);
            dataGridView1.DataSource = null;//deixa nulo
            dataGridView1.Refresh();//atualiza
            dataGridView1.DataSource = listaEmpresas;
        }





        private bool ValidaCampus()
        {
            bool estado = true;
            if (tx_razaoSocial.Text == "") //ou String.Empty = string vazia
            {
                estado = false;
                errorProvider1.SetError(tx_razaoSocial, "Campo obrigatório!");
            }
            if (tx_nomeFantasia.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_nomeFantasia, "Campo obrigatório!");
            }
            if (masked_cnpj.Text == "")
            {
                estado = false;
                errorProvider1.SetError(masked_cnpj, "Campo obrigatório!");
            }
            if (masked_telefoneEmpresa.Text == "")
            {
                estado = false;
                errorProvider1.SetError(masked_telefoneEmpresa, "Campo obrigatório!");
            }
            if (tx_bairro.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_bairro, "Campo obrigatório!");
            }
            if (tx_rua.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_rua, "Campo obrigatório!");
            }
            if (cb_estado.Text == "")
            {
                estado = false;
                errorProvider1.SetError(cb_estado, "Campo obrigatório!");
            }
            if (tx_numero.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_numero, "Campo obrigatório!");
            }
            if (tx_complemento.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_complemento, "Campo obrigatório!");
            }
            if (masked_cep.Text == "")
            {
                estado = false;
                errorProvider1.SetError(masked_cep, "Campo obrigatório!");
            }
            if (numeric_capitalSocial.Text == "")
            {
                estado = false;
                errorProvider1.SetError(numeric_capitalSocial, "Campo obrigatório!");
            }
            if (numeric_capitalSocial.Text == "")
            {
                estado = false;
                errorProvider1.SetError(numeric_capitalSocial, "Campo obrigatório!");
            }
            if (cb_situacaoCadastral.Text == "")
            {
                estado = false;
                errorProvider1.SetError(cb_situacaoCadastral, "Campo obrigatório!");
            }
            if (cb_naturezaJuridica.Text == "")
            {
                estado = false;
                errorProvider1.SetError(cb_naturezaJuridica, "Campo obrigatório!");
            }
            if (cb_naturezaJuridica.Text == "")
            {
                estado = false;
                errorProvider1.SetError(cb_naturezaJuridica, "Campo obrigatório!");
            }
            if (tx_nomeProprietario.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tx_nomeProprietario, "Campo obrigatório!");
            }
            if (masked_cpf.Text == "")
            {
                estado = false;
                errorProvider1.SetError(masked_cpf, "Campo obrigatório!");
            }

            return estado;

        }
    }
}