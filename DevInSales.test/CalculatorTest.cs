using NUnit.Framework;
using DevInSales.Controllers;
using Moq;
using DevInSales.api.Services;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DevInSales.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevInSales.Context;

namespace DevInSales.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
       
        public async Task RetornaTodosOsAddressAsync()
        {

           /* var mockSet = new Mock<DbSet<Address>>();

            var mockContext = new Mock<SqlContext>();
            mockContext.Setup(m => m.Address).Returns(mockSet.Object);

            var service = new AddressRepository(mockContext.Object);
            service.PostAddress(new Address
            {
                
                City_Id = 11,
                Street = "Rua Lateral",
                CEP = "999999-99",
                Number = 22,
                Complement = "casa"
            });

            mockSet.Verify(m => m.Add(It.IsAny<Address>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
           */

            var lista = new List<Address>();
           
            var moq = new Mock<IAddressRepository>();
            moq.Setup(r => r.getAddress()).Returns(lista);

            AddressController controller = new AddressController(moq.Object);

            var result =  controller.GetAddress().Result;

            moq.Verify(r => r.getAddress());
            Assert.AreEqual(result, lista);
        }
     


 
        /*public async Task retornaFilmesTest()
        {
            //given
            await using var factory = new DevInSalesFactory();
            var client = factory.CreateClient();
            //when
          //  var myContent = JsonConvert.SerializeObject(new UserLoginDTO { Id = 1, Password = romeu123@ });
           // var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
           // var byteContent = new ByteArrayContent(buffer);
           // byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
             var jsonLogin = "{\"Id\" : \"1\",\"Password\" :\"romeu123@\"}";
             using var jsonContent = new StringContent(jsonLogin, Encoding.UTF8, "application/json");
            jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

        

            
            var token = await client.PostAsync("/api/Authentication", jsonContent) ;
            var response = await client.GetAsync("/api/address");

            //then

            Assert.Pass();
        }*/
        
    }
}