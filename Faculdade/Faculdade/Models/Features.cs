//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faculdade.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Features
    {
        public int id_feature { get; set; }
        public int fuel_id { get; set; }
        public int door { get; set; }
        public bool air_conditioning { get; set; }
        public bool eletric_glass { get; set; }
        public bool eletric_lock { get; set; }
        public bool air_bag { get; set; }
        public bool hydraulic_steering { get; set; }
        public bool automatic { get; set; }
        public bool abs { get; set; }
        public int passengers { get; set; }
        public float trunk { get; set; }
    }
}
