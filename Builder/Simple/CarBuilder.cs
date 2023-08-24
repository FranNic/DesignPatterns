namespace Builder
{
    using System;
    using System.Threading.Tasks;

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public CarBuilder()
        {
            Reset();
        }

        public void BuildBody() => _car.Add("Body");
        public void BuildChassis() => _car.Add("Chassis");
        public void BuildElectronics() => _car.Add("Electronics");
        public void BuildEngine() => _car.Add("Engine");
        public void BuildWindows() => _car.Add("Windows");
        public object GetCar() => _car.ListParts();
        public void Reset() => _car = new Car();
       
    }
}
