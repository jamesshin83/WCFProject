using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAddOneService
    {
        [OperationContract]
        IntValues AddOneToEach(IntValues composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "GettingStartedLib2.ContractType".
    [DataContract]
    public class IntValues
    {
        int val1;
        int val2;

        [DataMember]
        public int Value1
        {
            get { return val1; }
            set { val1 = value; }
        }

        [DataMember]
        public int Value2
        {
            get { return val2; }
            set { val2 = value; }
        }
    }
}
