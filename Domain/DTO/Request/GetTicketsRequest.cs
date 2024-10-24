﻿namespace Domain.DTO.Request
{
    public class GetTicketsRequest
    {
        public string? summary {  get; set; }
        public int[]? ProductId { get; set; }
        public int[]? CategoryId { get; set; }
        public int[]? PriorityId { get; set; }
        public string[]? Status { get; set; }
        public string[]? RaisedBy { get; set; }
    }
}
