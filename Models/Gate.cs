using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BETRAGATEWAY.Models
{
    public class Gate
    {
        public string Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string ControllerId { get; set; }

        [Required]
        public int Port { get; set; }

        [Required]
        public bool GateOpen { get; set; }

        [Required]
        public ICollection<Card> Cards { get; set; }
    }
}
