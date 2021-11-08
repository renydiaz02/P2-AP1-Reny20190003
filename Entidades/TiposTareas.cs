using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Reny20190003.Entidades
{
    public class TiposTareas
    {
        [Key]

        public int TipoTareaId { get; set; }
        public string Descripcion { get; set; }
        public int Tiempo { get; set; }
    }
}
