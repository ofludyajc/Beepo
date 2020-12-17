using BeepoRecruitment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeepoRecruitment.Common
{
    public class Constants
    {
        public List<BeepoEmployee> beepoEmployees = new List<BeepoEmployee>
        {
            new BeepoEmployee
            {
                EmployeeID = 101,
                EmployeeName = "Darlene Dela Cruz",
                EmployeeRole = "Recruiter",
                EmployeePosition = "Associate",
                ContactID = 10001,
                Contact = new Contact
                {
                    ContactID = "10001",
                    MobileNumber = 09123123123,
                    EmailAddress = "darlene.delacruz@beepo.com.au",
                    PhysicalAddress = "Pampanga"
                }
            },

            new BeepoEmployee
            {
                EmployeeID = 102,
                EmployeeName = "Danica Jamille Laxamana",
                EmployeeRole = "Background Checker",
                EmployeePosition = "Associate",
                ContactID = 10002,
                Contact = new Contact
                {
                    ContactID = "10002",
                    MobileNumber = 09123456789,
                    EmailAddress = "danica.laxama@beepo.com.au",
                    PhysicalAddress = "Pampanga"
                }
            },

            new BeepoEmployee
            {
                EmployeeID = 103,
                EmployeeName = "Ayan Banting",
                EmployeeRole = "Team Leader",
                EmployeePosition = "Supervisor",
                ContactID = 10003,
                Contact = new Contact
                {
                    ContactID = "10003",
                    MobileNumber = 09987654321,
                    EmailAddress = "analyn.banting@beepo.com.au",
                    PhysicalAddress = "Pampanga"
                }
            },

            new BeepoEmployee
            {
                EmployeeID = 104,
                EmployeeName = "Rj Cortez",
                EmployeeRole = "Technical Consultant",
                EmployeePosition = "Supervisor",
                ContactID = 10004,
                Contact = new Contact
                {
                    ContactID = "10004",
                    MobileNumber = 09456567678,
                    EmailAddress = "rj.cortez@beepo.com.au",
                    PhysicalAddress = "Pampanga"
                }
            },

            new BeepoEmployee
            {
                EmployeeID = 105,
                EmployeeName = "Mark Change",
                EmployeeRole = "Project Manager",
                EmployeePosition = "Manager",
                ContactID = 10005,
                Contact = new Contact
                {
                    ContactID = "10005",
                    MobileNumber = 0999999999,
                    EmailAddress = "mark.change@beepo.com.au",
                    PhysicalAddress = "Australia"
                }
            }

        };

        public List<Contact> contacts = new List<Contact>
        {
            

            new Contact
            {
                ContactID = "10002",
                MobileNumber = 09123456789,
                EmailAddress = "danica.laxama@beepo.com.au",
                PhysicalAddress = "Pampanga"
            },

            new Contact
            {
                ContactID = "10003",
                MobileNumber = 09987654321,
                EmailAddress = "analyn.banting@beepo.com.au",
                PhysicalAddress = "Pampanga"
            },

            new Contact
            {
                ContactID = "10004",
                MobileNumber = 09456567678,
                EmailAddress = "rj.cortez@beepo.com.au",
                PhysicalAddress = "Pampanga"
            },

            new Contact
            {
                ContactID = "10005",
                MobileNumber = 0999999999,
                EmailAddress = "mark.change@beepo.com.au",
                PhysicalAddress = "Australia"
            }
        };

        public const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    }
}
