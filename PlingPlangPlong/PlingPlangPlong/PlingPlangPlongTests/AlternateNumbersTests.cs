using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PlingPlangPlong;

namespace PlingPlangPlongTests
{
    class AlternateNumbersTests
    {

        [TestCase(-9, -78900, -0, 200)]
        [TestCase(176, 3567, 575, 80)]
        [TestCase(-1, -3, -5, -10)]
        [TestCase(0, 0, 0, 0)]
        public void GetPlingPlangPlong_ReturnsString(int pling, int plang, int plong, int num)
        {
            Raindrops sut = new Raindrops(pling, plang, plong);
            var result = sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.InstanceOf<string>());
        }

        [TestCase(-9, -78900, -0, 200)]
        [TestCase(176, 3567, 575, 80)]
        [TestCase(-1, -3, -5, -10)]
        [TestCase(0, 0, 0, 0)]
        public void GetPlingPlangPlong_DoesNotReturnNull(int pling, int plang, int plong, int num)
        {
            Raindrops sut = new Raindrops(pling, plang, plong);
            var result = sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.Not.Null);
        }


        [TestCase(-9, -5, -10, 90, "PlingPlangPlong")]
        [TestCase(1, 2, 3, 8, "PlingPlang")]
        [TestCase(-1, -3, -5, -10, "PlingPlong")]
        [TestCase(1564,526262,25672,300, "300")]
        [TestCase(0, 0, 0, 0,"0")]
        public void GetPlingPlangPlong_ReturnsCorrectString(int pling, int plang, int plong, int num, string expected)
        {
            Raindrops sut = new Raindrops(pling, plang, plong);
            var result = sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
