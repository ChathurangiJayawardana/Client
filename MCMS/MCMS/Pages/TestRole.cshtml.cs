using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MCMS.Pages
{
    public class RoleModel : PageModel
    {

        //private readonly IHttpClientFactory _clientFactory;

        //public RoleModel(IHttpClientFactory clientFactory)
        //{
        //    _clientFactory = clientFactory;
        //}

        //public IEnumerable<Roles> Roles { get; private set; }
        //public bool RolesError { get; private set; }

        public string Url { get; private set; }

        public void OnGet()
        {

            Url = "https://localhost:44316/api/roles";
            //var request = new HttpRequestMessage(HttpMethod.Get,
            //"api/roles");

            //var client = _clientFactory.CreateClient("mcms");

            //var response = await client.SendAsync(request);

            //if (response.IsSuccessStatusCode)
            //{
            //        Roles = await response.Content
            //        .ReadAsAsync<IEnumerable<Roles>>();
            //}
            //else
            //{
            //    RolesError = true;
            //    Roles = Array.Empty<Roles>();
            //}
        }
    }
}