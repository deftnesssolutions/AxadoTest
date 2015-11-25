using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Axado.Entities
{
    public class CarriersEntity
    {
        public int id_carrier { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public string inscr_estadual { get; set; }
        public string nro_placa { get; set; }
        public string estado_placa { get; set; }
        public int id_classificacao { get; set; }
    }
}
