namespace UnitTesting
{
    [TestFixture, Description("Minus tests")]
    internal class MinusTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TestCase(1, 2, ExpectedResult = -1), Description("Positive tests")]
        [TestCase(-1, 2, ExpectedResult = -3)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [Category("Minus")]
        public int MinusPositiveTest(int operand_1, int operand_2)
        {
            return calculator.Minus(operand_1, operand_2);
        }

        [TestCase(3, 2, 2), Description("Negative tests")]
        [TestCase(-1, -2, -3)]
        [TestCase(0, 0, 1)]
        [Category("Minus")]
        public void MinusNegativeTest(int operand_1, int operand_2, int expectedResult)
        {
            var actualResult = calculator.Minus(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(expectedResult), $"Minus {operand_1} - {operand_2} = {actualResult}");
        }

        [Test]
        [Category("Minus"), Description("Range tests")]
        public void MinusRangeTest([Values(1, 2, 3)] int operand_1, [Range(4, 10, 2)] int operand_2)
        {
            var actualResult = calculator.Minus(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Minus {operand_1} - {operand_2} = {actualResult}");
        }

        [Retry(2)]
        [Test]
        [Category("Minus"), Description("Random tests")]
        public void MinusRandomTest([Values(1, 2, 3)] int operand_1, [Random(1, 100, 2)] int operand_2)
        {
            var actualResult = calculator.Minus(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Minus {operand_1} + {operand_2} = {actualResult}");
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
