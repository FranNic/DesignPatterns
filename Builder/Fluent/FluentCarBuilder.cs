namespace Builder
{
    using Builder.Fluent;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FluentCarBuilder : IFluentCarBuilder
    {
    private Car _car = new Car();

        public FluentCarBuilder()
        {
            Reset();
        }

        public IFluentCarBuilder BuildBody()
        {
            _car.Add("Body");
            return this;
        }

        public IFluentCarBuilder BuildChassis()
        {
            _car.Add("Chassis");
            return this;
        }

        public IFluentCarBuilder BuildElectronics()
        {
            _car.Add("Electronics");
            return this;
        }

        public IFluentCarBuilder BuildEngine()
        {
            _car.Add("Engine");
            return this;
        }

        public IFluentCarBuilder BuildWindows()
        {
            _car.Add("Windows");
            return this;
        }

        public object GetCar() => _car.ListParts();

        public IFluentCarBuilder Reset()
        {
            _car = new Car();
            return this;
        }   
    }
}
