using System;
using System.ComponentModel.DataAnnotations;
using PIRIS_labs.Enums;
using PIRIS_labs.Helpers;

namespace PIRIS_labs.DTOs.Client
{
  public class ClientDto
  {
    public Guid ID { get; set; }
    [Required]
    [RegularExpression(@"^[A-Za-zА-Яа-я]{1,30}$", ErrorMessage = "Surname should only consist of letters.")]
    public string Surname { get; set; }
    [Required]
    [RegularExpression(@"^[A-Za-zА-Яа-я]{1,30}$", ErrorMessage = "Name should only consist of letters.")]
    public string Name { get; set; }
    [Required]
    [RegularExpression(@"^[A-Za-zА-Яа-я]{1,30}$", ErrorMessage = "Patronymic should only consist of letters.")]
    public string Patronymic { get; set; }
    [Required]
    [Birthday]
    public DateTime Birthday { get; set; }
    [Required]
    public Gender Gender { get; set; }
    [Required]
    public string BirthPlace { get; set; }

    [Required]
    public string ActualResidenceCityName { get; set; }
    [Required]
    public string ActualResidenceAddress { get; set; }
    [Required]
    public string RegistrationCityName { get; set; }
    [Required]
    public string RegistrationAddress { get; set; }

    [RegularExpression(@"(^80[0-9]{9}$)|(^$)", ErrorMessage = "Invalid home phone format.")]
    public string HomePhoneNumber { get; set; }
    [RegularExpression(@"(^\+375[0-9]{9}$)|(^$)", ErrorMessage = "Invalid mobile phone format.")]
    public string MobilePhoneNumber { get; set; }
    public string Email { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "Invalid passport series.")]
    public string PassportSeries { get; set; }
    [Required]
    [RegularExpression(@"^[0-9]{7}$", ErrorMessage = "Invalid passport number.")]
    public string PassportNumber { get; set; }
    [Required]
    public string PassportIssuedBy { get; set; }
    [Required]
    [PassportIssueDate]
    public DateTime PassportIssuedDate { get; set; }
    [Required]
    [RegularExpression(@"^[0-9]{7}[A-Z][0-9]{3}(PB|РВ)[0-9]$", ErrorMessage = "Invalid identification number.")]
    public string IdentificationNumber { get; set; }

    public string WorkPlace { get; set; }
    public string Position { get; set; }

    [Required]
    public string MaritalStatusName { get; set; }
    [Required]
    public string NationalityName { get; set; }
    [Required]
    public string DisabilityName { get; set; }

    public int? MonthlyIncome { get; set; }

    [Required]
    public bool Pensioner { get; set; }
    [Required]
    public bool LiableForMilitaryService { get; set; }

    public override string ToString()
    {
      return $"{Surname} {Name} {Patronymic}";
    }
  }
}