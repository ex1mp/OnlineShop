using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Ordering.Data.Models.Buyer
{
    public class PaymentMethod
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public int UserId { get; set; }

        private string Alias { get; set; }

        private string CardNumber { get; set; }

        private string SecurityNumber { get; set; }

        private string CardHolderName { get; set; }

        public DateTime Expiration { get; set; }

        public CardType CardType { get; set; }
    }
}
