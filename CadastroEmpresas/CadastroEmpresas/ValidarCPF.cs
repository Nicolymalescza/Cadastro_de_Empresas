using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEmpresas
{
    public class ValidarCPF
    {
        public static bool ValidaCPF(string stringCpf)
        {
            string cpfSemTraco = stringCpf.Replace(".", "");
            cpfSemTraco = cpfSemTraco.Replace("-", "");

            if (cpfSemTraco.Length != 11)
            {
                return false;
            }

            int soma = 0;
            int soma2 = 0;
            int cont = 10;
            int cont2 = 11;


            for (int i = 0; i < cpfSemTraco.Length - 2; i++)
            {
                soma += Convert.ToInt32(cpfSemTraco[i].ToString()) * cont;
                cont--;
            }


            if (soma % 11 < 2)
            {
                int digito1 = 0;
                if (digito1 != Convert.ToInt32(cpfSemTraco[9].ToString()))
                {
                    return false;
                }

                for (int i = 0; i < cpfSemTraco.Length - 1; i++)
                {
                    soma2 += Convert.ToInt32(cpfSemTraco[i].ToString()) * cont2;
                    cont2--;
                }
                if (soma2 % 11 < 2)
                {
                    int digito2 = 0;
                    if (digito2 != Convert.ToInt32(cpfSemTraco[10].ToString()))
                    {
                        return false;
                    }
                    return true;
                }
                else if (soma2 % 11 >= 2)
                {
                    int digito2 = 11 - (soma2 % 11);

                    if (digito2 != Convert.ToInt32(cpfSemTraco[10].ToString()))
                    {
                        return false;
                    }
                    return true;
                }
                
            }


            else if (soma % 11 >= 2)
            {
                int digito1 = 11 - (soma % 11);

                if (digito1 != Convert.ToInt32(cpfSemTraco[9].ToString()))
                {
                    return false;
                }

                for (int i = 0; i < cpfSemTraco.Length - 1; i++)
                {
                    soma2 += Convert.ToInt32(cpfSemTraco[i].ToString()) * cont2;
                    cont2--;
                }

                if (soma2 % 11 < 2)
                {
                    int digito2 = 0;
                    if (digito2 != Convert.ToInt32(cpfSemTraco[10].ToString()))
                    {
                        return false;
                    }
                    return true;
                }
                else if (soma2 % 11 >= 2)
                {
                    int digito2 = 11 - (soma2 % 11);

                    if (digito2 != Convert.ToInt32(cpfSemTraco[10].ToString()))
                    {
                        return false;
                    }

                    return true;
                }
            }
            return true;
        }
    }
}