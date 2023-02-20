using PIRIS_labs.Data.Entities;

namespace PIRIS_labs.DTOs.Deposit
{
  public class DepositPercentAccountDto
  {
    public float Percent { get; set; }
    public Account Account { get; set; }
    public Data.Entities.Deposit Deposit { get; set; }
  }
}
