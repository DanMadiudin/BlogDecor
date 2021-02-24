using System;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }

        [Display(Name = "Denumirea (Titlul)")]
        public virtual string Title { get; set; }

        [Display(Name = "Descriere Scurta")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Descriere deplina")]
        public virtual string Text { get; set; }

        [Display(Name = "Titlul imaginii")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "Seo metateg Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "Seo metateg Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "Seo metateg Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
