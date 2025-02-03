using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using Moq;
using System.ComponentModel.DataAnnotations;

namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        private readonly TicketBookingRequest _request;
        private readonly Mock<ITicketBookingRepository> _ticketBookingRepositoryMock;
        private readonly TicketBookingRequestProcessor _processor;
        public TicketBookingRequestProcessorTests()
        {
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
            
            //Act
            TicketBookingResponse respons = _processor.Book(_request);

            //Assert
            Assert.NotNull(respons);
            Assert.Equal(_request.FirstName, respons.FirstName);
            Assert.Equal(_request.Lastname, respons.Lastname);
            Assert.Equal(_request.Email, respons.Email);
            Assert.Equal(_request.Date, respons.Date);
        }
        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            //act
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.Book(null));

            //assert
            Assert.Equal("request", exception.ParamName);
        }

    
    

        [Fact]

        public void ShouldSaveToDatabase()
        {
            //arrange
            TicketBooking savedTicketBooking = null;
            
            //setup save
            _ticketBookingRepositoryMock.Setup(x => x.Save(It.IsAny<TicketBooking>())).Callback<TicketBooking>((ticketBooking) =>
            {
                savedTicketBooking = ticketBooking;
            });
            //act
            _processor.Book(_request);

            //assert
            _ticketBookingRepositoryMock.Verify(x => x.Save(It.IsAny<TicketBooking>()),
            Times.Once);


            Assert.NotNull(savedTicketBooking);
            Assert.Equal(_request.FirstName, savedTicketBooking.FirstName);
            Assert.Equal(_request.Lastname, savedTicketBooking.Lastname);
            Assert.Equal(_request.Email, savedTicketBooking.Email);
            Assert.Equal(_request.Date, savedTicketBooking.Date);








        }
    }
}



