using System.ComponentModel.DataAnnotations;

namespace TestTPH.Peopels
{
    public class LegalPerson : Person
    {
        [MaxLength(128)]
        public string ManagerName { get; set; }
    }
}
