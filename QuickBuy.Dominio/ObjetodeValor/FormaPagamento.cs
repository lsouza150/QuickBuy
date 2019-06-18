using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetodeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        { get
            {
                return Id == (int)TipoFormaPagamentoEnum.Boleto;
            }
        }
        public bool EhCartaoCredito
        { get
            {
                return Id == (int)TipoFormaPagamentoEnum.CataoCredito;
            }
        }

        public bool EhDeposito
        { get
            {
                return Id == (int)TipoFormaPagamentoEnum.Deposito;
            }
        }

        public bool EhNaoFoiDefinido
        { get
            {
                return Id == (int)TipoFormaPagamentoEnum.NaoDefinido;
            }
        }


    }   
}
 