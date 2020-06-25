using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCC30.DTO
{
    class tbl_clienteC30DTO
    {
        private int id_cliente, tp_usuario;
        private string nome_cliente, sobrenome_cliente,
            email_cliente, senha_cliente, cpf_cliente, nome_mae;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Tp_usuario { get => tp_usuario; set => tp_usuario = value; }
        public string Email_cliente { get => email_cliente; set => email_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Senha_cliente { get => senha_cliente; set => senha_cliente = value; }



        public string Cpf_cliente
        {

            set
            {
                if (value != string.Empty)
                {
                    this.cpf_cliente = value;
                }
                else
                {
                    throw new Exception("O CPF não pode ficar em branco!");
                }
            }
            get { return this.cpf_cliente; }
        }

        public string Nome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O nome não pode ficar em branco!");
                }
            }
            get { return this.nome_cliente; }
        }


        public string Nome_mae
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("O nome da mãe não pode ficar em branco!");
                }
            }
            get { return this.nome_mae; }
        }


    }
    
}
