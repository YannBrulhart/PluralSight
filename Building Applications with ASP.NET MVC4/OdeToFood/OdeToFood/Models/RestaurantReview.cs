namespace OdeToFood.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RestaurantReview : IValidatableObject
    {
        #region Public Properties

        [StringLength(1024)]
        public string Body { get; set; }

        public int Id { get; set; }

        [Range(1, 10)]
        [Required]
        public int Rating { get; set; }

        public int RestaurantId { get; set; }

        [Display(Name = "User Name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string ReviewerName { get; set; }

        #endregion

        #region Public Methods and Operators

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Rating < 2 && this.ReviewerName.ToLower().StartsWith("scott"))
            {
                yield return new ValidationResult("Sorry, Scott, you can't do this");
            }
        }

        #endregion
    }
}