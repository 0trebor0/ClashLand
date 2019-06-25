﻿using System;
using ClashLand.Core;
using ClashLand.Extensions;
using ClashLand.Extensions.List;
using ClashLand.Logic;
using ClashLand.Logic.Enums;

namespace ClashLand.Packets.Messages.Server.Clans.War
{
    internal class War_Map : Message
    {
        public War_Map(Device Device) : base(Device)
        {
            this.Identifier = 24335;
        }

        internal override void Encode()
        {
            this.Data.AddInt((int) WarState.BATTLE_DAY);
            this.Data.AddInt((int) TimeSpan.FromHours(900).TotalSeconds);
            this.Data.AddLong(this.Device.Player.Avatar.ClanId);
            var clan = Resources.Clans.Get(this.Device.Player.Avatar.ClanId);

            this.Data.AddString(clan.Name);
            this.Data.AddInt(clan.Badge);
            this.Data.AddInt(clan.Level);
            this.Data.AddInt(0);
            this.Data.AddInt(2);

            this.Data.AddLong(this.Device.Player.Avatar.ClanId);
            this.Data.AddLong(this.Device.Player.Avatar.UserId);
            this.Data.AddLong(this.Device.Player.Avatar.UserId);
            this.Data.AddString("Aidid ❤ Vicky");

            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);

            this.Data.AddInt(0);
            this.Data.AddInt(1);
            this.Data.AddInt(this.Device.Player.Avatar.TownHall_Level);
            this.Data.AddInt(0);
            this.Data.AddByte(2);

            this.Data.AddInt(68);
            this.Data.AddInt(5160299);
            this.Data.AddInt(0);
            this.Data.AddByte(0);

            this.Data.AddInt(4); //Castle level
            this.Data.AddInt(30); //Castle space
            this.Data.AddString("Hi"); //Request message
            this.Data.AddInt(0); //Used space
            this.Data.AddInt(0); //Total donator

            this.Data.AddLong(this.Device.Player.Avatar.ClanId);
            this.Data.AddLong(this.Device.Player.Avatar.UserId + 1);
            this.Data.AddLong(this.Device.Player.Avatar.UserId + 1);
            this.Data.AddString("Craycray");


            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);

            this.Data.AddInt(0);
            this.Data.AddInt(1);
            this.Data.AddInt(this.Device.Player.Avatar.TownHall_Level);
            this.Data.AddInt(1);
            this.Data.AddByte(2);

            this.Data.AddInt(68);
            this.Data.AddInt(5160299);
            this.Data.AddInt(0);
            this.Data.AddByte(0);

            this.Data.AddInt(4); //Castle level
            this.Data.AddInt(30); //Castle space
            this.Data.AddString("Hi"); //Request message
            this.Data.AddInt(0); //Used space
            this.Data.AddInt(0); //Total donator

            //this.Data.AddHexa("0000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C50000001C004864880000001C00486488000000076772656768616E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020100000638000000010000000A000000010200000044004EBD6B000000000000000003000000190000000000000014000000010000000F004B2BB200000001003D090800000004000000210039C8C50000000E00BECCCB0000000E00BECCCB0000000C6D69636865616C2E6C6F6674000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003940000042B0000000100000009000000020200000044004EBD6B0000000000000000040000001E0000000B64726167676F6E20746E780000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C5000000410057266A000000410057266A00000008736F6B68797A696E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000037E000003FD0000000100000009000000030200000044004EBD6B0000000000000000040000001E00000006447261676F6E0000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C50000003C012DA3860000003C012DA38600000025E19E99E19EBBE19E9CE19E87E19E9320E19E80E19EBCE19E93E19E93E19EB6E19E82E19E9F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001BB000003420000000100000009000000040200000044004EBD6B000000000000000003000000190000000000000014000000010000000F004B2BB200000001003D090800000004000000210039C8C50000001E00123BDA0000001E00123BDA000000026B61000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001D7000002A1000000010000000A000000050200000044004EBD6B000000000000000003000000190000000000000014000000010000000F004B2BB200000001003D090800000004000000210039C8C500000048000635EE00000048000635EE00000009502E452E4B2E4B2E41000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002F4000002570000000100000008000000060200000044004EBD6B0000000000000000040000001E0000001464672070617220736F206E6120206467646764670000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C50000005A00A83FBB0000005A00A83FBB000000056B6F6D696E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000114000002570000000100000009000000070200000044004EBD6B00000000000000000300000019000000056B6F6D696E00000014000000010000000F004B2BB200000001003D090800000004000000210039C8C50000005800CF10170000005800CF10170000000A6B6F6B6F6B616C69707A00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000263000002370000000100000008000000080200000044004EBD6B0000000000000000040000001E000000000000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C500000054006CC74400000054006CC7440000000A547572656C6368656D69000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002850000022C0000000100000008000000090200000044004EBD6B0000000000000000040000001E000000000000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C500000046008E446100000046008E44610000000C416D416E206D636C6172656E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002D50000021A00000001000000080000000A0200000044004EBD6B0000000000000000040000001E000000000000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C50000005A001A6CEE0000005A001A6CEE0000000D245E5F5E6E68C3A26E5E5F5E240000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000024D0000020B00000001000000080000000B0200000044004EBD6B0000000000000000040000001E0000001663686F206C696E68206368756F6E67206E68612021210000001E000000010000000F004B2BB200000002003D090800000004003D091700000001000000210039C8C500000056005C82D500000056005C82D50000000942616C6C2042616C6C00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000228000001FD00000001000000080000000C0200000044004EBD6B000000000000000003000000190000000000000014000000010000000F004B2BB200000001003D090800000004000000210039C8C50000005A00BC1C2C0000005A00BC1C2C0000000753616920546169000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001B4000001FB00000001000000080000000D0200000044004EBD6B0000000000000000040000001E000000000000001E000000010000000F004B2BB200000003003D091700000001003D091700000001003D091700000001000000210039C8C50000002A007219450000002A007219450000000B41686D61642E4F7A61697200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000218000001EF00000001000000080000000E0200000044004EBD6B0000000000000000030000001900000017D8AFD8B1D8A7DAAFD988D98620D8AFD981D8A7D8B9DB8C00000014000000010000000F004B2BB200000002003D091700000001003D091700000001000000210039C8C50000005700B514590000005700B51459000000096D61726B7368616E6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000213000001ED00000001000000080000000F0200000044004EBD6B0000000000000000040000001E000000000000000A000000010000000F004B2BB200000001003D091700000001000000210039C8C50000004D011375F30000004D011375F30000000D4B726973686E612064656F72690000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000026A000001EB0000000100000008000000100200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C5000000270078FBC4000000270078FBC4000000087065726F6D70616B0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000019B000001E40000000100000008000000110200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C50000000F004B2BB20000000F004B2BB2000000044A6F6E6F00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000232000001E10000000100000008000000120200000044004EBD6B00000000000000000300000019000000226C766C34206F722061626F76652077697A206F7220616E79206C766C20647261672E0000000000000000000000210039C8C500000007000C828600000007000C82860000000E52696C6579204461766964736F6E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000230000001D30000000100000008000000130200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C50000000700F6CEEA0000000700F6CEEA000000047068796F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001F9000001D30000000100000008000000140200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C50000005201278A060000005201278A06000000077072617665656E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000265000001BE0000000100000008000000150200000044004EBD6B0000000000000000040000001E000000000000000000000000000000210039C8C5000000490142373800000049014237380000000F4D442073616C696D20424420424F4F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000024E000001B60000000100000008000000160200000044004EBD6B0000000000000000040000001E0000000C76616C6C6B656469206461770000000000000000000000210039C8C50000001A00A348680000001A00A348680000000954757368617240393800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000217000001AE0000000100000008000000170200000044004EBD6B000000000000000003000000190000000664726567616E0000000000000000000000210039C8C5000000530131FA95000000530131FA950000000A526A696E7461303530360000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010C000001A30000000100000008000000180200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C500000028004304050000002800430405000000092A436F78792032372A000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001DC0000019D0000000100000009000000190200000044004EBD6B000000000000000003000000190000002863616E20616E796F6E652068656C70206D65206F7574207769746820736F6D652074726F6F70733F0000000000000000000000210039C8C500000038007A15CE00000038007A15CE00000005526F68616E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001970000018F00000001000000080000001A0200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C50000001901572763000000190157276300000004786E7878000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000FF0000018600000001000000080000001B0200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C500000048015A82D200000048015A82D20000000B66696768746572206D616E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ED0000018000000001000000080000001C0200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C50000005600EB79AB0000005600EB79AB0000000770686561726F6D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010A0000016E00000001000000080000001D0200000044004EBD6B0000000000000000030000001900000006447261676F6E0000000000000000000000210039C8C500000038014B990E00000038014B990E0000000670726176696E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001070000016D00000001000000080000001E0200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C5000000120126E930000000120126E93000000005524148554C000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001360000015B00000001000000070000001F0200000044004EBD6B000000000000000003000000190000001276616C6B79726965206F7220447261676F6E0000000000000000000000210039C8C500000053005CE2A900000053005CE2A90000000461726966000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001210000015A0000000100000008000000200200000044004EBD6B00000000000000000300000019000000056769616E740000000000000000000000210039C8C50000002900BBCCE70000002900BBCCE70000000462616E6B0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013D0000014D0000000100000007000000210200000044004EBD6B0000000000000000030000001900000015E0B882E0B8ADE0B980E0B881E0B988E0B887E0B9860000000000000000000000210039C8C50000000F013E3A3D0000000F013E3A3D0000000D3A2D2920726173656C203A2D2900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000131000001470000000100000007000000220200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C50000003E013DFA1B0000003E013DFA1B0000000973756C6D696B61696C00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000137000001440000000100000007000000230200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C50000000000D1B9B60000000000D1B9B60000000676696B696E6700000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000128000001420000000100000007000000240200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C500000020014B69A800000020014B69A8000000076D6F65206C617900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000109000001280000000100000007000000250200000044004EBD6B00000000000000000300000019000000000000000000000000000000210039C8C500000017011DE27900000017011DE2790000000461676F6E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C0000000F70000000100000007000000260200000044004EBD6B000000000000000003000000190000000876616C6B797269650000000000000000000000210039C8C500000046016123A000000046016123A000000005736F654040000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000AB000000BD0000000100000006000000270200000044004EBD6B00000000000000000200000014000000000000000000000000");
            this.Data.AddHexa("03FFFFFFFF000000010000000A0000001900000032000000280000003C01");

            this.Data.AddLong(20);
            this.Data.AddString("Ultrapowa");
            this.Data.AddInt(clan.Badge + 100);
            this.Data.AddInt(clan.Level);
            this.Data.AddInt(0);
            this.Data.AddInt(3);
            this.Data.AddLong(20);
            this.Data.AddLong(10);
            this.Data.AddLong(10);
            this.Data.AddString($"Eishit The DMCA Master 2.0");

            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);

            this.Data.AddInt(0);
            this.Data.AddInt(1);
            this.Data.AddInt(1);
            this.Data.AddInt(0);
            this.Data.AddByte(2);

            this.Data.AddInt(68);
            this.Data.AddInt(5160299);
            this.Data.AddInt(0);
            this.Data.AddByte(0);

            this.Data.AddInt(4); //Castle level
            this.Data.AddInt(30); //Castle space
            this.Data.AddString("Hi"); //Request message
            this.Data.AddInt(0); //Used space
            this.Data.AddInt(0); //Total donator

            this.Data.AddLong(20);
            this.Data.AddLong(11);
            this.Data.AddLong(11);
            this.Data.AddString($"Clash Of Light The One That Have Everything");

            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);

            this.Data.AddInt(0);
            this.Data.AddInt(1);
            this.Data.AddInt(1);
            this.Data.AddInt(1);
            this.Data.AddByte(2);

            this.Data.AddInt(68);
            this.Data.AddInt(5160299);
            this.Data.AddInt(0);
            this.Data.AddByte(0);

            this.Data.AddInt(4); //Castle level
            this.Data.AddInt(30); //Castle space
            this.Data.AddString("Hi"); //Request message
            this.Data.AddInt(0); //Used space
            this.Data.AddInt(0); //Total donator

            this.Data.AddLong(20);
            this.Data.AddLong(11);
            this.Data.AddLong(11);
            this.Data.AddString($"Metrogaming The One That Have Nothing");

            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(0);

            this.Data.AddInt(0);
            this.Data.AddInt(1);
            this.Data.AddInt(1);
            this.Data.AddInt(1);
            this.Data.AddByte(2);

            this.Data.AddInt(68);
            this.Data.AddInt(5160299);
            this.Data.AddInt(0);
            this.Data.AddByte(0);

            this.Data.AddInt(4); //Castle level
            this.Data.AddInt(30); //Castle space
            this.Data.AddString("Hi"); //Request message
            this.Data.AddInt(0); //Used space
            this.Data.AddInt(0); //Total donator
            this.Data.AddHexa("03FFFFFFFF000000010000000A0000001900000032000000280000003C01");
            this.Data.AddHexa("00000044004EBD6B00000000010000004C00081A3C00000000");
            //this.Data.AddHexa("000004C00081A3C0000000D5265616C2104A7576656E747564630013550000000900000000000000280000004C00081A3C0000003700903368000000370090336800000008454C204D454A4F520000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000037800000667000000010000000A000000000200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C00000017004BA8C600000017004BA8C60000000C454457494E2047414D455A2E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000050F000004700000000100000009000000010200000044004EBD6B000000000000000005000000230000000000000023000000000000004C00081A3C000000270009493000000027000949300000000546726564790000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000038A000003FE0000000100000009000000020200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000002700A401890000002700A401890000000C6279726F6E20636165203132000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003B7000003EF0000000100000009000000030200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000002A000913F70000002A000913F700000007617175696C6573000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003AD0000029D0000000100000009000000040200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000002F011A27ED0000002F011A27ED0000000A44E282AC4044244830540000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000021B00000263000000010000000A000000050200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000001A0062C0B70000001A0062C0B70000000D6A6176696572206D656C676172000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003450000025B0000000100000008000000060200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C0000001900003CE90000001900003CE90000000F617263616E67656C206D656C6761720000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000034A000002590000000100000008000000070200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000001C00D7DF0B0000001C00D7DF0B000000046D696C69000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002F7000002560000000100000008000000080200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C00000041001981DE00000041001981DE0000000D64616E69656C206D656C676172000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003330000024F0000000100000008000000090200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000000F007C36330000000F007C36330000000A6A6F65206D656C676172000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002F00000024800000001000000080000000A0200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000001F006D11D80000001F006D11D80000000758696F6D617261000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002E90000024300000001000000080000000B0200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C0000002C002FE1BC0000002C002FE1BC0000000B6976696E206D656C676172000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002EF0000024100000001000000080000000C0200000044004EBD6B0000000000000000040000001E000000000000001E000000000000004C00081A3C00000008005D34C000000008005D34C00000000447616C6F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003060000024000000001000000080000000D0200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C0000002C00C8495C0000002C00C8495C000000057269636B79000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002CF0000023200000001000000080000000E0200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C00000034009F567B00000034009F567B0000000A4956494E20434C415348000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002B40000021F00000001000000080000000F0200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C0000005D005570670000005D00557067000000036B6E6F00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000267000002120000000100000008000000100200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C00000036007CECF900000036007CECF900000006686F6C6D616E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000290000002060000000100000008000000110200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C000000440097B389000000440097B38900000017E299A6E299A64954414348495F4449415AE299A6E299A60000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000028D000002050000000100000008000000120200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C0000004200E2973C0000004200E2973C000000066A616665746800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000266000001F30000000100000008000000130200000044004EBD6B0000000000000000040000001E0000000000000000000000000000004C00081A3C0000002500E9F8EE0000002500E9F8EE0000000F4E65796D617220457370696E6F7A6100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000238000001D00000000100000008000000140200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000000300AECDF60000000300AECDF60000000648756172676F00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000164000001CD0000000100000008000000150200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000001E00FB66340000001E00FB6634000000046F646972000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001EE000001AF0000000100000008000000160200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000003D00272DB00000003D00272DB000000005706570696F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000014A0000015C0000000100000007000000170200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C00000040009A0C9600000040009A0C960000000B436861706F47757A6D616E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001410000015C0000000100000007000000180200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000002100C0097A0000002100C0097A0000000C45445520454C204D4143484F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000014B000001580000000100000007000000190200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C00000010008A0AE700000010008A0AE70000000A4E6174616C6961203A33000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001380000015800000001000000070000001A0200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000000400B865650000000400B865650000000B6A61736F6E206D6172696E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001450000015700000001000000070000001B0200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000001100C7314F0000001100C7314F0000000F786F6368696C742079616D696C6574000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001470000015600000001000000070000001C0200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000003200F715C20000003200F715C20000000E656C6D657263656E6172696F2032000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001440000015600000001000000070000001D0200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C000000140053C5F5000000140053C5F50000000B76656765747461203737370000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013D0000015400000001000000070000001E0200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000001D00B2B7E10000001D00B2B7E1000000086875676F202333380000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013C0000015200000001000000070000001F0200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000001900644EBD0000001900644EBD000000074661627269505000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000141000001510000000100000007000000200200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000005100629AEF0000005100629AEF000000096176652066656E69780000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000012B0000014D0000000100000007000000210200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000002D00B9E44A0000002D00B9E44A00000008434841434F52544100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000149000001440000000100000007000000220200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C000000140112756700000014011275670000000E44414E49454C204D454C4741522E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001200000013E0000000100000007000000230200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C0000005D00FC90540000005D00FC9054000000056F63686F61000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000EA000001130000000100000007000000240200000044004EBD6B000000000000000003000000190000000000000000000000000000004C00081A3C000000340156C476000000340156C4760000000E616E6120646520636162726572610000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010C000000EE0000000100000007000000250200000044004EBD6B000000000000000003000000190000000000000014000000000000004C00081A3C0000005A0129F2CD0000005A0129F2CD00000017E299A1E29DA45052214E43E282AC244024E29DA4E299A1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C8000000D20000000100000007000000260200000044004EBD6B000000000000000003000000190000000000000014000000000000004C00081A3C00000041013848CD00000041013848CD000000067261756C696E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008E000000C20000000100000006000000270200000044004EBD6B0000000000000000020000001400000000000000140000000003FFFFFFFF000000010000000A0000001900000032000000280000003C0100000044004EBD6B00000000010000004C00081A3C00000000");

        }
    }
}
