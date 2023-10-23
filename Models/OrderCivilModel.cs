using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.Models
{
    public class OrderCivilModel
    {
        [Key]
        public int OrderCivilId { get; set; }
        public string CardID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Address { get; set; }
        public string governorate { get; set; }
        public string region { get; set; }
        public string card_type { get; set; }
        public string service_type { get; set; }
        public string payment_method { get; set; }
        public byte[] Photo1 { get; set; }
        public byte[] Photo2 { get; set; }
        public string Notes { get; set; }
        public bool IsPaid { get; set; }
        public string Date { get; set; }
        public string OrderType { get; set; }
        public Boolean Confirmed { get; set; }
        public string BirthDate { get; set; }
        public string Kind { get; set; }
        public string Religion { get; set; }
        public string SocialStatus { get; set; }
        public string qualification { get; set; }
    }
}
