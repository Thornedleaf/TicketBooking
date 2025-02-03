using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Moq;

namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        private readonly TicketBookingRequest _request;
        private readonly Mock<ITicketBookingRepository> _ticketBookingRepositoryMock;
        private readonly TicketBookingRequestProcessor _processor;
        public TicketBookingRequestProcessorTests()
        {
            //_ticketBookingRepositoryMock = new Mock<ITicketBookingRepository>();
            //_processor = new TicketBookingRequestProcessor(_ticketBookingRepositoryMock.Object);
            _request = new TicketBookingRequest
            {
                FirstName = "Oskar",
                Lastname = "Josefsson",
                Email = "oskar.josefsson@outlook.com",
                Date = "1:a Februari 2025"
            };
            _ticketBookingRepositoryMock = new Mock<ITicketBookingRepository>();
            _processor = new TicketBookingRequestProcessor(_ticketBookingRepositoryMock.Object);
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
            TicketBooking savedTicketBooking = null;
            
            //setup save
            _ticketBookingRepositoryMock.Setup(x => x.Save(It.IsAny<TicketBooking>()))
                .Callback<TicketBooking>((TicketBooking) =>
            {
                savedTicketBooking = TicketBooking;
            });
            //var request = new TicketBookingRequest
            //{
                //FirstName = "Oskar",
                //Lastname = "Josefsson",
                //Email = "oskar.josefsson@outlook.com",
                //Date = "1:a Februari 2025"

            //};
            //act
            _processor.Book(_request);








        }
    }
}


