namespace UnitTesting
{
    [TestFixture, Description("Multiply tests")]

    internal class MultiplyTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TestCase(1, 2, ExpectedResult = 2), Description("Positive tests")]
        [TestCase(-1, 2, ExpectedResult = -2)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [Category("Multiply")]
        public int MultiplyPositiveTest(int operand_1, int operand_2)
        {
            return calculator.Multiply(operand_1, operand_2);
        }

        [TestCase(3, 2, 2), Description("Negative tests")]
        [TestCase(-1, -2, -3)]
        [TestCase(0, 0, 1)]
        [Category("Multiply")]
        public void MultiplyNegativeTest(int operand_1, int operand_2, int expectedResult)
        {
            var actualResult = calculator.Multiply(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(expectedResult), $"Multiply {operand_1} * {operand_2} = {actualResult}");
        }

        [Test]
        [Category("Multiply"), Description("Range tests")]
        public void MultiplyRangeTest([Values(1, 2, 3)] int operand_1, [Range(1, 10, 2)] int operand_2)
        {
            var actualResult = calculator.Multiply(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Multiply {operand_1} * {operand_2} = {actualResult}");
        }

        [Test]
        [Category("Multiply"), Description("Random tests")]
        public void MultiplyRandomTest([Values(1, 2, 3)] int operand_1, [Random(1, 100, 2)] int operand_2)
        {
            var actualResult = calculator.Multiply(operand_1, operand_2);
            Assert.That(actualResult, Is.Not.EqualTo(0), $"Multiply {operand_1} * {operand_2} = {actualResult}");
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
