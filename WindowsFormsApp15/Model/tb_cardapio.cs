//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp15.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cardapio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cardapio()
        {
            this.tb_comanda_item = new HashSet<tb_comanda_item>();
        }
    
        public int id_cardapio { get; set; }
        public int id_categoria { get; set; }
        public int nm_refeicao { get; set; }
        public string ds_descricao { get; set; }
        public decimal vl_valor { get; set; }
        public byte[] img_refeicao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_comanda_item> tb_comanda_item { get; set; }
    }
}
