 using NUnit.Framework;

namespace Summator_Project
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] {4,9});
            Assert.That(result, Is.EqualTo(13));
        }

        [Test]
        public void Test_Sum_OneNumber()
        {
            int result = Summator.Sum(new int[] { 5 });
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test_Sum_TwoPossitiveNumbersr()
        {
            int result = Summator.Sum(new int[] { -5,-7 });
            Assert.That(result, Is.EqualTo(-12));
        }

        [Test]
        public void Test_EmptyArray()
        {
            int result = Summator.Sum(new int[] { });
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_AutOfArray()
        {
            int result = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            Assert.That(result, Is.EqualTo(6000000000));
        }
    }
}