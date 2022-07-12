using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTEGRATION_LAYER_01.Model
{
    [Table("zdev")]
    public class Sdev
    {
        [Column("id")]
        public long id { get; set; }

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
