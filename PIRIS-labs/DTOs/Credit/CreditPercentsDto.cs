using System;

namespace PIRIS_labs.DTOs.Credit
{
  public class CreditPercentsDto
  {
    public int RowNumber { get; set; }
    public DateTime Date { get; set; }

    public double MainDebth { get; set; }
    public double PercentDebth { get; set; }
    public double PaymentSum { get; set; }
  }
}
