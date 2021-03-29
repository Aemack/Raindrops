using NUnit.Framework;
using PlingPlangPlong;
namespace PlingPlangPlongTests
{
    public class StandardNumberTests
    {
        public Raindrops _sut = new Raindrops();

        [Test]
        public void GetPlingPlangPlong_ReturnsString()
        {
            string result = _sut.GetPlingPlangPlong(10);
            Assert.That(result, Is.InstanceOf<string>());
        }

        [Test]
        public void GetPlingPlangPlong_DoesNotReturnNull()
        {
            string result = _sut.GetPlingPlangPlong(10);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]

        public void GetPlingPlangPlong_ReturnsPling_WhenGivenMultiplesOf3(int num)
        {            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo("Pling"));
        }

        [Test]
        public void GetPlingPlangPlong_Returns0_WhenGiven0()
        {
            
            string result = _sut.GetPlingPlangPlong(0);
            Assert.That(result, Is.EqualTo("0"));
        }


        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GetPlingPlangPlong_ReturnsPlang_WhenGivenMultiplesOf5(int num)
        {
            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo("Plang"));
        }


        [TestCase(7)]
        [TestCase(14)]
        [TestCase(28)]
        [TestCase(49)]
        public void GetPlingPlangPlong_ReturnsPlong_WhenGivenMultiplesOf7(int num)
        {
            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo("Plong"));
        }

        [TestCase(21)]
        [TestCase(42)]
        [TestCase(63)]
        [TestCase(84)]

        public void GetPlingPlangPlong_ReturnsPlingPlong_WhenGivenMultiplesOf3And7(int num)
        {
            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo("PlingPlong"));
        }


        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        public void GetPlingPlangPlong_ReturnsPlingPlang_WhenGivenMultiplesOf3And5(int num)
        {
            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo("PlingPlang"));
        }

        [TestCase(35)]
        [TestCase(70)]
        [TestCase(140)]
        [TestCase(280)]
        public void GetPlingPlangPlong_ReturnsPlangPlong_WhenGivenMultiplesOf5And7(int num)
        {
            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo("PlangPlong"));
        }

        [TestCase(105)]
        [TestCase(210)]
        [TestCase(315)]
        [TestCase(420)]
        public void GetPlingPlangPlong_ReturnsPlingPlangPlong_WhenGivenMultiplesOf3And5And7(int num)
        {
            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo("PlingPlangPlong"));
        }

        [TestCase(2)]
        [TestCase(13)]
        [TestCase(-97)]
        [TestCase(79)]
        public void GetPlingPlangPlong_ReturnsNumber_WhenGivenNonMultiplesOf3And5And7(int num)
        {
            
            string result = _sut.GetPlingPlangPlong(num);
            Assert.That(result, Is.EqualTo(""+num));
        }
    }


}