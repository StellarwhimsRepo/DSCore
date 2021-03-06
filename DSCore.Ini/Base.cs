﻿using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;

namespace DSCore.Ini
{
    public sealed class Base
    {
        [BsonId]
        public string Nickname { get; set; }
        public uint Name { get; set; }
        public uint Infocard { get; set; }
        public string OwnerFaction { get; set; }
        public string System { get; set; }
        public string ArchetypeNickname { get; set; }
        public float[] Position { get; set; } // A tuple cannot be serialized
    }
}
