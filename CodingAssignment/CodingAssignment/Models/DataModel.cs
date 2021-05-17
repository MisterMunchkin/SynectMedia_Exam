using System.Collections.Generic;

namespace CodingAssignment.Models
{
    public class DataModel
    {
        public int Id { get; set; }

        public List<Dictionary<string, string>> Dictionary { get; set; }
    }
}