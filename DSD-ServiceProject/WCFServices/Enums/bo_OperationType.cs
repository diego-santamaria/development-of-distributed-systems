using System.Runtime.Serialization;

namespace WCFServiceCliente.Enums
{
    [DataContract]
    enum bo_OperationType
    {
        [EnumMember]
        ot_Create = 0,

        [EnumMember]
        ot_Update = 1,

        [EnumMember]
        ot_Delete = 2,

        [EnumMember]
        ot_Read = 3
    }
}