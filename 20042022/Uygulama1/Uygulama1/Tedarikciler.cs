//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uygulama1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tedarikciler
    {
        public int TNo { get; set; }
        public string TAdi { get; set; }
        public string TAdres { get; set; }
        public string TTel { get; set; }
        public int MalzemeId { get; set; }
    
        public virtual Malzeme Malzeme { get; set; }
    }
}
