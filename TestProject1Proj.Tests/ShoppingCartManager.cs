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
            var itemexists = _shoppingcartItems.Find(i => i.ArticleID == request.item.ArticleID);

            if(itemexists !=null)
            {
                itemexists.Quantity += request.item.Quantity;

            }

            else
            {
                _shoppingcartItems.Add(request.item);
            }


            _shoppingcartItems.Add(request.item);

            return new AddToCartResponse()
            {

                //Items = new addtocarditems[] { request.item }

                Items = _shoppingcartItems.ToArray()
            };
        }
    }
}
