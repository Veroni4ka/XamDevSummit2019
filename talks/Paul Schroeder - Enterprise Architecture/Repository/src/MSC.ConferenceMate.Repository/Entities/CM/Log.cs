// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // Log
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class Log
    {
        public int Id { get; set; } // Id (Primary key)
        public System.DateTime Date { get; set; } // Date
        public string Thread { get; set; } // Thread (length: 255)
        public string Level { get; set; } // Level (length: 50)
        public string Logger { get; set; } // Logger (length: 255)
        public string Message { get; set; } // Message (length: 4000)
        public string Exception { get; set; } // Exception (length: 2000)
        public int? LogMessageTypeId { get; set; } // LogMessageTypeID
        public string MethodName { get; set; } // MethodName (length: 255)
        public string UserName { get; set; } // UserName (length: 255)
        public string ClientIpAddress { get; set; } // ClientIPAddress (length: 255)
        public System.Guid? LogGuid { get; set; } // LogGuid
        public long? ExecutionTimeInMilliseconds { get; set; } // ExecutionTimeInMilliseconds
        public string HttpResponseStatusCode { get; set; } // HttpResponseStatusCode (length: 255)
        public string Url { get; set; } // Url (length: 2000)

        public Log()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
