using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_HttpClient
{
    public class Todo //Klasse immer Einzahl, Array Mehrzahl
    {
        [JsonProperty] public uint UserId { get; set; }
        //[JsonProperty] uint id = 0;
        [JsonProperty] public uint Id { get; set; }

        [JsonProperty] public string Title { get; set; }
        [JsonProperty] public bool Completed { get; set; }



        public Todo(uint userId, uint id, string title, bool completed)
        {
            UserId = userId;
            Id = id;
            Title = title;
            Completed = completed;
        }



    }
}
