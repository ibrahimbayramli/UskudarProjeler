﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OkulEntities : DbContext
    {
        public OkulEntities()
            : base("name=OkulEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }
    
        public virtual int OAdd(string adSoyad, string tcNo, string telefon, string mail, string adres)
        {
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var tcNoParameter = tcNo != null ?
                new ObjectParameter("TcNo", tcNo) :
                new ObjectParameter("TcNo", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OAdd", adSoyadParameter, tcNoParameter, telefonParameter, mailParameter, adresParameter);
        }
    
        public virtual ObjectResult<OG_Result> OG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OG_Result>("OG");
        }
    
        public virtual int OSL(Nullable<int> ogrenciNo)
        {
            var ogrenciNoParameter = ogrenciNo.HasValue ?
                new ObjectParameter("OgrenciNo", ogrenciNo) :
                new ObjectParameter("OgrenciNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OSL", ogrenciNoParameter);
        }
    
        public virtual int OY(Nullable<int> ogrenciNo, string adSoyad, string tcNo, string telefon, string mail, string adres)
        {
            var ogrenciNoParameter = ogrenciNo.HasValue ?
                new ObjectParameter("OgrenciNo", ogrenciNo) :
                new ObjectParameter("OgrenciNo", typeof(int));
    
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var tcNoParameter = tcNo != null ?
                new ObjectParameter("TcNo", tcNo) :
                new ObjectParameter("TcNo", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OY", ogrenciNoParameter, adSoyadParameter, tcNoParameter, telefonParameter, mailParameter, adresParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
