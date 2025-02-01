namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnTicketsBookingResultWithRequestValues()
        {   //Arrange
            var processor = new TicketBookingRequestProcessor();

            var request = new TicketBookingRequest
            {
                FirstName = "Oskar",
                Lastname = "Josefsson",
                Email = "oskar.josefsson@outlook.com",
                Date ="1983-10-15"
            };
            //Act
            TicketBookingResponse respons = processor.Book(request);

            //Assert
            Assert.NotNull(respons);
            Assert.Equal(request.FirstName, respons.FirstName);
            Assert.Equal(request.Lastname, respons.Lastname);
            Assert.Equal(request.Email, respons.Email);
            Assert.Equal(request.Date, respons.Date);
        }
    }
}
