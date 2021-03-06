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

using System;

namespace FFramework.Utilities
{
    public class Optional<T> where T : struct
    {
        private bool isPresent;
        private T value;

        public Optional(T value)
        {
            if (IsNullable(value) && value.Equals(default(T))) throw new ArgumentNullException("value");
            isPresent = true;
            this.value = value;
        }

        private bool IsNullable(T t) { return false; }
        private bool IsNullable(T? t) { return true; }

        public bool IsPresent
        {
            get
            {
                return isPresent;
            }
        }

        public T Value
        {
            get
            {
                return value;
            }
        }
    }
}
