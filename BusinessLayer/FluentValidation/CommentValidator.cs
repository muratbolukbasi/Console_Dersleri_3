using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Yorum boş bırakılamaz");
            RuleFor(x => x.CommentContent).MinimumLength(2).WithMessage("Yorum en az 2 karakter içermelidir");          
        }
    }
}
