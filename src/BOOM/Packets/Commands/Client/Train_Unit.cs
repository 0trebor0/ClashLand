﻿using System;
using System.Runtime.Serialization;
using CRepublic.Boom.Files.CSV_Logic;
using CRepublic.Boom.Logic.Components;
using CRepublic.Boom.Logic.Enums;
using CRepublic.Boom.Logic.Structure;

namespace CRepublic.Boom.Packets.Commands.Client
{
    using CRepublic.Boom.Extensions.Binary;
    using CRepublic.Boom.Files;
    using CRepublic.Boom.Logic;

    internal class Train_Unit : Command
    {
        internal int BuildnigId;
        internal int Unknown2;
        internal int UnitType;
        internal int Count;
        internal int Unknown3;
        internal int Tick;

        public Train_Unit(Reader _Reader, Device _Client, int _ID) : base(_Reader, _Client, _ID)
        {
        }
        internal override void Decode()
        {
            this.BuildnigId = this.Reader.ReadInt32();
            this.Unknown2 = this.Reader.ReadInt32();
            this.UnitType = this.Reader.ReadInt32();
            this.Unknown3 = this.Reader.ReadInt32();
            this.Count = this.Reader.ReadInt32();
            this.Tick = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            ShowValues();
            GameObject go = this.Device.Player.GameObjectManager.GetGameObjectByID(this.BuildnigId);

            var characters = CSV.Tables.GetWithGlobalID(this.UnitType) as Characters;
            Building b = (Building)go;

            Console.WriteLine($"Unit Name {characters.Name}");
            Console.WriteLine($"Unit Space {characters.HousingSpace}");
            Console.WriteLine($"Unit Cost {characters.GetTrainingCost(0)}");

            Console.WriteLine($"Building Name {b.GetBuildingData().Name}");
            Console.WriteLine($"Building Space {b.GetBuildingData().HousingSpace[b.GetUpgradeLevel()]}");
        }
    }
}
