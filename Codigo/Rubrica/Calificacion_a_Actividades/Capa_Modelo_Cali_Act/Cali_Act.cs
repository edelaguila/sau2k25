using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Cali_Act
{
    public class Cali_Act
    {
        public int iId { get; set; }            // pk_id
        public int iNombreAuditado { get; set; }     // nombre del auditado
        public int iNombreAuditor { get; set; }     // nombre del auditor
        public int iNombreActividad { get; set; }   // nombre de la actividad
        public int iNotaActividad { get; set; }   // punteo
    }
}
