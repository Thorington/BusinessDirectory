using System.ComponentModel.DataAnnotations;

namespace BusinessDirectory.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    public string BusinessType { get; set; }
    [Required]
    public string BusinessName { get; set; }
    [Required]
    public string BusinessWebsite { get; set; }

  }
}