using Microsoft.AspNetCore.Mvc;
using WebArg.CurrencyRates.Web.Common.DataAnnotations;

namespace WebArg.CurrencyRates.Quartz.Controllers;

/// <summary>
/// Фоновые задачи
/// </summary>
[ApiController]
[Route("[controller]")]
[Produces("application/json")]
[ValidateUsingFluentValidation]
public class QuartzController : Controller
{
    public QuartzController()
    {

    }
}
