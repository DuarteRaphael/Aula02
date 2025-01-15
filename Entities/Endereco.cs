using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Entities
{
    public class Endereco
    {
        #region Atributos
        private int idEndereco;
        private string logradouro;
        private string cidade;
        private string estado;
        private string cep;
        #endregion
        #region Construtores
        //construtor default
        public Endereco()
        {
            
        }

        //sobrecarga de construtor
        public Endereco(int idEndereco, string logradouro, string cidade, string estado, string cep)
        {
            this.idEndereco = idEndereco;
            this.logradouro = logradouro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
        }
        #endregion
        #region Encapsulamento
        //public int IdEndereco
        //{
        //    set { idEndereco = value; } //entrada
        //    get { return idEndereco; } //saída
        //}
        public int IdEndereco
        {
            set => idEndereco = value; get => idEndereco;
        }
        public string Logradouro
        {
            set { logradouro = value; } //entrada
            get { return logradouro; } //saída
        }
        public string Cidade
        {
            set { cidade = value; } //entrada
            get { return cidade; } //saída
        }
        public string Estado
        {
            set { estado = value; } //entrada
            get { return estado; } //saída
        }
        public string Cep
        {
            set { cep = value; } //entrada
            get { return cep; } //saída
        }

        #endregion
    }
}