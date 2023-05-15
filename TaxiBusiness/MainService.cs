namespace TaxiBusiness
{
    public static class MainService
    {
        private static UserService? _userService;
        private static OrderService? _orderService;

        public static UserService GetUserService()
        {
            return _userService ??= new UserService();
        }
        public static OrderService GetOrderService()
        {
            return _orderService ??= new OrderService();
        }
        public static void Upload()
        {
            GetUserService().Upload();
            GetOrderService().Upload();
        }
    }
}
