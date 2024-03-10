using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Api.src.Entities;


    public class CartDetail
    {
        public long Id { get; set; }
        public long CartHeaderId { get; set; }
        public  CartHeader CartHeader { get; set; }
        public long ProductId { get; set; }
        public  Product Product { get; set; }
        public int Count { get; set; }
    }
