using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using noshadow.backoffice.Models;

namespace noshadow.backoffice.Controllers
{
    public class HomeController : Controller
    {
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
    }
}