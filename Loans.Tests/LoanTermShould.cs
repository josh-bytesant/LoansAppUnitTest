using Loans.Domain.Applications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    [TestFixture]
    public class LoanTermShould
    {
        [Test]
        public void ReturnTerminMonths()
        {
            var sut = new LoanTerm(1);

            Assert.That(sut.ToMonths(), Is.EqualTo(12));

        } 
    }
}
