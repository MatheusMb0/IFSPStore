using IFSPStoreDomain.Entities;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace IFSPStore.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteCidade()
        {
            Cidade  cidade = new Cidade(1,"Birigui","SP");
            Debug.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Estado, "SP");
        }
    }
}