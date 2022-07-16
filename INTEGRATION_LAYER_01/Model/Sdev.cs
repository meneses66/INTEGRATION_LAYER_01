using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTEGRATION_LAYER_01.Model
{
    [Table("zdev")]
    public class Sdev
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

        [Column("nome")]
        public string nome { get; set; }

        [Column("codigo")]
        public long codigo { get; set; }

        [Column("numero")]
        public long numero { get; set; }

        [Column("flag")]
        public Boolean flag { get; set; }

        [Column("data")]
        public DateTime data { get; set; }

    }
}
