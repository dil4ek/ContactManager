﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
   public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int ContactId { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
