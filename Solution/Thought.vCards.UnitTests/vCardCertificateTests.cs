
using System;
using NUnit.Framework;
using Thought.vCards;

namespace Tests
{
    [TestFixture]
    public class vCardCertificateTests
    {

        [Test]
        public void EmptyString_KeyType()
        {

            vCardCertificate cert = new vCardCertificate();

            Assert.IsNull(
                cert.KeyType,
                "The string KeyType property should default to null.");

            cert.KeyType = null;

            Assert.IsNull(
                cert.KeyType,
                "The string KeyType should be null.");

        }

    }
}
