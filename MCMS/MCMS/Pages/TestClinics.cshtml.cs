using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MCMS.Pages
{
    public class ClinicsModel : PageModel
    {
        //private readonly IHttpClientFactory _clientFactory;

        //public IEnumerable<GitHubPullRequest> PullRequests { get; private set; }

        //public bool GetPullRequestsError { get; private set; }

        //public bool HasPullRequests => PullRequests.Any();


        public void OnGet()
        {
            //var request = new HttpRequestMessage(HttpMethod.Get,
            //"repos/aspnet/docs/pulls");

            //var client = _clientFactory.CreateClient("github");

            //var response = await client.SendAsync(request);

            //if (response.IsSuccessStatusCode)
            //{
            //    PullRequests = await response.Content
            //        .ReadAsAsync<IEnumerable<GitHubPullRequest>>();
            //}
            //else
            //{
            //    GetPullRequestsError = true;
            //    PullRequests = Array.Empty<GitHubPullRequest>();
            //}

        }
    }
}