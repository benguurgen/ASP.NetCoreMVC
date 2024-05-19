using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Example05Models.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name="Adı")]
        public string Name { get; set; }
        [Display(Name = "Soyadı")]
        public string Surname { get; set; }
        [EmailAddress]
        [Display(Name = "E-Mail Adresi")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Doğum Tarihi")]
        public DateOnly BirthDate { get; set; }
        [Display(Name = "Cinsiyeti")]
        public Gender Gender { get; set; }
        [Display(Name = "Durumu")]
        public StudentStatus StudentStatus { get; set; }

    }
    public enum Gender
    {
        [Display(Name = "Erkek")]
        Male,
        [Display(Name = "Kadın")]
        Female
    }
    public enum StudentStatus
    {
        [Display(Name = "Pasif")]
        Passive,
        [Display(Name = "Aktif")]
        Active,
        [Display(Name = "Askıda")]
        Suspend
    }
}
