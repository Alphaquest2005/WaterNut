using System;
using System.Runtime.Serialization;


namespace Core.Common.DataLayer.Services
{
    [DataContract]
    public class ValidationFault
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public Exception MyException { get; set; }

    }
}
