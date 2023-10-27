﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class TransactionDto
    {

        public int Id { get; set; } //gönderen heasp
        public int AccountId { get; set; } //gönderen heasp
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
    }
}
