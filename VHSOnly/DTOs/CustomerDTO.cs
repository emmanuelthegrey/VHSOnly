﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VHSOnly.Models;

namespace VHSOnly.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
       
        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
    }
}