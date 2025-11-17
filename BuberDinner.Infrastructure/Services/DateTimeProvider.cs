using BubberDinner.Application.Common.Interfaces.Services;

namespace BuberDinner.Application.Common.Interfaces.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}