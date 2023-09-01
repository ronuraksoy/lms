using Lms.Application.Features.Base;

namespace Lms.Application.Features.User.Commands.CreateUser
{
    public class CreateUserCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
