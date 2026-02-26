
using Microsoft.EntityFrameworkCore;

public class TestDBService
{
    private readonly AppContext _context;

    public TestDBService(AppContext context)
    {
        _context = context;
    }

    public Test GetTest()
    {
        return _context.Tests.FirstOrDefault();
    }
}