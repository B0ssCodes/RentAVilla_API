﻿using RentAVilla_VillaAPI.Models.Dto;

namespace RentAVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{ Id = 1, Name = "Nigger Viller", Sqft=100, Occupancy=4 },
                new VillaDTO{ Id = 2, Name = "Nigga Villa", Sqft=300, Occupancy=3 }
            };
    }
}
