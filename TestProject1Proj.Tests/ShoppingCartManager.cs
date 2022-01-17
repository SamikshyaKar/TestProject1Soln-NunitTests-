using System;

namespace TestProject1Proj
{
    internal class ShoppingCartManager
    {
        public ShoppingCartManager()
        {
        }

        internal AddToCartResponse addtocart(addtoCartRequest request)
        {
            return new AddToCartResponse()
            {

                Items = new addtocarditems[] { request.item }
            };
        }
    }
}
