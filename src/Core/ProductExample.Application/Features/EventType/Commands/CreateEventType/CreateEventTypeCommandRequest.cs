using Lms.Application.Features.Base;

namespace Lms.Application.Features.EventType.Commands.CreateEventType
{
    public class CreateEventTypeCommandRequest : BaseRequest
    {
        public string Name { get; set; }
    }
}
