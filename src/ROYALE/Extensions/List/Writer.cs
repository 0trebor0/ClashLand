﻿using System.IO;

namespace CRepublic.Royale.Extensions.List
{
    using CRepublic.Royale.Core;
    using CRepublic.Royale.Files.CSV_Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal static class Writer
    {

        /// <summary>
        /// Adds the byte.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddByte(this List<byte> _Packet, int _Value)
        {
            _Packet.Add((byte) _Value);
        }

        /// <summary>
        /// Adds the int.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddInt(this List<byte> _Packet, int _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse());
        }

        public static void AddByteArray(this List<byte> _Packet, byte[] data)
        {
            if (data == null)
                _Packet.AddInt(-1);
            else
            {
                _Packet.AddInt(data.Length);
                _Packet.AddRange(data);
            }
        }

        /// <summary>
        /// Adds the int endian.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddIntEndian(this List<byte> _Packet, int _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value));
        }

        /// <summary>
        /// Adds the int.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        /// <param name="_Skip">The skip.</param>
        public static void AddInt(this List<byte> _Packet, int _Value, int _Skip)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse().Skip(_Skip));
        }

        /// <summary>
        /// Adds the long.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddLong(this List<byte> _Packet, long _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse());
        }

        /// <summary>
        /// Adds the long.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        /// <param name="_Skip">The skip.</param>
        public static void AddLong(this List<byte> _Packet, long _Value, int _Skip)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse().Skip(_Skip));
        }

        /// <summary>
        /// Adds the bool.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">if set to <c>true</c> [value].</param>
        public static void AddBool(this List<byte> _Packet, bool _Value)
        {
            _Packet.Add(_Value ? (byte) 1 : (byte) 0);
        }

        /// <summary>
        /// Adds the string.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddString(this List<byte> _Packet, string _Value)
        {
            if (_Value == null)
            {
                _Packet.AddRange(BitConverter.GetBytes(-1).Reverse());
            }
            else
            {
                byte[] _Buffer = Encoding.UTF8.GetBytes(_Value);

                _Packet.AddInt(_Buffer.Length);
                _Packet.AddRange(_Buffer);
            }
        }

        /// <summary>
        /// Adds the unsigned short.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddUShort(this List<byte> _Packet, ushort _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse());
        }

        /// <summary>
        /// Adds the compressed data.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddCompressed(this List<byte> _Packet, string _Value, bool addbool = true)
        {
            if (addbool)
                _Packet.AddBool(Constants.PacketCompression);

            if (Constants.PacketCompression)
            {
                byte[] Compressed = Library.ZLib.ZlibStream.CompressString(_Value);

                _Packet.AddInt(Compressed.Length + 4);
                _Packet.AddRange(BitConverter.GetBytes(_Value.Length));
                _Packet.AddRange(Compressed);
            }
            else
                _Packet.AddString(_Value);
        }

        public static void AddGlobalID(this List<byte> _Packet, int _Value)
        {
            _Packet.AddVInt(GlobalID.GetID(_Value));
            _Packet.AddVInt(GlobalID.GetType(_Value));
        }

        public static void AddSCID(this List<byte> _Packet, int _Value)
        {
            _Packet.AddVInt(_Value * 1000000 + 0);
        }

        /// <summary>
        /// Add the VInt.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddVInt(this List<byte> _Packet, int _Value)
        {
            if (_Value > 63)
            {
                _Packet.Add((byte) (_Value & 0x3F | 0x80));

                if (_Value > 8191)
                {
                    _Packet.Add((byte) (_Value >> 6 | 0x80));

                    if (_Value > 1048575)
                    {
                        _Packet.Add((byte) (_Value >> 13 | 0x80));

                        if (_Value > 134217727)
                        {
                            _Packet.Add((byte) (_Value >> 20 | 0x80));
                            _Value >>= 27 & 0x7F;
                        }
                        else
                            _Value >>= 20 & 0x7F;
                    }
                    else
                        _Value >>= 13 & 0x7F;

                }
                else
                    _Value >>= 6 & 0x7F;
            }
            _Packet.Add((byte) _Value);
        }

        public static void AddVInt(this List<byte> _Packet, long _Value)
        {
            var Stream = new MemoryStream(6);
            byte Temp = 0;

            Temp = (byte) ((_Value >> 57) & 0x40L);
            _Value = _Value ^ (_Value >> 63);
            Temp |= (byte) (_Value & 0x3FL);

            _Value >>= 6;

            if (_Value != 0)
            {
                Temp |= 0x80;
                Stream.WriteByte(Temp);

                while (true)
                {
                    Temp = (byte) (_Value & (0x7FL));
                    _Value >>= 7;

                    Temp |= (byte) ((_Value != 0 ? 1 : 0) << 7);

                    Stream.WriteByte(Temp);

                    if (_Value == 0)
                        break;
                }
            }
            else
            {
                Stream.WriteByte(Temp);
            }

            _Packet.Add(0);
            _Packet.AddRange(Stream.ToArray());
        }

        /// <summary>
        /// Adds the hexadecimal string.
        /// </summary>
        /// <param name="_Packet">The packet.</param>
        /// <param name="_Value">The value.</param>
        public static void AddHexa(this List<byte> _Packet, string _Value)
        {
            _Packet.AddRange(_Value.HexaToBytes());
        }

        /// <summary>
        /// Turn a hexa string into a byte array.
        /// </summary>
        /// <param name="_Value">The value.</param>
        /// <returns></returns>
        public static byte[] HexaToBytes(this string _Value)
        {
            string _Tmp = _Value.Contains("-") ? _Value.Replace("-", string.Empty) : _Value.Replace(" ", string.Empty);
            return Enumerable.Range(0, _Tmp.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(_Tmp.Substring(x, 2), 16))
                .ToArray();
        }

        /// <summary>
        /// Adds the data.
        /// </summary>
        /// <param name="_Writer">The writer.</param>
        /// <param name="_Data">The data.</param>
        internal static void AddData(this List<byte> _Writer, Data _Data)
        {
            int Reference = _Data.Id;
            int RowIndex = _Data.GetID();

            _Writer.AddInt(Reference);
            _Writer.AddInt(RowIndex);
        }

        /// <summary>
        /// Shuffles the specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="List">The list.</param>
        internal static void Shuffle<T>(this IList<T> List)
        {
            int c = List.Count;

            while (c > 1)
            {
                c--;

                int r = Server_Resources.Random.Next(c + 1);

                T Value = List[r];
                List[r] = List[c];
                List[c] = Value;
            }
        }
    }
}