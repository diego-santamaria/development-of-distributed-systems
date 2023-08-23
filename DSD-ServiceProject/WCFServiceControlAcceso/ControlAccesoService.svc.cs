using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceControlAcceso.Errores;

namespace WCFServiceControlAcceso
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ControlAccesoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ControlAccesoService.svc o ControlAccesoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ControlAccesoService : IControlAccesoService
    {
        public void DoWork()
        {
        }

        public bool ValidarAcceso(string UserName, string UserPassw)
        {    
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(UserPassw))
            {
                throw new FaultException<ControlAccesoException>(
                           new ControlAccesoException()
                           {
                               Codigo = "101",
                               Descripcion = "El nombre de usuario y/o contraseña son requeridos."
                           }
                           , new FaultReason("Ha surgido un error mientras se intentaba validar el acceso"));
            }

            return true;

        }
    }
}
