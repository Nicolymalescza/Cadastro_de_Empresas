using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEmpresas
{
    public class Empresas
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public string RegimeTributario { get; set; }
        public string DataInicioATT { get; set; }
        public string TelefoneEmpresa { get; set; }
        public string CapitalSocial { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string MatrizFilial { get; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJuridica { get; set; }
        public string NomeProprietario { get; set; }
        public string CPFProprietario { get; set; }

        public Empresas(string cNPJ, string razaoSocial, string nomeFantasia,
            string situacaoCadastral, string regimeTributario, string dataInicioATT,
            string telefone, string capitalSocial, string bairro, string rua,
            string numero, string estado, string complemento, string cep, string matrizFilial,
            string porteEmpresa, string naturezaJuridica, string nomeProprietario, string cPFProprietario)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            SituacaoCadastral = situacaoCadastral;
            RegimeTributario = regimeTributario;
            DataInicioATT = dataInicioATT;
            TelefoneEmpresa = telefone;
            CapitalSocial = capitalSocial;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            Estado = estado;
            Complemento = complemento;
            Cep = cep;
            MatrizFilial = matrizFilial;
            PorteEmpresa = porteEmpresa;
            NaturezaJuridica = naturezaJuridica;
            NomeProprietario = nomeProprietario;
            NomeProprietario = nomeProprietario;
        }
        public Empresas()
        { }
    }
}
