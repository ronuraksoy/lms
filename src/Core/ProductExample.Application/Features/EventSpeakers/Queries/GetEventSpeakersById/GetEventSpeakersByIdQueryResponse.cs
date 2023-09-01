namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersById
{
    public class GetEventSpeakersByIdQueryResponse
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
        public string LinkedIn { get; set; }
        public string Photo { get; set; }
        public string EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
    }
}
