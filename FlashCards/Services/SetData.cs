using FlashCards.Model;
using Newtonsoft.Json; 
using System.Text;

namespace FlashCards.Service
{
    public static class SetData
    {
        public async static Task SetFlashCard(FlashCard flashCard)
        {
            string apiUrl = "http://localhost:8080/api/flashcard/create?courseId=1";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "*/*");
                string jsonData = "{\"explanation\": \""+flashCard.Explanation+"\",\"question\": \""+flashCard.Question+"\",\"rightAnswer\": \""+flashCard.RightAnswer+"\",\"tags\": [\"\"], "+
                "\"wrongAnswer1\": \""+flashCard.WrongAnswer1+"\", \"wrongAnswer2\": \""+flashCard.WrongAnswer2+"\",\"wrongAnswer3\": \""+flashCard.WrongAnswer3+"\"}";
                try
                {
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseContent);
                    }
                }
                catch (Exception ex){}
            }
        }

        public async static Task SetCourse(Course course)
        {
            string apiUrl = "http://localhost:8080/api/course/create";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "*/*");
                string jsonData = "{\"id\": 0,\"courseAbbreviation\": \""+course.CourseAbbreviation+"\",\"courseName\": \""+course.CourseName+"\"}";
                try
                {
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content).ConfigureAwait(false);
                }
                catch (Exception ex){}
            }
        }
    }
}