using System.ComponentModel.DataAnnotations;

public class CreateDriverDto
{
    [Required]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
    public string FirstName { get; set; }
    
    [Required]
    [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
    public string LastName { get; set; }
    
    public int? TeamId { get; set; }
}