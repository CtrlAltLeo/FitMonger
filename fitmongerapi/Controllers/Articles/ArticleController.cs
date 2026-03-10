

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ArticleController: ControllerBase
{

    private readonly ArticleService _articleService;

    public ArticleController(ArticleService articleService)
    {
        _articleService = articleService;
    }

    [HttpGet("{articleId}")]
    public Article GetArticle(int articleId)
    {
        return _articleService.GetArticle(articleId);
    }

}