using System.Threading.Tasks;
using MassTransit;

namespace MT
{
    public class TestEventConsumer : IConsumer<TestEvent>
    {
        public Task Consume(ConsumeContext<TestEvent> context)
        {
            var a = context.Message.Text;
            return Task.CompletedTask;
        }
    }
}
