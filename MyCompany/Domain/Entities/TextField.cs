using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Denumirea paginii (titlul)")]
        public override string Title { get; set; } = "Pagina de informatii";

        [Display(Name = "Continutul paginii")]
        public override string Text { get; set; } = "Conținutul este completat de administrator";
    }
}
