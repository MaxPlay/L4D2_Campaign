using System;
using System.Runtime.Serialization;

namespace Source.Build.Pipeline.Tools.Settings
{
    public struct MinMaxVector2 : IEquatable, IEquatable<MinMaxVector2>
    {
        [DataMember]
        public int MinX;
        [DataMember]
        public int MinY;
        [DataMember]
        public int MaxX;
        [DataMember]
        public int MaxY;

        public override bool Equals(object obj)
        {
            if (!(obj is MinMaxVector2))
                return false;

            return Equals((MinMaxVector2)obj);
        }

        public bool Equals(MinMaxVector2 other)
        {
            return MinX == other.MinX &&
                   MinY == other.MinY &&
                   MaxX == other.MaxX &&
                   MaxY == other.MaxY;
        }

        public override int GetHashCode()
        {
            var hashCode = -1882349014;
            hashCode = hashCode * -1521134295 + MinX.GetHashCode();
            hashCode = hashCode * -1521134295 + MinY.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxX.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxY.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{MinX} {MinY} {MaxX} {MaxY}";
        }

        public static bool operator ==(MinMaxVector2 vector1, MinMaxVector2 vector2)
        {
            return vector1.Equals(vector2);
        }

        public static bool operator !=(MinMaxVector2 vector1, MinMaxVector2 vector2)
        {
            return !(vector1 == vector2);
        }
    }
}