//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinectProyectoLaberinto.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public Usuarios()
        {
            this.Puntuaciones = new HashSet<Puntuaciones>();
        }
    
        public long IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public byte[] Foto { get; set; }
    
        public virtual ICollection<Puntuaciones> Puntuaciones { get; set; }
    }
}