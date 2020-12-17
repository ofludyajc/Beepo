using System;
using System.Linq;
using BeepoRecruitment.Common;

namespace BeepoRecruitment.Infrastructure.Helper
{
    public class Utilities
    {
        private static readonly Random random = new Random();

        public string GenerateCandidateID()
        {
            string randomString = GenerateRandomID();
            string dateToday = DateTime.Now.ToString("yyyyMMdd");
            return dateToday + randomString;
        }

        public string GenerateContactID()
        {
            string randomString = GenerateRandomID();
            string dateToday = DateTime.Now.ToString("yyyyMMdd");
            return dateToday + randomString;
        }

        public string GenerateApplicationID()
        {
            string randomString = GenerateRandomID();
            string dateToday = DateTime.Now.ToString("yyyyMMdd");
            return dateToday + randomString;
        }

        private string GenerateRandomID()
        {
            var randomString = Enumerable.Repeat(Constants.chars, 8).Select(s => s[random.Next(s.Length)]).ToArray();
            return new string(randomString);
        }
    }
}
