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
        public byte FunctionOption;

        [Required]
        public int Index;

        [Required]
        public string Name;

        [Required]
        public string Pin;

        [Required]
        public int CardNo;

        [Required]
        public byte TZ1, TZ2, TZ3, TZ4, Status;

        [Required]
        [DataType(DataType.Time)]
        public DateTime EndTime;
    }
}
