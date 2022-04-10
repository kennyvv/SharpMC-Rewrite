﻿using SharpMC.Network.Util;

namespace SharpMC.Network.Packets.Play.ToServer
{
    public class QueryBlockNbt : Packet<QueryBlockNbt>, IToServer
    {
        public byte ServerId => 0x01;

        public int TransactionId { get; set; }
        public System.Numerics.Vector3 Location { get; set; }

        public override void Decode(IMinecraftStream stream)
        {
            TransactionId = stream.ReadVarInt();
            Location = stream.ReadPosition();
        }

        public override void Encode(IMinecraftStream stream)
        {
            stream.WriteVarInt(TransactionId);
            stream.WritePosition(Location);
        }
    }
}