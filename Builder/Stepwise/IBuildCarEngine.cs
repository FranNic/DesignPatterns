﻿namespace Builder.Stepwise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

	public interface IBuildCarEngine
    {
        IBuildCarElectronics BuildEngine();
    }
}
