﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MagreToutV2.Models
{
    [Table("DemoContactPerson")]
    public partial class DemoContactPerson
    {
        [Key]
        public int ContactPersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public int? PickupPointId { get; set; }

        [ForeignKey(nameof(PickupPointId))]
        [InverseProperty(nameof(DemoPickupPoint.DemoContactPeople))]
        public virtual DemoPickupPoint PickupPoint { get; set; }
    }
}