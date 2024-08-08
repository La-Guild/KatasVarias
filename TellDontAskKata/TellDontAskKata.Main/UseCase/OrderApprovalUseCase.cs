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

            if (order.IsApprovedAfterRejection(request.Approved))
            {
                throw new RejectedOrderCannotBeApprovedException();
            }

            if (order.IsRejectedAfterApproval(request.Approved))
            {
                throw new ApprovedOrderCannotBeRejectedException();
            }

            _orderRepository.Save(order.ApprovalFrom(request.Approved));
        }



    }
}