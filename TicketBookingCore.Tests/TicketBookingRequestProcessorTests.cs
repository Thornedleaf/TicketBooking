namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        private readonly Mock<ITicketBookingRepository> _ticketBookibgRepositoryMock;
        private readonly TicketBookingRequestProcessor _processor;
        public TicketBookingRequestProcessorTests()
        {
            _processor = new TicketBookingRequestProcessor();
        }

        [Fact]
        public void ShouldReturnTicketsBookingResultWithRequestValues()
        {
            //Arrange
            var request = new TicketBookingRequest
            {
                FirstName = "Oskar",
                Lastname = "Josefsson",
                Email = "oskar.josefsson@outlook.com",
                Date = "1:a Februari 2025"
            };
            //Act
            TicketBookingResponse respons = _processor.Book(request);

            //Assert
            Assert.NotNull(respons);
            Assert.Equal(request.FirstName, respons.FirstName);
            Assert.Equal(request.Lastname, respons.Lastname);
            Assert.Equal(request.Email, respons.Email);
            Assert.Equal(request.Date, respons.Date);
        }
        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            //act
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.Book(null));

            //assert
            Assert.Equal("request", exception.ParamName);
        }

    }
    public class TicketBookingRepository
    {

        [Fact]
       
        public void ShouldSaveToDatabase()
        {
        //arrange
        var request = new TicketBookingRequest
            {
                FirstName = "Oskar",
                Lastname = "Josefsson",
                Email = "oskar.josefsson@outlook.com"
            };
            //act
            TicketBookingResponse response = _processor.Book(request);

            //assert

        }
    }
}
