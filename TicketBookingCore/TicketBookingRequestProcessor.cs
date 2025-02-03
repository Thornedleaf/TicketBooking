
using TicketBookingCore.Tests;

namespace TicketBookingCore
{
    public class TicketBookingRequestProcessor
    {
        private readonly ITicketBookingRepository _ticket;
        public TicketBookingRequestProcessor(ITicketBookingRepository ticketBookingRepository)
        {
            _ticket = ticketBookingRepository;
        }

        public TicketBookingResponse Book(TicketBookingRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            _Ticket.Save(TicketBookingSupport.Create<TicketBooking>(request));
            return TicketBookingSupport.Create<TicketBookingResponse>(request);
            // Returnera en ny TicketBookingResponse
            //return new TicketBookingResponse
            //{
                //FirstName = request.FirstName,
                //Lastname =  request.Lastname,    
                //Email =     request.Email,
                //Date =      request.Date
            //};

        }
        
    }
}