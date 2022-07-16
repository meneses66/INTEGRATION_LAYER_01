using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace INTEGRATION_LAYER_01.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long id { get; set; }

        [Column("login_criador")]
        public string login_criador { get; set; }

        [Column("login_atualizador")]
        public string login_atualizador { get; set; }

        [Column("data_criado")]
        public DateTime data_criado { get; set; }

        [Column("data_atualizado")]
        public DateTime data_atualizado { get; set; }

    }
}
