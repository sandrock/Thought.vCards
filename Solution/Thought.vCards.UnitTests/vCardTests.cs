
using System;
using System.IO;
using NUnit.Framework;
using Thought.vCards;

namespace Tests
{

    [TestFixture]
    public class vCardTests
    {

        // The next set of tests valid each simple property
        // of the vCard class.  Each test writes a value to
        // the property, then confirms the same value is
        // returned.  This is primarily intended to catch
        // capitalization types -- e.g. the code for the
        // property writes back to itself insteaed of the
        // underlying field (which causes an infinite loop).

        #region [ ReadWriteProperty_AdditionalNames ]

        [Test]
        public void ReadWriteProperty_AdditionalNames()
        {

            // Make sure .AdditionalNames reads/writes

            vCard card = new vCard();
            card.AdditionalNames = "John";

            Assert.AreEqual(
                "John",
                card.AdditionalNames,
                "The AdditionalNames property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_BirthDate ]

        [Test]
        public void ReadWriteProperty_BirthDate()
        {

            vCard card = new vCard();
            card.BirthDate = DateTime.Parse("04/04/04");

            Assert.AreEqual(
                DateTime.Parse("04/04/04"),
                card.BirthDate.Value,
                "The BirthDate property was not set.");

            card.BirthDate = null;

            Assert.IsNull(
                card.BirthDate,
                "The BirthDate property was not set to null.");

        }

        #endregion

        #region [ ReadWriteProperty_Department ]

        [Test]
        public void ReadWriteProperty_Department()
        {

            vCard card = new vCard();
            card.Department = "DOD";

            Assert.AreEqual(
                "DOD",
                card.Department,
                "The Department property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_FamilyName ]

        [Test]
        public void ReadWriteProperty_FamilyName()
        {
            
            // Make sure .FamilyName reads/writes

            vCard card = new vCard();
            card.FamilyName = "Tchaikovsky";

            Assert.AreEqual(
                "Tchaikovsky",
                card.FamilyName,
                "The FamilyName property does not return the same value written to it.");

        }

        #endregion

        #region [ ReadWriteProperty_FormattedName ]

        [Test]
        public void ReadWriteProperty_FormattedName()
        {
            // Make sure .FormattedName reads/writes

            vCard card = new vCard();
            card.FormattedName = "Sir Isaac Newton";

            Assert.AreEqual(
                "Sir Isaac Newton",
                card.FormattedName,
                "The FormattedName property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_Gender ]

        [Test]
        public void ReadWriteProperty_Gender()
        {

            vCard card = new vCard();
            card.Gender = vCardGender.Male;

            Assert.AreEqual(
                vCardGender.Male,
                card.Gender,
                "The Gender property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_GivenName ]

        [Test]
        public void ReadWriteProperty_GivenName()
        {

            // Make sure .GivenName reads/writes

            vCard card = new vCard();
            card.GivenName = "Homer";

            Assert.AreEqual(
                "Homer",
                card.GivenName,
                "The GivenName property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Mailer ]

        [Test]
        public void ReadWriteProperty_Mailer()
        {

            vCard card = new vCard();
            card.Mailer = "RemoteAccess BBS";

            Assert.AreEqual(
                "RemoteAccess BBS",
                card.Mailer,
                "The Mailer property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_NamePrefix ]

        [Test]
        public void ReadWriteProperty_NamePrefix()
        {

            vCard card = new vCard();
            card.NamePrefix = "Dr.";

            Assert.AreEqual(
                "Dr.",
                card.NamePrefix,
                "The NamePrefix property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_Office ]

        [Test]
        public void ReadWriteProperty_Office()
        {

            vCard card = new vCard();
            card.Office = "Vice President's Office";

            Assert.AreEqual(
                "Vice President's Office",
                card.Office,
                "The Office property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_Organization ]

        [Test]
        public void ReadWriteProperty_Organzation()
        {

            // Make sure .Organization reads/writes

            vCard card = new vCard();
            card.Organization = "BBC";

            Assert.AreEqual(
                "BBC",
                card.Organization,
                "The Organization property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_ProductId ]

        [Test]
        public void ReadWriteProperty_ProductId()
        {

            vCard card = new vCard();
            card.ProductId = "vCard Library";

            Assert.AreEqual(
                "vCard Library",
                card.ProductId,
                "The ProductId property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_RevisionDate ]

        [Test]
        public void ReadWriteProperty_RevisionDate()
        {

            vCard card = new vCard();
            card.RevisionDate = DateTime.Parse("01/01/2001 01:01 AM");

            Assert.AreEqual(
                DateTime.Parse("01/01/2001 01:01 AM"),
                card.RevisionDate,
                "The RevisionDate property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_Role ]

        [Test]
        public void ReadWriteProperty_Role()
        {

            vCard card = new vCard();
            card.Role = "Candy Bar Tester";

            Assert.AreEqual(
                "Candy Bar Tester",
                card.Role,
                "The Role property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_TimeZone ]

        [Test]
        public void ReadWriteProperty_TimeZone()
        {
            vCard card = new vCard();
            card.TimeZone = "-05:00";
            Assert.AreEqual(
                "-05:00",
                card.TimeZone,
                "The TimeZone property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Title ]

        [Test]
        public void ReadWriteProperty_Title()
        {

            // The sure .Title reads/writes

            vCard card = new vCard();
            card.Title = "VP of Slapping People in the Face";

            Assert.AreEqual(
                "VP of Slapping People in the Face",
                card.Title,
                "The Title property is not working.");

        }

        #endregion

        #region [ ReadWriteProperty_UniqueId ]

        [Test]
        public void ReadWriteProperty_UniqueId()
        {

            vCard card = new vCard();
            card.UniqueId = "I am unique, just like everyone else.";

            Assert.AreEqual(
                "I am unique, just like everyone else.",
                card.UniqueId,
                "The UniqueId property is not working.");

        }

        #endregion

        // The next tests ensure the class complies with Microsoft
        // best practices regarding string properties.  Specifically,
        // string properties should never return null (they should
        // always return String.Empty).

        #region [ StringEmpty_AdditionalNames ]

        [Test]
        public void StringEmpty_AdditionalNames()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.AdditionalNames,
                "AdditionalNames is not null.");

            card.AdditionalNames = null;

            Assert.IsNull(
                card.AdditionalNames,
                "AdditionalNames is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_Department ]

        [Test]
        public void StringEmpty_Department()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.Department,
                "Department is not string.Empty.");

            card.Department = null;

            Assert.IsNull(
                card.Department,
                "Department is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_DisplayName ]

        [Test]
        public void StringEmpty_DisplayName()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.DisplayName,
                "DisplayName is not string.Empty.");

            card.DisplayName = null;

            Assert.IsNull(
                card.DisplayName,
                "DisplayName is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_FamilyName ]

        [Test]
        public void StringEmpty_FamilyName()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.FamilyName,
                "FamilyName is not string.Empty.");

            card.FamilyName = null;

            Assert.IsNull(
                card.FamilyName,
                "FamilyName is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_FormattedName ]

        [Test]
        public void StringEmpty_FormattedName()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.FormattedName,
                "FormattedName is not string.Empty.");

            card.FormattedName = null;

            Assert.IsNull(
                card.FormattedName,
                "FormattedName is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_GivenName ]

        [Test]
        public void StringEmpty_GivenName()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.GivenName,
                "GivenName is not string.Empty.");

            card.GivenName = null;

            Assert.IsNull(
                card.GivenName,
                "GivenName is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_Mailer ]

        [Test]
        public void StringEmpty_Mailer()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.Mailer,
                "Mailer is not string.Empty.");

            card.Mailer = null;

            Assert.IsNull(
                card.Mailer,
                "Mailer is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_NamePrefix ]

        [Test]
        public void StringEmpty_NamePrefix()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.NamePrefix,
                "NamePrefix is not string.Empty.");

            card.NamePrefix = null;

            Assert.IsNull(
                card.NamePrefix,
                "NamePrefix is not string.Empty after being assigned null.");


        }

        #endregion

        #region [ StringEmpty_NameSuffix ]

        [Test]
        public void StringEmpty_NameSuffix()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.NameSuffix,
                "NameSuffix is not string.Empty.");

            card.NameSuffix = null;

            Assert.IsNull(
                card.NameSuffix,
                "NameSuffix is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_Office ]

        [Test]
        public void StringEmpty_Office()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.Office,
                "Office is not string.Empty.");

            card.Office = null;

            Assert.IsNull(
                card.Office,
                "Office is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_Organization ]

        [Test]
        public void StringEmpty_Organization()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.Organization,
                "Organization is not string.Empty.");

            card.Organization = null;

            Assert.IsNull(
                card.Organization,
                "Organization is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_ProductId ]

        [Test]
        public void StringEmpty_ProductId()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.ProductId,
                "ProductId is not string.Empty.");

            card.ProductId = null;

            Assert.IsNull(
                card.ProductId,
                "ProductId is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_Role ]

        [Test]
        public void StringEmpty_Role()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.Role,
                "Role is not string.Empty.");

            card.Role = null;

            Assert.IsNull(
                card.Role,
                "Role is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_TimeZone ]

        [Test]
        public void StringEmpty_TimeZone()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.TimeZone,
                "TimeZone is not string.Empty.");

            card.TimeZone = null;

            Assert.IsNull(
                card.TimeZone,
                "TimeZone is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_Title ]

        [Test]
        public void StringEmpty_Title()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.Title,
                "Title is not string.Empty.");

            card.Title = null;

            Assert.IsNull(
                card.Title,
                "Title is not string.Empty after being assigned null.");

        }

        #endregion

        #region [ StringEmpty_UniqueId ]

        [Test]
        public void StringEmpty_UniqueId()
        {

            vCard card = new vCard();

            Assert.IsNull(
                card.UniqueId,
                "UniqueId is not string.Empty.");

            card.UniqueId = null;

            Assert.IsNull(
                card.UniqueId,
                "UniqueId is not string.Empty after being assigned null.");

        }

        #endregion

    }
}
