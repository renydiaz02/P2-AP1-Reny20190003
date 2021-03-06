using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Reny20190003.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string DescripcionProyecto { get; set; }
        public int Total { get; set; }

        [ForeignKey("ProyectoId")]
          public virtual List<ProyectosDetalles> Detalle { get; set; } = new List<ProyectosDetalles>();
    }
}
