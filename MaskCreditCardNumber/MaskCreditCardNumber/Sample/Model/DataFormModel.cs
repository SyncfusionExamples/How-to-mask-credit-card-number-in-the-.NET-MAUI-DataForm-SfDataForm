using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MaskCreditCardNumber
{
    public class DataFormModel
    {
        public DataFormModel()
        {
            this.Name = string.Empty;
            this.Email = string.Empty;
            this.CardNumber = string.Empty;
        }

        [Display(Name = "Name", Prompt = "Enter your name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Display(Prompt = "Enter your MailID")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your MailID")]
        public string Email { get; set; }

        [Display(ShortName = "Card Number")]
        [DataType(DataType.PhoneNumber)]
        public string CardNumber { get; set; }
    }
}