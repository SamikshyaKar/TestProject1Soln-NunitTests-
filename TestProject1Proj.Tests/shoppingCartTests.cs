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

        [Test]

        public void shouldreturnarticlseaddedtocart()
        {
            var item1 = new addtocarditems()
            {
                ArticleID = 45,
                Quantity = 5
            };


            var request = new addtoCartRequest()
            {
                item = item1
            };

            var manager = new ShoppingCartManager();
            AddToCartResponse response = manager.addtocart(request);

            var item2 = new addtocarditems()
            {
                ArticleID = 48,
                Quantity = 5
            };


             request = new addtoCartRequest()
            {
                item = item2
            };
            response = manager.addtocart(request);

            Assert.NotNull(response);
            Assert.Contains(item1, response.Items);
            Assert.Contains(item2, response.Items);

        }

        //public void shouldreturnarticlesaadedtocars()
        //{

        //    var item1 = new addtocarditems
        //    {
        //        ArticleID = 45,
        //        Quantity = 10
        //    };

        //    var item2 = new addtocarditems
        //    {
        //        ArticleID = 46,
        //        Quantity = 20
        //    };

        //    var request = new addtoCartRequest()
        //    {
        //        item = item1

        //    };

        //    request = new addtoCartRequest()
        //    {
        //        item = item2
        //    };

        //    var manager = new ShoppingCartManager();
        //    AddToCartResponse response = manager.addtocart( request);
        //    response = manager.addtocart(request);

        //    Assert.IsNull(response);
        //    Assert.Contains(item1, response.Items);
        //    Assert.Contains(item2, response.Items);



        //}


    }
}
