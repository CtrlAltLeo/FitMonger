using System.ComponentModel.DataAnnotations;

public class User
{
    public int UserID { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }    

}