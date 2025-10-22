using BlazorApp.Data;
using FluentValidation;

namespace BlazorApp
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            // 定义验证规则
            RuleFor(user => user.Name)
                .NotEmpty().WithMessage("姓名不能为空。") // 非空验证
                .MaximumLength(10).WithMessage("姓名长度不能超过10个字符。"); // 最大长度验证

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("邮箱地址不能为空。")
                .EmailAddress().WithMessage("请输入有效的邮箱地址。"); // 邮箱格式验证
        }
    }
}
