using INTEGRATION_LAYER_01.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTEGRATION_LAYER_01.Model
{
    [Table("racas")]
    public class Raca : BaseEntity
    {
        [Column("tipo")]
        public string tipo { get; set; }

        [Column("raca")]
        public string raca { get; set; }

    }
}
