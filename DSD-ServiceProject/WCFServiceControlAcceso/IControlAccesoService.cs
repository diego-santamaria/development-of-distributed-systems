using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceControlAcceso.Errores;

namespace WCFServiceControlAcceso
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IControlAccesoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IControlAccesoService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [FaultContract(typeof(ControlAccesoException))]
        bool ValidarAcceso(string UserName, string UserPassw);

    }
}
