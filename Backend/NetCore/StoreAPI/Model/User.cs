﻿namespace StoreAPI.Model
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<Address> ShippingAddresses { get; set; } = new List<Address>();
        public List<Address> BillingAddresses { get; set; } = new List<Address>();
        [ForeignKey("DefaultShippingAddress")]
        public virtual int? DefaultShippingAddressId { get; set; }
        public virtual Address? DefaultShippingAddress { get; set; }
        [ForeignKey("DefaultBillingAddress")]
        public virtual int? DefaultBillingAddressId { get; set; }
        public virtual Address? DefaultBillingAddress { get; set; }
        [ForeignKey(nameof(Cart))]
        public int? CartId { get; set; }
        public virtual Cart? Cart { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Product> MyProducts { get; set; } = new List<Product>();
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
