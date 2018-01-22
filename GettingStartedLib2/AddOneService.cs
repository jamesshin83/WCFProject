using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AddOneService : IAddOneService
    {
        public IntValues AddOneToEach(IntValues composite)
        {
            var newVals = new IntValues();

            newVals.Value1 = composite.Value1 + 1;
            newVals.Value2 = composite.Value2 + 1;

            return newVals;
        }
    }
}
