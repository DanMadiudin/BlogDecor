using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "completați denumirea serviciului")]
        [Display(Name = "Denumirea serviciului (titlul)")]
        public override string Title { get; set; }

        [Display(Name = "Descrierea scurta a serviciului")]
        public override string Subtitle { get; set; }

        [Display(Name = "Descrierea completă a serviciilor")]
        public override string Text { get; set; }
    }
}
