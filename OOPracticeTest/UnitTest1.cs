namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_speed()
        {
            // given
            Car car = new Car("Cool car", 30);

            // when
            string message = car.SpeedUp();

            // then
            Assert.Equal("Cool car: speed up 30 km/h", message);
        }
    }
}