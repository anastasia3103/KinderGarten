//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinderGarten.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int Id { get; set; }
        public System.DateTime DateZan { get; set; }
        public int IsGroupDS { get; set; }
        public int IdActivity { get; set; }
        public Nullable<int> IdMark { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual GroupDS GroupDS { get; set; }
        public virtual Mark Mark { get; set; }
    }
}
