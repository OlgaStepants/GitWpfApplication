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
    
    public partial class Аудиофайлы
    {
        public int Код_аудиофайла { get; set; }
        public string Название { get; set; }
        public Nullable<int> Код_жанра { get; set; }
        public Nullable<int> Код_исполнителя { get; set; }
        public Nullable<int> Код_альбома { get; set; }
        public Nullable<int> Код_языка { get; set; }
    
        public virtual Альбомы Альбомы { get; set; }
        public virtual Жанры Жанры { get; set; }
        public virtual Исполнители Исполнители { get; set; }
        public virtual Языки Языки { get; set; }
    }
}
