//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Исполнители
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Исполнители()
        {
            this.Аудиофайлы = new HashSet<Аудиофайлы>();
        }
    
        public int Код_исполнителя { get; set; }
        public string Имя { get; set; }
        public string Страна { get; set; }
        public string Краткая_биография { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аудиофайлы> Аудиофайлы { get; set; }
    }
}
