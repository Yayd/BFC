using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model
{
    class ValueController
    {
        public enum ValueType
        {
            INT = 1,
            STRING = 2

        }

        private string _name;
        private string _value;
        private ValueType _type;

        public ValueController(string name, string value, ValueType type)
        {
            this._name = name;
            this._value = value;
            this._type = type;
        }

        public ValueController(string name, int value, ValueType type)
        {
            this._name = name;
            this._value = Convert.ToString(value);
            this._type = type;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int IntValue
        {
            get
            {
                if (_type == ValueType.STRING)
                {
                    throw new ExceptionWrongValueType();
                }
                return Convert.ToInt32(_value);
            }

            set
            {
                _value = Convert.ToString(value);
            }
        }

        public string StrValue
        {
            get
            {
                return _value;                
            }
            set
            {
                _value = value;
            }
        }

        public ValueType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void save()
        {

        }

    }
}
