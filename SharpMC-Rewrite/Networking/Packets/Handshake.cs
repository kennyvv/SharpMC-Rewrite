﻿using System;
using System.Net;

namespace SharpMCRewrite.Packets
{
    public class Handshake : IPacket
    {
        public int PacketID
        {
            get
            {
                return 0x00;
            }
        }

        public bool IsPlayePacket
        {
            get
            {
                return false;
            }
        }

        public void Read(ClientWrapper state, MSGBuffer buffer, object[] Arguments)
        {
            int Protocol = buffer.ReadVarInt ();
            string Host = buffer.ReadString ();
            short Port = buffer.ReadShort ();
            int State = buffer.ReadVarInt ();

            switch (State)
            {
                case 1:
                    HandleStatusRequest (state, buffer);
                    break;
                case 2:
                    HandleLoginRequest (state, buffer);
                    break;
            }
        }

        private void HandleStatusRequest (ClientWrapper state, MSGBuffer buffer)
        {
            buffer.WriteVarInt (PacketID);
            buffer.WriteString("{\"version\": {\"name\": \"" + Globals.ProtocolName + "\",\"protocol\": " + Globals.ProtocolVersion + "},\"players\": {\"max\": " + Globals.MaxPlayers + ",\"online\": " + Globals.Level.OnlinePlayers.Count + "},\"description\": {\"text\":\"" + Globals.RandomMOTD + "\"}}");
            buffer.FlushData();
        }

        private void HandleLoginRequest (ClientWrapper state, MSGBuffer buffer)
        {
            string Username = buffer.ReadUsername ();
            string UUID = getUUID (Username);

            new LoginSuccess().Write(state, buffer, new object[] {UUID, Username});
            Globals.LastUniqueID++;
            state.Player = new Player () { UUID = UUID, Username = Username, UniqueServerID = Globals.LastUniqueID, Wrapper = state, Gamemode = Gamemode.Creative };
            state.PlayMode = true; //Toggle the boolean to PlayMode so we know we are not handling Status stuff anymore.

            if (!Globals.UseCompression)
                new SetCompression().Write (state, buffer, new object[] { -1 }); //Turn off compression.

            new JoinGame ().Write (state, buffer, new object[ ] { state.Player });
            new SpawnPosition ().Write (state, buffer, new object[0]);
            state.StartKeepAliveTimer ();
            state.Player.SendChunksFromPosition ();
        }

        private string getUUID(string username)
        {
            try
            {
                WebClient wc = new WebClient();
                string result = wc.DownloadString("https://api.mojang.com/users/profiles/minecraft/" + username);
                string[] _result = result.Split('"');
                if (_result.Length > 1)
                {
                    string UUID = _result [3];
                    return new Guid(UUID).ToString();
                } 
                else
                {
                    return Guid.NewGuid().ToString();
                }
            }
            catch
            {
                return Guid.NewGuid().ToString();
            }
        }

        public void Write(ClientWrapper state, MSGBuffer buffer, object[] Arguments)
        {

        }
    }
}
