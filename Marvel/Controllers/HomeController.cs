using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Marvel.Controllers
{
    public class HomeController : Controller
    {
        string privateKey = "88ee693187105623d7a776e06e2c2afe4cbbec80";
        string publicKey = "6e14ba626608719b5a06bd55a450aae1";

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }



        //System.Diagnostics.Debug.WriteLine(...)

        public ActionResult Index(string userOffset, string userLimit)
        {
            string offset = string.IsNullOrEmpty(userOffset) ? "0" : userOffset;
            string limit = string.IsNullOrEmpty(userLimit) ? "20" : userLimit;
            try
            {
                int intLimit = int.Parse(limit);
                limit = (intLimit > 100) ? "20" : limit;
            }
            catch (Exception)
            {
                limit = "20";
            }
            string timeStamp = DateTime.UtcNow.ToString();
            string hash = CreateMD5(timeStamp + privateKey + publicKey).ToLower();
            var client = new RestClient("http://gateway.marvel.com/v1/public");
            var request = new RestRequest("characters?limit={limit}&offset={offset}&ts={ts}&apikey={key}&hash={hash}&orderBy=name", Method.GET);
            request.AddUrlSegment("limit", limit);
            request.AddUrlSegment("offset", offset);
            request.AddUrlSegment("ts", timeStamp);
            request.AddUrlSegment("key", publicKey);
            request.AddUrlSegment("hash", hash);

            // execute the request
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var characters = Models.CharacterViewModel.FromJson(content);
            
            return View(characters);
        }

        public ActionResult Search(string startsWith, string userOffset, string userLimit)
        {
            string offset = string.IsNullOrEmpty(userOffset) ? "0" : userOffset;
            string limit = string.IsNullOrEmpty(userLimit) ? "20" : userLimit;
            try
            {
                int intLimit = int.Parse(limit);
                limit = (intLimit > 100) ? "20" : limit;
            }
            catch (Exception)
            {
                limit = "20";
            }
            string timeStamp = DateTime.UtcNow.ToString();
            string hash = CreateMD5(timeStamp + privateKey + publicKey).ToLower();
            var client = new RestClient("http://gateway.marvel.com/v1/public");
            var request = new RestRequest("characters?nameStartsWith={startsWith}&limit={limit}&offset={offset}&ts={ts}&apikey={key}&hash={hash}", Method.GET);
            request.AddUrlSegment("startsWith", startsWith);
            request.AddUrlSegment("limit", limit);
            request.AddUrlSegment("offset", offset);
            request.AddUrlSegment("ts", timeStamp);
            request.AddUrlSegment("key", publicKey);
            request.AddUrlSegment("hash", hash);

            // execute the request
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var characters = Models.CharacterViewModel.FromJson(content);

            ViewBag.StartsWith = startsWith;
            return View(characters);
        }

        public ActionResult Character(string ID)
        {
            string userID = string.IsNullOrEmpty(ID) ? "1009610" : ID;
            try
            {
                int intID = int.Parse(ID);
            }
            catch (Exception)
            {
                userID = "1009610";
            }
            string timeStamp = DateTime.UtcNow.ToString();
            string hash = CreateMD5(timeStamp + privateKey + publicKey).ToLower();
            var client = new RestClient("http://gateway.marvel.com/v1/public");
            var request = new RestRequest("characters/{id}?&ts={ts}&apikey={key}&hash={hash}", Method.GET);
            request.AddUrlSegment("id", userID);
            request.AddUrlSegment("ts", timeStamp);
            request.AddUrlSegment("key", publicKey);
            request.AddUrlSegment("hash", hash);
            // execute the request
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            request = new RestRequest("characters/{id}/comics?&ts={ts}&apikey={key}&hash={hash}", Method.GET);
            request.AddUrlSegment("id", userID);
            request.AddUrlSegment("ts", timeStamp);
            request.AddUrlSegment("key", publicKey);
            request.AddUrlSegment("hash", hash);
            // execute the request
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            response = client.Execute(request);
            var comics = response.Content;

            var characters = Models.CharacterViewModel.FromJson(content);
            characters.Data.Results.First().ComicsModel = QuickType.ComicViewModel.FromJson(comics);
            return View(characters);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}