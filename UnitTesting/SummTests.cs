namespace UnitTesting
{
    [TestFixture, Description("Summ tests")]
    public class SummTests
    {
        private int randomInt;
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            randomInt = new Random().Next(0, 4);
            calculator = new Calculator();
        }

        [TestCase(1, 2, ExpectedResult = 3), Description("Positive numbers tests")]
        [TestCase(-1, 2, ExpectedResult = 1)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [Category("Summ")]
        public int SummPositiveTest(int operand_1, int operand_2)
        {
            return calculator.Summ(operand_1, operand_2);
        }

        [TestCase(1, 2, 4), Description("Negative numbers tests")]
        [TestCase(-1, 2, 2)]
        [TestCase(0, 0, 9)]
        [Category("Summ")]
        public void SummNegativeTest(int operand_1, int operand_2, int expectedResult)
        {
            var actualResult = calculator.Summ(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(expectedResult), $"Summ {operand_1} + {operand_2} = {actualResult}");
        }

        [Test]
        [Category("Summ")]
        public void SummRangeTest([Values(1, 2, 3)] int operand_1, [Range(1, 10, 2)] int operand_2)
        {
            var actualResult = calculator.Summ(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Summ {operand_1} + {operand_2} = {actualResult}");
        }

        [Test]
        [Category("Summ")]
        public void SummRandomTest([Values(1, 2, 3)] int operand_1, [Random(1, 100, 2)] int operand_2)
        {
            var actualResult = calculator.Summ(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Summ {operand_1} + {operand_2} = {actualResult}");
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
