﻿using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class Overtime : OtherBaseEntity
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int NumberOfDays => (EndDate - StartDate).Days;

        //vacation type ile çoğun bire ilişkisi
        public OvertimeType? OvertimeType { get; set; }
        public int OvertimeTypeId { get; set; }
    }
}
