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
    }
}
