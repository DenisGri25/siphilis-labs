using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIRIS_labs.Data.Entities
{
  public class Account: IEntity
  {
    [Key]
    [StringLength(13)]
    public string Number { get; set; }

    public float DebitValue { get; set; }
    public float CreditValue { get; set; }
    public float Balance { get; set; }

    public int? ClientsAccountNumber { get; set; }

    [Required]
    public virtual AccountPlan AccountPlan { get; set; }
    public string AccountPlanNumber { get; set; }

    [Required]
    public virtual Client Owner { get; set; }

    [ForeignKey(nameof(Owner))]
    public Guid OwnerID { get; set; }
  }
}