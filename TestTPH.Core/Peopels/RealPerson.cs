using System.ComponentModel.DataAnnotations;

namespace TestTPH.Peopels
{
    public class RealPerson : Person
    {
        [MaxLength(128)]
        public string Name { get; set; }

        [MaxLength(128)]
        public string Family { get; set; }
    }
}
