﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentAVilla_VillaAPI.Models.Dto
{
    public class VillaNumberUpdateDTO
    {

        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; }
    }
}
