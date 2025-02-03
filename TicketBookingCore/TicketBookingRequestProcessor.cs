
using TicketBookingCore;

namespace TicketBookingCore
{
    public class TicketBookingRequestProcessor
    {
        //private readonly ITicketBookingRepository _ticket;
        public TicketBookingRequestProcessor(ITicketBookingRepository ticketBookingRepository)
        {
            //_ticket = ticketBookingRepository;
        }

        public TicketBookingResponse Book(TicketBookingRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            //_ticket.Save(TicketBookingSupport.Create<TicketBooking>(request));
            //return TicketBookingSupport.Create<TicketBookingResponse>(request);
             
            return new TicketBookingResponse
            {
                FirstName = request.FirstName,
                Lastname =  request.Lastname,    
                Email =     request.Email,
                Date =      request.Date
            };

        }
        
    }
}