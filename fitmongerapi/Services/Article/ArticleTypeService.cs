using Microsoft.EntityFrameworkCore;
public class ArticleTypeService
{
    private readonly AppContext _context;

    public ArticleTypeService(AppContext context)
    {
        _context = context;
    }

    public ArticleType GetArticleType(int articleTypeId)
    {
        return _context.ArticleTypes.Where(a => a.ArticleTypeID == articleTypeId).Include(a => a.BodyRegion).FirstOrDefault();
    }
}