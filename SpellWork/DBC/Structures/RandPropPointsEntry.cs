﻿using System.Runtime.InteropServices;
using DBCD.IO.Attributes;

namespace SpellWork.DBC.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public sealed class RandPropPointsEntry
    {
        [Index(true)]
        public uint ID;
        public float DamageReplaceStatF;
        public float DamageSecondaryF;
        public int DamageReplaceStat;
        public int DamageSecondary;
        [Cardinality(5)]
        public float[] EpicF;
        [Cardinality(5)]
        public float[] SuperiorF;
        [Cardinality(5)]
        public float[] GoodF;
        [Cardinality(5)]
        public uint[] Epic;
        [Cardinality(5)]
        public uint[] Superior;
        [Cardinality(5)]
        public uint[] Good;
    }
}
