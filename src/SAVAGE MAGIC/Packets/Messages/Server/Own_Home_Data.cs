﻿using System;
using CRepublic.Magic.Extensions.List;
using CRepublic.Magic.Logic;
using CRepublic.Magic.Logic.Enums;

namespace CRepublic.Magic.Packets.Messages.Server
{
    internal class Own_Home_Data : Message
    {
        internal Level Avatar;

        internal Own_Home_Data(Device Device) : base(Device)
        {
            this.Identifier = 24101;
            //this.Device.Tick();
        }

        internal override void Encode()
        {
            using (Objects Home = new Objects(Avatar = this.Device.Player, Files.Home.Starting_Home))
            {
                this.Data.AddInt((int)(Home.Timestamp - DateTime.UtcNow).TotalSeconds);
                this.Data.AddInt(-1);

                this.Data.AddRange(Home.ToBytes);
                this.Data.AddRange(Avatar.Avatar.ToBytes);
                this.Data.AddInt(this.Device.State == State.WAR_EMODE ? 1 : 0);
                this.Data.AddInt(0);

                this.Data.AddLong(1462629754000);
                this.Data.AddLong(1462629754000);
                this.Data.AddLong(1462629754000);
                this.Data.AddInt(0);
            }
        }
    }
}
