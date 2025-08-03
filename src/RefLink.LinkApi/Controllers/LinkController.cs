using LinkApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinkApi.Controllers;

[ApiController]
[Route("v1/api/link")]
public class LinkController:ControllerBase
{
    private readonly ILinkService _linkService;

    public LinkController(ILinkService linkService)
    {
        _linkService = linkService;
    }

    [HttpGet]
    public async Task<ActionResult<List<LinkItem>>> GetAll()
    {
        Console.WriteLine("==== GetAll ====");
        var linkItems = _linkService.GetAll();
        Console.WriteLine(linkItems);
        return Ok(linkItems);
    }
}