using System;
using System.ComponentModel.DataAnnotations;

namespace PIRIS_labs.DTOs.Credit
{
  public class CreateCreditDto
  {
    [Required]
    public float Amount { get; set; }

    [Required]
    public Guid ClientID { get; set; }

    [Required]
    public Guid CreditPlanID { get; set; }
  }
}
