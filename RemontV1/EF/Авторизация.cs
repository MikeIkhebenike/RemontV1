namespace RemontV1.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Авторизация
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_auth { get; set; }

        [Key]
        [StringLength(50)]
        public string Логин { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }
    }
}
