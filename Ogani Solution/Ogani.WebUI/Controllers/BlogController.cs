using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ogani.Domain.Business.BlogPostModule;
using System.Threading.Tasks;

namespace Ogani.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMediator mediator;

        public BlogController(IMediator mediator ) 
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {

            var response = await mediator.Send(query);

            return View(response);
        }
    }
}
