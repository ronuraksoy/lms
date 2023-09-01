using Lms.Application.Features.Base;

namespace Lms.Application.Features.Unit.Commands.CreateUnit
{
    public class CreateUnitCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
