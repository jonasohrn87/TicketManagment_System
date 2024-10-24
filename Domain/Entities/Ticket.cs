﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ticket
    {
        public Ticket() 
        {
            Attachments = new HashSet<Attachment>();
        }

        public int TicketId { get; set; }
        public string Summary { get; set; }
        public string? Description { get; set; }
        public DateTime RaisedDate { get; set; }
        public DateTime ExpectedDate { get; set; }
        public string? AssignedToId { get; set; }
        [ForeignKey(nameof(AssignedToId))]
        public User? AssignedTo { get; set; }
        public string? RaisedBy { get; set; }
        [ForeignKey(nameof(RaisedBy))]
        public User? User { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public int PriorityId { get; set; }
        [ForeignKey(nameof(PriorityId))]
        public Category Category { get; set; }
        public Priority Priority {  get; set; }
        public string Status { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }



    }
}
