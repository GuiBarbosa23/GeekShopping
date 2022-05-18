using GeekShopping.CartAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Model
{
    [Table("CART_HEADER")]
    public class CartHeader : BaseEntity
    {
        [Column("user_id")]
        public string UserID { get; set; }
        [Column("coupon_code")]
        public string CouponCode { get; set; }
    }
}
