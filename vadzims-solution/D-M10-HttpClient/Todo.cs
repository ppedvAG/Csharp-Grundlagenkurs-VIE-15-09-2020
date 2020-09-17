using System;
using System.Collections.Generic;
using System.Text;

namespace D_M10_HttpClient
{
    internal class Todo
    {
        /**
             "userId": 1,
    "id": 1,
    "title": "delectus aut autem",
    "completed": false
        */
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
