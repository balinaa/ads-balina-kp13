using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Entry
    {
        public Entry(Key key, Value value)
        {
            Key = key;
            Value = value;
        }
        public Entry()
        {

        }

        public Key Key{ get; set; }
        public Value Value { get; set; }
    }
}
