﻿using System.Numerics;
using SharpMC.Core.Utils;

namespace SharpMC.Core.Networking.Packages
{
	internal class EntityRelativeMove : Package<EntityRelativeMove>
	{
		public Vector3 Movement;
		public Player Player;

		public EntityRelativeMove(ClientWrapper client) : base(client)
		{
			SendId = 0x15;
		}

		public EntityRelativeMove(ClientWrapper client, DataBuffer buffer) : base(client, buffer)
		{
			SendId = 0x15;
		}

		public override void Write()
		{
			if (Buffer != null)
			{
				Buffer.WriteVarInt(SendId);
				Buffer.WriteVarInt(Player.EntityId);
				Buffer.WriteByte((byte) (Movement.X*32));
				Buffer.WriteByte((byte) (Movement.Y*32));
				Buffer.WriteByte((byte) (Movement.Z*32));
				Buffer.WriteBool(Player.KnownPosition.OnGround);
				Buffer.FlushData();
			}
		}
	}
}