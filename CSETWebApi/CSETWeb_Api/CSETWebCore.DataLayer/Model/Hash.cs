﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSETWebCore.DataLayer
{
    [Table("Hash", Schema = "HangFire")]
    public partial class Hash
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Key { get; set; }
        [Required]
        [StringLength(100)]
        public string Field { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}