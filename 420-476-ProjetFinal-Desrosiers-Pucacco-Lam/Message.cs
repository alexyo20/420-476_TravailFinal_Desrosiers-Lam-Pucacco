//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _420_476_ProjetFinal_Desrosiers_Pucacco_Lam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int id { get; set; }
        public int targetUserId { get; set; }
        public string message1 { get; set; }
        public int sourceUserId { get; set; }
        public string title { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
