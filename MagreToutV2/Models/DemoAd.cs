﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MalgreToutV2.Models
{
    [Table("DemoAd")]
    public partial class DemoAd
    {
        public DemoAd()
        {
            DemoMagazines = new HashSet<DemoMagazine>();
        }

        [Key]
        public int AdId { get; set; }
        [Required]
        [StringLength(255)]
        public string Company { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? AdPrice { get; set; }

        [InverseProperty(nameof(DemoMagazine.Ad))]
        public virtual ICollection<DemoMagazine> DemoMagazines { get; set; }
    }
}