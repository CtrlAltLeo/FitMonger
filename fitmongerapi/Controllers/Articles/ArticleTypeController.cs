using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ArticleTypeController : ControllerBase
{
    private readonly ArticleTypeService _articleTypeService;

    public ArticleTypeController(ArticleTypeService articleTypeService)
    {
        _articleTypeService = articleTypeService;
    }

    [HttpGet("{id}")]
    public ArticleType GetArticleType(int id)
    {
        return _articleTypeService.GetArticleType(id);
    }
}