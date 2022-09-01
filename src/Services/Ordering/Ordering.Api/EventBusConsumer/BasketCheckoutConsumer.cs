using EventBus.Messages.Events;
using MassTransit;

namespace Ordering.Api.EventBusConsumer
{
    public class BasketCheckoutConsumer: IConsumer<BasketCheckoutEvent>
    {
    }
}
