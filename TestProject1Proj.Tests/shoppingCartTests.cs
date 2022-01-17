using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Proj
{
    class shoppingCartTests
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void shouldreturnarticleaddedtocart()
        {
            var item = new addtocarditems
            {
                ArticleID = 43,
                Quantity = 5
            };


            var request = new addtoCartRequest()
            {
                item = item
            };

            var manager = new ShoppingCartManager();
            AddToCartResponse response = manager.addtocart(request);

            Assert.NotNull(response);
            Assert.Contains(item, response.Items);

        }



    
    }
}
