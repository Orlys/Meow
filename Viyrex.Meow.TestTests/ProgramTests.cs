using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Meow.Html.Elements;
using Meow.Html.Infrastructure;

namespace Meow.Test.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Resolve_A_Test()
        {
            var data = "dummy<a data-test=\"data-test\" class=\"test-class\" href=\"http://www.test.com/\">test</a>dummy";
            var result = MeowParser.Load(data).Resolve<A>().FirstOrDefault();

            Assert.IsNotNull(result);

            Assert.AreEqual(result.Data["test"], "data-test");
            Assert.AreEqual(result.Class, "test-class");
            Assert.AreEqual(result.Href, "http://www.test.com/");
            Assert.AreEqual(result.ElementContent, "test");
        }
    }
}