using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogetherApp.Models
{
    public class ResponseStore
    {
        public static List<ResponseModel> responses = new List<ResponseModel>();
        public static IEnumerable<ResponseModel> Responses => responses;

        public static void SaveChanges(ResponseModel response)
        {
            responses.Add(response);
        }
    }
}
