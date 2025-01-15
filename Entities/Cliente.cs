using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Entities
{
    public class Cliente
    {
        #region Atributos
        private int idCliente;
        private string nome;
        private string email;
        private Endereco endereco;
        #endregion
        #region Contrutores
        //contrutor padrão
        public Cliente()
        {
            
        }
        //sobrecarga de contrutor
        public Cliente(int idCliente, string nome, string email)
        {
            this.idCliente = idCliente;
            this.nome = nome;
            this.email = email;
        }
        //sobre carga de construtor
        public Cliente(int idCliente, string nome, string email, Endereco endereco)
            : this(idCliente, nome, email)
        {
            this.endereco = endereco;
        }
        #endregion
        #region Encapsulamento
        public int IdCliente
        {
            set => idCliente = value; get => idCliente;
        }
        public string Nome
        {
            set => nome = value; get => nome;
        }
        public string Email
        {
            set => email = value; get => email;
        }
        public Endereco Endereco
        {
            set => endereco = value; get => endereco;
        }
        #endregion
    }
}
