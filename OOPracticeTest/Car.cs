using System;

namespace OOPracticeTest
{
    public class Car
    {
        private string name;
        private int speed;

        public Car()
        {
        }

        public Car(string v1, int v2)
        {
            this.name = v1;
            this.speed = v2;
        }

        public string SpeedUp()
        {
            return $"{this.name}: speed up {this.speed} km/h";
        }
    }
}