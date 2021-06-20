using System.Collections.Generic;
using csharp.Entities;
using csharp.Implementations;
using csharp.Validators;
using NUnit.Framework;

namespace csharp.Test
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(Items, new ProductFactory());
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}
