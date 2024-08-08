using TellDontAskKata.Main.Repository;

namespace TellDontAskKata.Main.UseCase
{
    public class OrderApprovalUseCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderApprovalUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Run(OrderApprovalRequest request)
        {
            var order = _orderRepository.GetById(request.OrderId);

            if (order.IsShipped())
            {
                throw new ShippedOrdersCannotBeChangedException();
            }

            if (request.Approved && order.IsRejected())
            {
                throw new RejectedOrderCannotBeApprovedException();
            }

            if (!request.Approved && order.IsApproved())
            {
                throw new ApprovedOrderCannotBeRejectedException();
            }

            _orderRepository.Save(order.ApprovalFrom(request.Approved));
        }
    }
}