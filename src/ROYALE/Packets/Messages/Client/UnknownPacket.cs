﻿using System;
using CRepublic.Royale.Extensions.Binary;
using CRepublic.Royale.Logic;

namespace CRepublic.Royale.Packets.Messages.Client
{
    internal class UnknownPacket : Message
    {
        public UnknownPacket(Device Device, Reader Reader) : base(Device, Reader)
        {
            // Used for finding data of unknown packets
        }

        internal override void Decode()
        {
            Console.WriteLine(BitConverter.ToString(this.Reader.ReadFully()));
        }

        internal override void Process()
        {
            
        }
    }
}
