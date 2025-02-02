
namespace TicketBookingCore
{
    public class TicketBookingRequestProcessor
    {
        public TicketBookingRequestProcessor()
        {



        }
        
        public TicketBookingResponse Book(TicketBookingRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            // Returnera en ny TicketBookingResponse
            return new TicketBookingResponse
            {
                FirstName = request.FirstName,
                Lastname =  request.Lastname,    
                Email =     request.Email,
                Date =      request.Date
            };

        }
        public TicketBookingRequestProcessor(ITicketBookingRepository ticketBookingRepository) { }
    }
}