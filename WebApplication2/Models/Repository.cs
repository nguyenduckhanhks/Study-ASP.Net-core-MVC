using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Repository 
    {
        private static List<GuestReponse> responses = new List<GuestReponse>();
        public static IEnumerable<GuestReponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestReponse response)
        {
            responses.Add(response);
        }
    }
}
