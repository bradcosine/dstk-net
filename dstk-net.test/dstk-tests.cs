using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dstk.net;
namespace dstk.net.test
{
    [TestFixture]
    public class DstkTests
    {
        [Test]
        public void Street2AddressTest()
        {
            DSTK d = new DSTK();
            var result = d.street2coordinates("8852 W. Sunset Blvd, Los Angeles, CA 90069");
            Assert.AreEqual("8852 W Sunset Blvd", result.location.First().street_address);
        }

        [Test]
        public void Street2AddressArrayTest()
        {
            List<string> addrs = new List<string>();

            addrs.Add("225 W SOLA ST, SANTA BARBARA, CA 93101");
            addrs.Add("24 CALLE CAPISTRANO, SANTA BARBARA, CA 93105");
            addrs.Add("123 OCEANO AVE APT 5, SANTA BARBARA, CA 93109");

            DSTK d = new DSTK();
            var result = d.street2coordinates(addrs.ToArray());

            Assert.IsNotEmpty(result);
        }
    }
}
