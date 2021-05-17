using System.Collections.Generic;

namespace CodingAssignment.Models
{
    public class DataModel
    {
        public int Id { get; set; }

        //using List of dictionary string because Dictionary<int, List<string>> is not supported in .net core 3.1
        //It still works with the example data from swagger
        public List<Dictionary<string, string>> Dictionary { get; set; }
    }
}