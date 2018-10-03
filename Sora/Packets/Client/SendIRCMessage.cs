﻿using System;
using Shared.Enums;
using Shared.Helpers;
using Shared.Interfaces;
using Sora.Packets.Server;

namespace Sora.Packets.Client
{
    public class SendIrcMessage : IPacketSerializer
    {
        public PacketId Id => PacketId.ClientSendIrcMessage;

        public MessageStruct Msg;

        public void ReadFromStream(MStreamReader sr) =>
            Msg = new MessageStruct
            {
                Username = sr.ReadString(),
                Message = sr.ReadString(),
                ChannelTarget = sr.ReadString(),
                SenderId = sr.ReadInt32()
            };

        public void WriteToStream(MStreamWriter sw) => throw new NotImplementedException();
    }
}
