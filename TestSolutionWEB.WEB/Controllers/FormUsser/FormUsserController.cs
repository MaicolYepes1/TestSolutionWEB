using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using TestSolutionWEB.MODELS.Loads;
using TestSolutionWEB.SERVICES.Interfaces;

namespace TestSolutionWEB.WEB.Controllers.FormUsser
{
    public class FormUsserController : Controller
    {
        #region Dependency
        private readonly IAddUsserService _add;
        private readonly IConfiguration _config;
        #endregion

        #region Constructor
        public FormUsserController(IAddUsserService add, IConfiguration config)
        {
            _add = add;
            _config = config;
        }
        #endregion

        #region Methods
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(UsserLoad usser)
        {
            try
            {
                var url = _config.GetValue<string>("UrlSave");
                var result = await _add.Add(url, usser);
                if (result != false)
                {
                    ViewBag.Alert = "Tu informacion ha sido recibida satisfactoriamente.";
                    return View("Index");
                }
                else
                {
                    ViewBag.Alert = "Ocurrió un error, por favor intente de nuevo.";
                    return View("Index");
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

    }
}
