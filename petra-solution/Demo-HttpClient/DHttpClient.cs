using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Demo_HttpClient
{
    class DHttpClient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M10 Http Client");

            HttpClient httpClient = new HttpClient();

            HoleTodo();
            //HoleTodos();

            // =======================
            #region Methoden


            async void HoleTodo()
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
                //Console.WriteLine("response: {0}",response); // Nur Metadaten

                string respContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("--- respContent: ---\n{0}", respContent);

                try
                {
                    Todo todo = (Todo)JsonConvert.DeserializeObject(respContent); // geht, aber eine Exception wird geworfen "unable to cast JObject to Todo"
                    Console.WriteLine("todo.GetType(): {0}", todo.GetType());
                    Console.WriteLine("todo.Title(): {0}", todo.Title);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fehler: {0}", e.Message);
                }

                //Todo todo = JsonConvert.DeserializeObject<Todo>(respContent);



            }


            async void HoleTodos()
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                string respContent = await response.Content.ReadAsStringAsync();
                Todo[] todos = JsonConvert.DeserializeObject<Todo[]>(respContent);
                foreach (var item in todos)
                {
                    Console.WriteLine(item.Id + " " + item.Title + "\n");
                }
            }
            #endregion Methoden







            Console.ReadKey();
        }
    }
}
