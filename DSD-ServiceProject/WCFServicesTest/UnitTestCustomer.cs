using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Script.Serialization;
using WCFServicesTest.ClientesWS;
using System.Net;
using System.IO;

namespace WCFServicesTest
{
    [TestClass]
    public class UnitTestCustomer
    {
        [TestMethod]
        public void Test1_CrearCliente()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            var customer = new BusinessPartner()
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
            };
            string postData = js.Serialize(customer);
            byte[] data = Encoding.UTF8.GetBytes(postData);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:58947/CustomerService.svc/Clientes");
            request.Method = "POST";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            
            //var requestStream = request.GetRequestStream();
            //requestStream.Write(data, 0, data.Length);

            request.GetRequestStream().Write(data, 0, data.Length);

            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                BusinessPartner CustomerCreated = js.Deserialize<BusinessPartner>(tramaJson);

                Assert.AreEqual("C00201500015", CustomerCreated.CardCode);
                Assert.AreEqual("PEREZ YACTAYO, FELIX ANDRES", CustomerCreated.CardName);
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                RepetidoException error = js.Deserialize<RepetidoException>(tramajson);

                Assert.AreEqual(HttpStatusCode.Conflict, cod);
                Assert.AreEqual(error.Codigo, "101");
            }
        }

        [TestMethod]
        public void Test2_BuscarCliente()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
                .Create("http://localhost:58947/CustomerService.svc/Clientes?cardcode=C75969600&cardname=DIEGO");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();  

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<BusinessPartner> BPBusquedaList = js.Deserialize<List<BusinessPartner>>(tramaJson);

            Assert.AreEqual(BPBusquedaList[0].CardCode, "C75969600");
            Assert.AreEqual(BPBusquedaList[0].CardName, "DIEGO SANTAMARIA SOTELO");
        }

        [TestMethod]
        public void Test3_EliminarCliente()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create("http://localhost:58947/CustomerService.svc/Clientes?cardcode=C00201500015");
            request.Method = "DELETE";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            HttpWebRequest request2 = (HttpWebRequest)WebRequest
               .Create("http://localhost:58947/CustomerService.svc/Clientes?cardcode=C00201500015");
            request2.Method = "GET";
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            StreamReader reader = new StreamReader(response2.GetResponseStream());
            string tramaJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<BusinessPartner> BPBusquedaList = js.Deserialize<List<BusinessPartner>>(tramaJson);

            Assert.AreEqual(0, BPBusquedaList.Count);
        }
    }
}
