using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //instagram
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/suaybhizar"),
                Headers =
    {
        { "X-RapidAPI-Key", "c49aaeca64msh9cb62cb11aa26efp18dfa1jsn6f80d5ae6627" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDto.followers;
                ViewBag.v2 = resultInstagramFollowersDto.following;
            }
            //Rapid api ile twitter ve linkedin hesapları için veri çekme işlemlerinde rapid api dan kaynaklanan sorun var bu nedenle instagram hesabı için kullanım gerçekleştirdim.
            //twitter
    //        var client2 = new HttpClient();
    //        var request2 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=suaybhizar"),
    //            Headers =
    //{
    //    { "X-RapidAPI-Key", "630ce9cc86msh271c60cffe62d5ep1b514djsn0fe292593744" },
    //    { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    //},
    //        };
    //        using (var response2 = await client2.SendAsync(request2))
    //        {
    //            response2.EnsureSuccessStatusCode();
    //            var body2 = await response2.Content.ReadAsStringAsync();
    //            ResultTwittterFollowersDto resultTwittterFollowersDto = JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2);
    //            ViewBag.v3 = resultTwittterFollowersDto.data.user_info.followers_count;
    //            ViewBag.v4 = resultTwittterFollowersDto.data.user_info.friends_count;
    //        }

    //        //linkedin
    //        var client3 = new HttpClient();
    //        var request3 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://linkedin-profiles1.p.rapidapi.com/extract?url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fsuayb-hizar-430630146%2F&html=1"),
    //            Headers =
    //{
    //    { "X-RapidAPI-Key", "c49aaeca64msh9cb62cb11aa26efp18dfa1jsn6f80d5ae6627" },
    //    { "X-RapidAPI-Host", "linkedin-profiles1.p.rapidapi.com" },
    //},
    //        };
    //        using (var response3 = await client3.SendAsync(request3))
    //        {
    //            response3.EnsureSuccessStatusCode();
    //            var body3 = await response3.Content.ReadAsStringAsync();
    //            ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
    //            ViewBag.v5 = resultLinkedinFollowersDto.data.followers_count;
    //        }


            return View();
        }
    }
}
