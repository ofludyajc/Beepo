using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Models;

namespace BeepoRecruitment.Infrastructure.Dto
{
    public class ContactDto
    {
        public string ContactID { get; set; }

        public long MobileNumber { get; set; }

        public string EmailAddress { get; set; }

        public string PhysicalAddress { get; set; }
    }
}
