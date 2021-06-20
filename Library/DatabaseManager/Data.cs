namespace DatabaseManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data
    {
        [Key]
        public int idTransaction { get; set; }

        public int userId { get; set; }

        public int categoryId { get; set; }

        public int recepientId { get; set; }

        public int CashChange { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual Recepients Recepients { get; set; }

        public virtual Users Users { get; set; }
    }
}
