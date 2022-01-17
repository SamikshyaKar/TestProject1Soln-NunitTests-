using System;
using System.Collections.Generic;

namespace TestProject1Proj
{
    internal class ShoppingCartManager
    {

        private List<addtocarditems> _shoppingcartItems;
        public ShoppingCartManager()
        {
            _shoppingcartItems = new List<addtocarditems>();

        }

        internal AddToCartResponse addtocart(addtoCartRequest request)
        {
            _shoppingcartItems.Add(request.item);

            return new AddToCartResponse()
            {

                //Items = new addtocarditems[] { request.item }

                Items = _shoppingcartItems.ToArray()
            };
        }
    }
}
