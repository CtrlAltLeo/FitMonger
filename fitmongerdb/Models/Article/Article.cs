using System.ComponentModel.DataAnnotations;
using System.Drawing;
using fitmongerdb.Migrations;

public class Article
{
    public int ArticleID { get; set; }

    [Required]
    public string Name { get; set; }

    /*
    public Color? MainColor { get; set; } //This might need to be changed to a different type.

    public Color? SecondaryColor {get; set; }
    */

    public DateOnly DateAquired { get; set; }
    public DateOnly? DateLastWorn { get; set; }

    [Required]
    public ArticleType ArticleType { get; set; }

    public char? Size { get; set; } // This'll need to be bigger, XL, XS, etc

    public string? Material { get; set; }




}