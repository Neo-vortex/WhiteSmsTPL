﻿using IPE.WhiteSmsTPL.Models.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.Ticket
{
    public class GetTicketStatusResponse : BaseResponse
    {
        public TicketStatus[] TicketStatus { get; set; }
    }
}
