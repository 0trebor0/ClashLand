﻿using CRepublic.Royale.Logic;

namespace CRepublic.Royale.Packets.Messages.Client
{
    using System;
    using CRepublic.Royale.Core.Network;
    using CRepublic.Royale.Extensions.Binary;
    using CRepublic.Royale.Packets.Commands.Server;
    using CRepublic.Royale.Packets.Messages.Server;
    internal class Change_Name : Message
    {
        internal string Name;
        internal byte NameSet;

        public Change_Name(Device Device, Reader Reader) : base(Device, Reader)
        {
            // Change_Name.
        }

        /// <summary>
        /// Decodes this message.
        /// </summary>
        internal override void Decode()
        {
            this.Name = this.Reader.ReadString();
            this.NameSet = this.Reader.ReadByte();
        }

        /// <summary>
        /// Processes this instance.
        /// </summary>
        internal override void Process()
        {
            this.Device.Player.Username = this.Name;
            this.Device.Player.NameSet = this.NameSet;

            new Server_Commands(this.Device, new Name_Change_Callback(this.Device)).Send();
        }
    }
}
