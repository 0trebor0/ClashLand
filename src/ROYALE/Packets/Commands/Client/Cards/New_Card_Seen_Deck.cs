﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepublic.Royale.Extensions.Binary;
using CRepublic.Royale.Logic;

namespace CRepublic.Royale.Packets.Commands.Client.Cards
{
    internal class New_Card_Seen_Deck : Command
    {
        internal int Tick = 0;

        public New_Card_Seen_Deck(Reader Reader, Device Device, int ID) : base(Reader, Device, ID)
        {
        }

        internal override void Decode()
        {
            Console.WriteLine(BitConverter.ToString(Reader.ReadFully()));

            //this.Tick = this.Reader.ReadVInt();
            //this.Tick = this.Reader.ReadVInt();

            //this.Reader.ReadInt16();

            //this.Reader.ReadString();
        }

        internal override void Process()
        {
            //this.ShowValues();
        }
    }
}
