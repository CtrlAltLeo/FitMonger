

public class ArticleService
{
    private readonly AppContext _context;

    public ArticleService(AppContext context)
    {
        _context = context;
    }

    public Article GetArticle(int articleId)
    {
        return _context.Articles.FirstOrDefault(a => a.ArticleID == articleId);
    }
}