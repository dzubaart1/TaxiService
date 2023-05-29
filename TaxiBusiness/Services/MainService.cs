using TaxiData;

namespace TaxiBusiness.Services
{
    public static class MainService
    {
        private static UserService? _userService;
        private static OrderService? _orderService;
        private static IdGeneratorService? _idGeneratorService;
        private static JsonStorage? _jsonStorage;

        public static UserService GetUserService()
        {
            return _userService ??= new UserService();
        }
        public static OrderService GetOrderService()
        {
            return _orderService ??= new OrderService();
        }
        public static IdGeneratorService GetIdGeneratorService()
        {
            return _idGeneratorService ??= new IdGeneratorService();
        }
        public static JsonStorage GetJsonStorage()
        {
            return _jsonStorage ??= new JsonStorage();
        }
        public static void Upload()
        {
            GetUserService().Upload();
            GetOrderService().Upload();
            GetIdGeneratorService().Upload();
        }

        public static string GetJsonPath()
        {
            return _jsonStorage.GetJsonPath();
        }

        public static string GetUserPath()
        {
            return _jsonStorage.GetUserPath();
        }

        public static string GetIdFilePath()
        {
            return _jsonStorage.GetIdFilePath();
        }
    }
}
