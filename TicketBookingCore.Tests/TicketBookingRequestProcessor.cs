
namespace TicketBookingCore.Tests
{
    internal class TicketBookingRequestProcessor
    {
        public TicketBookingRequestProcessor()
        {



        }
        
        internal TicketBookingResponse Book(TicketBookingRequest request)
        {
            // Returnera en ny TicketBookingResponse
            return new TicketBookingResponse
            {
                FirstName = request.FirstName,
                Lastname = request.Lastname,
                Email = request.Email,
                Date = request.Date
            };

        }
    }
}