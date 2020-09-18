using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace D_M10_HttpClient
{
    class DHttpClient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M10 Http Client");

            HttpClient httpClient = new HttpClient();

            HoleTodo();
            HoleTodos();

            async void HoleTodo()
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1");

                Console.WriteLine("response: \n{0} ", response);
                /**
response: 
StatusCode: 200, ReasonPhrase: 'OK', Version: 1.1, Content: System.Net.Http.HttpConnectionResponseContent, Headers:
{
  Date: Thu, 17 Sep 2020 12:00:01 GMT
  Transfer-Encoding: chunked
  Connection: keep-alive
  Set-Cookie: __cfduid=da90ecf91a30b4e49c5995ab60d34ea921600344001; expires=Sat, 17-Oct-20 12:00:01 GMT; path=/; domain=.typicode.com; HttpOnly; SameSite=Lax
  X-Powered-By: Express
  X-Ratelimit-Limit: 1000
  X-Ratelimit-Remaining: 999
  X-Ratelimit-Reset: 1600338861
  Vary: Origin
  Vary: Accept-Encoding
  Access-Control-Allow-Credentials: true
  Cache-Control: max-age=43200
  Pragma: no-cache
  X-Content-Type-Options: nosniff
  ETag: W/"5ef7-4Ad6/n39KWY9q6Ykm/ULNQ2F5IM"
  Via: 1.1 vegur
  CF-Cache-Status: HIT
  Age: 5149
  cf-request-id: 053d88a2cf00000faecb2d7200000001
  Expect-CT: max-age=604800, report-uri="https://report-uri.cloudflare.com/cdn-cgi/beacon/expect-ct"
  Server: cloudflare
  CF-RAY: 5d42aa17bc290fae-VIE
  Content-Type: application/json; charset=utf-8
  Expires: -1
}
                 */
                string respContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("\n\nrespContent: \n{0}", respContent);
                /**
                 respContent:
[
  {
    "userId": 1,
    "id": 1,
    "title": "delectus aut autem",
    "completed": false
  },
  {
    "userId": 1,
    "id": 2,
    "title": "quis ut nam facilis et officia qui",
    "completed": false
  },
  {
    "userId": 1,
    "id": 3,
    "title": "fugiat veniam minus",
    "completed": false
  },
                ...
                */

                // Todo todo = (Todo)JsonConvert.DeserializeObject(respContent); // geht, aber eine Exception wird geworfen "unable to cast JObject to Todo"
                Todo todo = JsonConvert.DeserializeObject<Todo>(respContent); // geht, keine Exception
                Console.WriteLine("todo.GetType(): {0}", todo.GetType());

                Console.WriteLine("todo.Title: {0}", todo.Title);
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

            Console.ReadKey();
        }
    }
}
