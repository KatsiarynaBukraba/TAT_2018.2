using NUnit.Framework;
using System;

namespace task_DEV_2.Tests
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase("а", "a")]
        [TestCase("б", "b")]
        [TestCase("в", "v")]
        [TestCase("г", "g")]
        [TestCase("д", "d")]
        [TestCase("е", "e")]
        [TestCase("ё", "yo")]
        [TestCase("ж", "zh")]
        [TestCase("з", "z")]
        [TestCase("и", "i")]
        [TestCase("й", "y")]
        [TestCase("к", "k")]
        [TestCase("л", "l")]
        [TestCase("м", "m")]
        [TestCase("н", "n")]
        [TestCase("о", "o")]
        [TestCase("п", "p")]
        [TestCase("р", "r")]
        [TestCase("с", "s")]
        [TestCase("т", "t")]
        [TestCase("у", "u")]
        [TestCase("ф", "f")]
        [TestCase("х", "kh")]
        [TestCase("ц", "ts")]
        [TestCase("ч", "ch")]
        [TestCase("ш", "sh")]
        [TestCase("щ", "sch")]
        [TestCase("ю", "yu")]
        [TestCase("я", "ya")]
        [TestCase("э", "e")]
        [TestCase("ы", "i")]
        public void TestCyrToLat(string symbolToTranslit, string expectedResult)
        {
            Transliter transliter = new Transliter();
            Assert.AreEqual(expectedResult, transliter.Translit(symbolToTranslit));
        }

        [TestCase("а", "a")]
        [TestCase("б", "b")]
        [TestCase("в", "v")]
        [TestCase("г", "g")]
        [TestCase("д", "d")]
        [TestCase("е", "e")]
        [TestCase("ё", "yo")]
        [TestCase("ж", "zh")]
        [TestCase("з", "z")]
        [TestCase("и", "i")]
        [TestCase("й", "y")]
        [TestCase("к", "k")]
        [TestCase("л", "l")]
        [TestCase("м", "m")]
        [TestCase("н", "n")]
        [TestCase("о", "o")]
        [TestCase("п", "p")]
        [TestCase("р", "r")]
        [TestCase("с", "s")]
        [TestCase("т", "t")]
        [TestCase("у", "u")]
        [TestCase("ф", "f")]
        [TestCase("х", "kh")]
        [TestCase("ц", "ts")]
        [TestCase("ч", "ch")]
        [TestCase("ш", "sh")]
        [TestCase("щ", "sch")]
        [TestCase("ю", "yu")]
        [TestCase("я", "ya")]
        public void TestLatToCyr(string expectedResult, string symbolToTranslit)
        {
            Transliter transliter = new Transliter();
            Assert.AreEqual(expectedResult, transliter.Translit(symbolToTranslit));
        }

        [TestCase("h")]
        [TestCase("sc")]
        [TestCase("j")]
        [TestCase("c")]
        public void TestWrongLatToCyr(string symbolToTranslit)
        {
            Transliter transliter = new Transliter();
            Assert.Throws<Exception>(() => transliter.Translit(symbolToTranslit));
        }
    }
}
