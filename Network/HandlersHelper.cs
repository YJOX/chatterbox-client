using System.Collections.Generic;

namespace ChatterBox.Network
{
    class HandlersHelper
    {
        public static byte[] channels = {11, 22, 33, 44, 55, 66, 77};
        /* 0 - регистрация
         * 1 - подтверждение регистрации
         * 2 - авторизация
         * 3 - загрузка чатов
         * 4 - отправка сообщений
         * 5 - приём сообщений
         * 6 - создание нового чата */

        public static byte[] toByteArray(byte[] array, int channelID)
        {
            List<byte> protocol = new List<byte>();

            protocol.Add(channels[channelID]);
            protocol.AddRange(array);
            return protocol.ToArray();
        }
    }
}