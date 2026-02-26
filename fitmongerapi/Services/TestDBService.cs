
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

    public Test SaveTest(Test test)
    {
        _context.Tests.Add(test);
        _context.SaveChanges();
        return test;
    }
}