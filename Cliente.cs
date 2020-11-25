using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteModel
{
    class Cliente
    {
        private string nome;
        private bool status;
        private int cpf;
        private int fixo;
        private int cel;
        private string end;
        private string cidade;
        private string estado;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public int Fixo
        {
            get
            {
                return fixo;
            }

            set
            {
                fixo = value;
            }
        }

        public int Cel
        {
            get
            {
                return cel;
            }

            set
            {
                cel = value;
            }
        }

        public string End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
