using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Hello_WebApi_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GET, press any key...");
            AsyncToServer(1).Wait();
            Console.ReadKey();
            Console.WriteLine("POST, press any key...");
            AsyncPost().Wait();
            Console.ReadKey();
            Console.WriteLine("PUT, press any key...");
            AsyncPut(2).Wait();
            Console.ReadKey();
            Console.WriteLine("PUT, press any key...");
            AsyncPut(5).Wait();
            Console.ReadKey();
            Console.WriteLine("Delete, press any key...");
            AsyncDelete().Wait();
            Console.ReadKey();
        }

      
        static async Task AsyncToServer(int i)
        {
            using (var Pict_client = new HttpClient())
            {
                try
                {
                    Pict_client.BaseAddress = new Uri("http://localhost:32334/");
                    Pict_client.DefaultRequestHeaders.Accept.Clear();
                    Pict_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Pict_resp = await Pict_client.GetAsync("api/Pictures/"+i);
                    Pict_resp.EnsureSuccessStatusCode();
                    if (Pict_resp.IsSuccessStatusCode)
                    {
                        Picture my_pict = await Pict_resp.Content.ReadAsAsync<Picture>();
                        Console.WriteLine("{0}\t${1}\t{2}", my_pict.Title, my_pict.Price, my_pict.Author);
                       
                    }


                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        static async Task AsyncPost()
        {
            using (var Pict_client = new HttpClient())
            {
                try
                {
                    Pict_client.BaseAddress = new Uri("http://localhost:32334/");
                    Pict_client.DefaultRequestHeaders.Accept.Clear();
                    Pict_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // HTTP POST
                    var new_pict = new Picture() {Id=4, Title = "Dogs", Price = 100, Author = "Student" };
                    HttpResponseMessage Pict_resp = await Pict_client.PostAsJsonAsync("api/Pictures", new_pict);
                    if (!Pict_resp.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error " + Pict_resp.IsSuccessStatusCode.ToString());
                    }

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        static async Task AsyncPut(int id)
        {
            using (var Pict_client = new HttpClient())
            {
                try
                {
                    Pict_client.BaseAddress = new Uri("http://localhost:32334/");
                    Pict_client.DefaultRequestHeaders.Accept.Clear();
                    Pict_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // HTTP PUT
                    var new_pict = new Picture() { Id = 2, Title = "Dogs", Price = 100, Author = "Student" };
                    HttpResponseMessage Pict_resp = await Pict_client.PutAsJsonAsync("api/Pictures/"+id, new_pict);
                    if (!Pict_resp.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error " + Pict_resp.IsSuccessStatusCode.ToString());
                    }

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        static async Task AsyncDelete()
        {
            using (var Pict_client = new HttpClient())
            {
                try
                {
                    Pict_client.BaseAddress = new Uri("http://localhost:32334/");
                    Pict_client.DefaultRequestHeaders.Accept.Clear();
                    Pict_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // HTTP DELETE
                    HttpResponseMessage Pict_resp = await Pict_client.DeleteAsync("api/Pictures/1");
                    if (!Pict_resp.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error " + Pict_resp.IsSuccessStatusCode.ToString());
                    }

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

    }
}
