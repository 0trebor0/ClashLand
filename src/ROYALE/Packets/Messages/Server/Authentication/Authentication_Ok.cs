﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepublic.Royale.Extensions.List;
using CRepublic.Royale.Library.Blake2B;
using CRepublic.Royale.Library.Sodium;
using CRepublic.Royale.Logic;
using CRepublic.Royale.Logic.Enums;
using CRepublic.Royale.Extensions;
using CRepublic.Royale.Packets.Cryptography;
using CRepublic.Royale.Core;

namespace CRepublic.Royale.Packets.Messages.Server.Authentication
{
    internal class Authentification_OK : Message
    {
        internal Authentification_OK(Device Device) : base(Device)
        {
            this.Identifier = 20104;
            this.Version = 1;
            this.Device.PlayerState = Client_State.LOGGED;
        }

        internal override void Encode()
        {
            string CurrentTime = DateTime.Now.ToLongTimeString();

            this.Data.AddLong(this.Device.Player.UserId); // UserID

            this.Data.AddLong(this.Device.Player.UserId); // HomeID

            this.Data.AddString(this.Device.Player.Token); // Token

            this.Data.AddString(this.Device.Player.Facebook.Identifier); // Facebook

            this.Data.AddString(null); // Gamecenter

            this.Data.AddVInt(this.Device.Major); // Major
            this.Data.AddVInt(this.Device.Minor); // Minor
            this.Data.AddVInt(this.Device.Revision); // Revision

            if (Constants.Mode == Server_Mode.PRODUCTION)
                this.Data.AddString("prod");
            else if (Constants.Mode == Server_Mode.STAGE)
                this.Data.AddString("stage");
            else
                this.Data.AddString("integration");

            this.Data.AddVInt(0); // Session Count
            this.Data.AddVInt(0); // Total Play Time Seconds
            this.Data.AddVInt(0); // Time since creation

            this.Data.AddString("1609113955765603"); // Facebook ID

            this.Data.AddString(TimeUtils.ToJavaTimestamp(DateTime.Now).ToString()); // Server Time
            this.Data.AddString(TimeUtils.ToJavaTimestamp(this.Device.Player.Created).ToString()); // Account Creation Date

            this.Data.AddVInt(0); // VInt

            this.Data.AddString(this.Device.Player.Google.Identifier); // Google Service ID

            this.Data.AddString(null);
            this.Data.AddString(null);

            this.Data.AddString(this.Device.Player.Region); // Region

            this.Data.AddString("http://7166046b142482e67b30-2a63f4436c967aa7d355061bd0d924a1.r65.cf1.rackcdn.com"); // Content URL
            this.Data.AddString("https://event-assets.clashroyale.com"); // Event Asset URL

            this.Data.AddByte(1);
        }
        internal override void EncryptSodium()
        {
            if (this.Device.PlayerState >= Client_State.LOGIN)
            {
                Blake2BHasher Blake = new Blake2BHasher();

                Blake.Update(this.Device.Crypto.SNonce);
                Blake.Update(this.Device.Crypto.PublicKey);
                Blake.Update(Key.Crypto.PublicKey);

                byte[] Nonce = Blake.Finish();
                byte[] Encrypted = this.Device.Crypto.RNonce.Concat(this.Device.Crypto.PublicKey).Concat(this.Data).ToArray();

                this.Data = new List<byte>(Sodium.Encrypt(Encrypted, Nonce, Key.Crypto.PrivateKey, this.Device.Crypto.PublicKey));
            }

            this.Length = (ushort)this.Data.Count;
        }
    }
}
