using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoOrt.Models
{
    public class Informe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InformeId { get; set; }

        public int montoInicial { get; set; }
        public int cantGanadas { get; set; }

        public int cantPerdidas { get; set; }
        public int ganancia { get; set; }
        public int montoPerdida { get; set; }
    }
}
