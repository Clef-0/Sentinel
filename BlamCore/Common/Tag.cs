﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blam.Common
{
    /// <summary>
    /// Represents a magic number which looks like a string.
    /// </summary>
    public struct Tag : IComparable<Tag>
    {
        public static readonly Tag Null = new Tag("ÿÿÿÿ");
        /// <summary>
        /// Constructs a magic number from an integer.
        /// </summary>
        /// <param name="val">The integer.</param>
        public Tag(uint val)
        {
            Value = val;
        }

        /// <summary>
        /// Constructs a magic number from a string.
        /// </summary>
        /// <param name="str">The string.</param>
        public Tag(string str)
        {
            var bytes = Encoding.ASCII.GetBytes(str);
            Value = 0;
            foreach (var b in bytes)
            {
                Value <<= 8;
                Value |= b;
            }
        }

        /// <summary>
        /// Gets the value of the magic number as an integer.
        /// </summary>
        public readonly uint Value;

        /// <summary>
        /// Converts the magic number into its string representation.
        /// </summary>
        /// <returns>The string that the magic number looks like.</returns>
        public override string ToString()
        {
            var i = 4;
            var chars = new char[4];
            var val = Value;
            while (val > 0)
            {
                i--;
                chars[i] = (char)(val & 0xFF);
                val >>= 8;
            }
            return (i < 4) ? new string(chars, i, chars.Length - i) : "";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Tag))
                return false;
            var other = (Tag)obj;
            return (Value == other.Value);
        }

        public static bool operator ==(Tag a, Tag b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Tag a, Tag b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public int CompareTo(Tag other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}