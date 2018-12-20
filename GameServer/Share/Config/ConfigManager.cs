﻿
namespace Share.Config
{
    public class ConfigManager : Singleton<ConfigManager>
    {
        public const string LOCAL_IP_ADDRESS = "127.0.0.1";

        public const int TCP_GATEWAY_SERVER_CONNECT_PORT = 13000;
        public const int TCP_CENTER_SERVER_CONNECT_PORT = 15000;

        public const uint GAME_SERVER_ID = 100;
    }
}
