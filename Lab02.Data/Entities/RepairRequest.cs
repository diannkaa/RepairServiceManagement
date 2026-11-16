using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Data.Entities
{
    public class RepairRequest
    {
        [Key]
        public int RequestId { get; set; }

        public int ClientId { get; set; }

        public int MasterId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DeviceModel { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Problem { get; set; } = string.Empty;

        public DateTime RequestDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal? RepairCost { get; set; }

        public Client Client { get; set; } = null!;
        public Master Master { get; set; } = null!;
    }
}
