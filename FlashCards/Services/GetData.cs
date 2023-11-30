using FlashCards.Model;
using Newtonsoft.Json; 

namespace FlashCards.Service
{
    public static class GetData
    {
        public async static Task<FlashCard> GetRandomFlashCard()
        {
            string apiUrl = "http://localhost:8080/api/flashcard/getRandomByCourse/1";
            FlashCard flashCard = new();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "*/*");
                HttpResponseMessage response = await client.GetAsync(apiUrl).ConfigureAwait(false);
                string jsonContent = await response.Content.ReadAsStringAsync();
                flashCard = JsonConvert.DeserializeObject<FlashCard>(jsonContent);
            }
            return flashCard;
        }

        public async static Task<List<Course>> GetCourses()
        {
            List<Course> courses = new();
            string apiUrl = "http://localhost:8080/api/course/getAll";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "*/*");
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl).ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        courses = JsonConvert.DeserializeObject<List<Course>>(jsonContent);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
            return courses;
        }

        public async static Task<List<FlashCard>> GetFlashCards()
        {
            List<FlashCard> flashCards = new();
            string apiUrl = "http://localhost:8080/api/flashcard/getAll";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "*/*");
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl).ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        flashCards = JsonConvert.DeserializeObject<List<FlashCard>>(jsonContent);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
            return flashCards;
        }
    }
}