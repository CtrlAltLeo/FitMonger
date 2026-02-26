using Microsoft.AspNetCore.Mvc;

public class HomeController : ControllerBase
{

    TestDBService _testDBService;

    public HomeController(TestDBService testDBService)
    {
        _testDBService = testDBService;
    }

    [HttpGet("/")]
    public Test Index()
    {
        return _testDBService.GetTest();
    }

    [HttpPost("/")]
    public Test SaveTest(Test test)
    {
        return _testDBService.SaveTest(test);   
    }

}