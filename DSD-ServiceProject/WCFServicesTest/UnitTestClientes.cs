using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCFServicesTest
{
    [TestClass]
    public class UnitTestClientes
    {
        [TestMethod]
        public void Test1_CrearCliente()
        {          
            ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
            ClientesWS.BusinessPartner newBP = proxy.CrearCliente(new ClientesWS.BusinessPartner()
            {
                CardCode = "C00201500015",
                CardName = "PEREZ YACTAYO, FELIX ANDRES",
                Nombres = "FELIX ANDRES",
                ApellidoPat = "PEREZ",
                ApellidoMat = "YACTAYO",
                LicTradNum = "201500015",
                TipoDoc = "1",
                TipoPer = "TPN",
                ContctPrsn = "PEREZ YACTAYO, FELIX ANDRES",
                Telephone1 = "",
                Telephone2 = "",
                Email = "U201500015@UPC.EDU.PE",
                Cellular = "994379568",
                Address = "AVENIDA LA PAZ 784",
                Notes = "",
                Active = "Y"
            });
            proxy.Close();
            Assert.AreEqual("C00201500015", newBP.CardCode);
            Assert.AreEqual("FELIX ANDRES", newBP.Nombres);
            Assert.AreEqual("U201500015@UPC.EDU.PE", newBP.Email);
        }
        [TestMethod]
        public void Test2_CrearClienteExistente()
        {
            try
            {
                ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
                ClientesWS.BusinessPartner newBP = proxy.CrearCliente(new ClientesWS.BusinessPartner()
                {
                    CardCode = "C00201500015",
                    Nombres = "FELIX ANDRES",
                    ApellidoPat = "PEREZ",
                    ApellidoMat = "YACTAYO",
                    LicTradNum = "201500015",
                    TipoDoc = "1",
                    TipoPer = "TPN",
                    ContctPrsn = "PEREZ YACTAYO, FELIX ANDRES",
                    Telephone1 = "",
                    Telephone2 = "",
                    Email = "U201500015@UPC.EDU.PE",
                    Cellular = "994379568",
                    Address = "AVENIDA LA PAZ 784",
                    Notes = "",
                    Active = "Y"
                });
            }
            catch (FaultException<ClientesWS.RepetidoException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "101");
            }
        }
        [TestMethod]
        public void Test3_CrearClienteDatosErroneos()
        {
            try
            {
                ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
                ClientesWS.BusinessPartner newBP = proxy.CrearCliente(new ClientesWS.BusinessPartner()
                {
                    CardCode = "C00201500016",
                    Nombres = "ANDREA ARIANA",
                    ApellidoPat = "TORRES",
                    ApellidoMat = "MANATI",
                    LicTradNum = "",
                    TipoDoc = "1",
                    TipoPer = "TPN",
                    ContctPrsn = "PEREZ YACTAYO, FELIX ANDRES",
                    Telephone1 = "",
                    Telephone2 = "",
                    Email = "U201815581@UPC.EDU.PE",
                    Cellular = "994379568",
                    Address = "AVENIDA LA CULTURA 924, SURCO",
                    Notes = "",
                    Active = "Y"
                });
            }
            catch (FaultException<ClientesWS.RepetidoException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "101");
            }
            catch (FaultException<ClientesWS.ClienteException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "301");
            }
        }
        [TestMethod]
        public void Test4_EliminarCliente()
        {
            ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
            proxy.EliminarCliente("C00201500015");

            Assert.AreEqual(null, proxy.ObtenerCliente("C00201500015"));
        }
        [TestMethod]
        public void Test5_EliminarClienteActivo()
        {
            try
            {
                ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
                proxy.EliminarCliente("C00201500015");

                Assert.AreEqual(null, proxy.ObtenerCliente("C00201500015"));
            }
            catch (FaultException<ClientesWS.InexistenteException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "201");
            }
            catch (FaultException<ClientesWS.ClienteException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "401");
            }

        }
        [TestMethod]
        public void Test6_ActualizarCliente()
        {
            ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
            ClientesWS.BusinessPartner newBP = proxy.ModificarCliente(new ClientesWS.BusinessPartner()
            {
                CardCode = "C00201500015",
                Nombres = "ANDRES FELIX",
                ApellidoPat = "PEREZ",
                ApellidoMat = "YACTAYO",
                LicTradNum = "201500015",
                TipoDoc = "1",
                TipoPer = "TPN",
                ContctPrsn = "PEREZ YACTAYO, FELIX ANDRES",
                Telephone1 = "",
                Telephone2 = "",
                Email = "U201500015@UPC.EDU.PE",
                Cellular = "994379568",
                Address = "AVENIDA LA PAZ 784",
                Notes = "",
                Active = "Y"
            });
            Assert.AreEqual("Y", newBP.Active);
            Assert.AreEqual("ANDRES FELIX", newBP.Nombres);
        }
        [TestMethod]
        public void Test7_ActualizarClienteInexistente()
        {
            try
            {
                ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
                ClientesWS.BusinessPartner newBP = proxy.ModificarCliente(new ClientesWS.BusinessPartner()
                {
                    CardCode = "C00213041243",
                    Nombres = "MANOLO ",
                    ApellidoPat = "ROJAS",
                    ApellidoMat = "ROJAS",
                    LicTradNum = "213041243",
                    TipoDoc = "1",
                    TipoPer = "TPN",
                    ContctPrsn = "-",
                    Telephone1 = "",
                    Telephone2 = "",
                    Email = "123@NOESTOY.UPC",
                    Cellular = "412341553",
                    Address = "-",
                    Notes = "",
                    Active = "Y"
                });
                Assert.AreEqual("Y", newBP.Active);
                Assert.AreEqual("ANDRES FELIX", newBP.Nombres);
            }
            catch (FaultException<ClientesWS.InexistenteException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "201");
            }
        }
        [TestMethod]
        public void Test8_ActualizarClienteDatosErroneos()
        {
            try
            {
                ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
                ClientesWS.BusinessPartner newBP = proxy.ModificarCliente(new ClientesWS.BusinessPartner()
                {
                    CardCode = "C00201500015",
                    Nombres = "FELIX ANDRES",
                    ApellidoPat = "PEREZ",
                    ApellidoMat = "YACTAYO",
                    LicTradNum = "201500015",
                    TipoDoc = "1",
                    TipoPer = "TPJ",
                    ContctPrsn = "PEREZ YACTAYO, FELIX ANDRES",
                    Telephone1 = "",
                    Telephone2 = "",
                    Email = "U201500015@UPC.EDU.PE",
                    Cellular = "994379568",
                    Address = "AVENIDA LA PAZ 784",
                    Notes = "",
                    Active = "Y"
                });
            }
            catch (FaultException<ClientesWS.InexistenteException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "201");
            }
            catch (FaultException<ClientesWS.ClienteException> ex)
            {
                Assert.AreEqual(ex.Detail.Codigo, "3052");
            }
        }
        [TestMethod]
        public void Test9_ObtenerCliente()
        {
            ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
            ClientesWS.BusinessPartner bp = proxy.ObtenerCliente("C00075969600");

            Assert.AreEqual("C00075969600", bp.CardCode);
            Assert.AreEqual("Y", bp.Active);
            Assert.AreEqual("SANTAMARIA", bp.ApellidoPat.Trim());
        }
        [TestMethod]
        public void Test10_ObtenerClientes()
        {
            ClientesWS.ClienteServiceClient proxy = new ClientesWS.ClienteServiceClient();
            ClientesWS.BusinessPartner[] arrayBP = proxy.ListarClientes();

            Assert.AreEqual(1, arrayBP.Length); // .Length en base 0. Total: 2 elementos
        }

    }
}
