

using System.ComponentModel.DataAnnotations;

public class ArticleType
{
    public int ArticleTypeID { get; set; }

    [Required]
    public string Name { get; set; }

    public int? BodyRegionID {get; set;}
    public BodyRegion? BodyRegion { get; set; }
}