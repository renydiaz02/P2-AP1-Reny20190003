using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Reny20190003.Entidades
{
    public class ProyectosDetalles
    {
        [Key]
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public int TipoTareaId { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }

        [ForeignKey("TipoTareaId")]
        public TiposTareas TiposTarea { get; set; }
        public Proyectos Proyecto { get; set; }

        public ProyectosDetalles()
        {
            Id = 0;
            ProyectoId = 0;
            TipoTareaId = 0;
            Requerimiento = string.Empty;
            Tiempo = 0;
            TiposTarea = null;
            Proyecto = null;
        }

        public ProyectosDetalles(int proy, int tipo, string req, int tiempo, TiposTareas t, Proyectos pro)
        {
            Id = 0;
            ProyectoId = proy;
            TipoTareaId = tipo;
            Requerimiento = req;
            Tiempo = tiempo;
            TiposTarea = t;
        }
    }
}
