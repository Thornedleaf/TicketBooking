namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnTicketsBookingResultWithRequestValues()
        {
            var processor = new TicketBookingRequestProcessor();

            var request = new TicketBookingRequest
            {
                FirstName = "Oskar",
                Lastname = "Josefsson",
                Email = "oskar.josefsson@outlook.com"
            };
            


        }
    }
}
