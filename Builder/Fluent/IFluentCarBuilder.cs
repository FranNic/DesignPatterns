namespace Builder.Fluent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Fluent builder interface needs to reference itself so that it can be chained.
    public interface IFluentCarBuilder
    {
        IFluentCarBuilder Reset();
        IFluentCarBuilder BuildChassis();
        IFluentCarBuilder BuildBody();
        IFluentCarBuilder BuildEngine();
        IFluentCarBuilder BuildElectronics();
        IFluentCarBuilder BuildWindows();
    }
}
