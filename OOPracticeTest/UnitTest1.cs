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

        [Fact]
        public void Should_return_message_when_speed_up_given_truck_speed()
        {
            // given
            Truck car = new Truck("Big Truck", 10);

            // when
            string message = car.SpeedUp();

            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_driver_drive_car()
        {
            // given
            Car car = new Car("Cool car", 30);
            Driver driver = new Driver(car);
            // when
            string message = driver.DriveVehicle();

            // then
            Assert.Equal("Cool car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_driver_drive_truck()
        {
            // given
            Truck car = new Truck("Big Truck", 10);
            Driver driver = new Driver(car);
            // when
            string message = driver.DriveVehicle();

            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}