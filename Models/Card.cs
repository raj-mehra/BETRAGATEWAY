using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BETRAGATEWAY.Models
{
    public class Card
    {
        public string Id { get; set; }

        [Required]
        public byte FunctionOption { get; set; }

        [Required]
        public int Index { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Pin { get; set; }

        [Required]
        public int CardNo { get; set; }

        [Required]
        public byte TZ1 { get; set; }

        [Required]
        public byte TZ2 { get; set; }

        [Required] 
        public byte TZ3 { get; set; }

        [Required] 
        public byte TZ4 { get; set; }

        [Required] 
        public byte Status { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
    }
}
