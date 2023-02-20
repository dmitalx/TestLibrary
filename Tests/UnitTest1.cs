namespace Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// ѕроверка на нахождение площади треугольника со сторонами 3, 4 и 5.
        /// ќжидаемое поведение - успешное выполнение теста
        /// </summary>
        [Fact]
        public void Test1()
        {
            Assert.Equal(6, TestLibrary.SquareArea.TriangleArea(3, 4, 5));
        }

        /// <summary>
        /// ѕроверка на нахождение площади треугольника со сторонами 6, 8 и 10.
        /// ќжидаемое поведение - успешное выполнение теста
        /// </summary>
        [Fact]
        public void Test2()
        {
            Assert.Equal(24, TestLibrary.SquareArea.TriangleArea(6,8,10));
        }

        /// <summary>
        /// ѕроверка метода нахождени€ площади круга
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expectedArea"></param>
        [Theory]
        [InlineData(3, 28.274333)]
        [InlineData(4, 50.265482)]
        public void Theory(int value, double expectedArea)
        {
            var diff = Math.Abs(TestLibrary.SquareArea.CircleArea(value) - expectedArea);
            Assert.True(diff < 0.000001);
        }
    }
}