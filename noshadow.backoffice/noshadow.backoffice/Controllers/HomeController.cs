using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using noshadow.backoffice.Api;
using noshadow.backoffice.Models;

namespace noshadow.backoffice.Controllers
{
    public class HomeController : Controller
    {
        readonly IApi _api;

        public HomeController(IApi api)
        {
            _api = api;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "NoShadow é um trabalho de conclusão de curso do curso de Engenharia da Computação " +
                                  "pela Faculdade de Engenharia de Sorocaba - FACENS, " +
                                  "realizado desde o segundo semestre de 2017 " +
                                  "até o final do primeiro semestre do ano de 2018, por José Eduardo de Almeida Junior" +
                                  " e José Leonardo de Almeida, com orientação de Luis Fernando Vieira e " +
                                  "coordenação Andréa Braga; com o objetivo de demonstrar as funcionalidades de um " +
                                  "rastreador veícular com a implementação da tecnologia Dead Reckoning.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "www.facens.br.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        [HttpPost]
        public async Task<IActionResult> List([FromBody] GetLocationPayload payload)
        {
            if (payload == null)
            {
                payload = new GetLocationPayload();
            }
            
            payload.DeviceId = payload.IsDr ? Guid.Parse("BB10BB26-A2F7-490B-80C0-3AA7625866CB"): Guid.Parse("3AAD0DB9-7464-43CB-8077-0B7B50D67B80");

            using (var proxy = await _api.GetLocations(payload))
            {
                switch (proxy.ResponseMessage.StatusCode)
                {
                    case HttpStatusCode.OK:
                        var data = proxy.GetContent();
                        return Json(data);
                    default:
                        return Redirect("~/home/error");
                }
            }
        }
    }
}