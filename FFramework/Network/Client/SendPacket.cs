﻿/*
    C# Framework with a lot of useful functions and classes
    Copyright (C) 2017 Bruno Fištrek

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.IO;

namespace FFramework.Network.Client
{
    public class SendPacket : MemoryStream
    {
        public SendPacket() : base() { }

        protected void WriteS(string s)
        {
            WriteByte((byte)s.Length);
            for (int i = 0; i < s.Length; i++) WriteByte((byte)s[i]);
        }

        protected void WriteValue(object i)
        {
            WriteS(i.ToString());
        }
    }
}
