﻿using System;
using System.Collections.Generic;
using System.IO;
using ClashLand.Extensions;
using ClashLand.Extensions.List;
using ClashLand.Logic.Structure.Slots.Items;
using Newtonsoft.Json;
using ClashLand.Logic.Structure.Slots;
using ClashLand.Files;

namespace ClashLand.Logic
{
    internal class Objects : IDisposable
    {
        internal Level Player;
        internal string Json;
        internal DateTime Timestamp = DateTime.UtcNow;

        internal Objects(Level player, String Village)
        {
            this.Player = player;
            this.Json = Village;
        }

        internal byte[] ToBytes
        {
            get
            {
                List<byte> _Packet = new List<byte>();

                _Packet.AddInt((int)TimeUtils.ToUnixTimestamp(Timestamp));

                _Packet.AddLong(this.Player.Avatar.UserId);

                _Packet.AddInt(this.Player.Avatar.Shield);
                _Packet.AddInt(this.Player.Avatar.Guard);

                _Packet.AddInt((int)TimeSpan.FromDays(365).TotalSeconds); //Personal break

                _Packet.AddCompressed(this.Json);
                _Packet.AddCompressed(Game_Events.Events_Json);
                _Packet.AddCompressed("{\"Village2\":{\"TownHallMaxLevel\":9}}");
                return _Packet.ToArray();
            }
        }

        void IDisposable.Dispose()
        {
            this.Player = null;
            this.Json = null;
        }
    }
}