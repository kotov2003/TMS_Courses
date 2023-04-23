namespace UnitTesting
{
    [TestFixture, Description("Divide tests")]
    internal class DivideTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TestCase(2, 2, ExpectedResult = 1d), Description("Positive tests")]
        [TestCase(-2, 2, ExpectedResult = -1d)]
        [Category("Divide")]
        public double DividePositiveTest(int operand_1, int operand_2)
        {
            return calculator.Divide(operand_1, operand_2);
        }

        [TestCase(3, 3, 3), Description("Negative tests")]
        [TestCase(-1, -1, -1)]
        [Category("Divide")]
        public void DivideNegativeTest(int operand_1, int operand_2, int expectedResult)
        {
            var actualResult = calculator.Divide(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(expectedResult), $"Divide {operand_1} / {operand_2} = {actualResult}");
        }

        [TestCase(8, 0)]
        [Category("Divide")]
        public void DivideByZero(int operand_1, int operand_2)
        {
            Assert.Throws<DivideByZeroException>(new TestDelegate(() => calculator.Divide(operand_1, operand_2)));
        }

        [Test]
        [Category("Divide"), Description("Range tests")]
        public void DivideRangeTest([Values(100, 200, 300)] int operand_1, [Range(1, 10, 2)] int operand_2)
        {
            var actualResult = calculator.Divide(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Divide {operand_1} / {operand_2} = {actualResult}");
        }

        [Test]
        [Category("Divide"), Description("Random tests")]
        public void DivideRandomTest([Values(100, 200, 300)] int operand_1, [Random(1, 100, 2)] int operand_2)
        {
            var actualResult = calculator.Divide(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Divide {operand_1} / {operand_2} = {actualResult}");
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
