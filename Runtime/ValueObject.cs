using System;
using UnityEngine;


namespace ValueObjects
{
    public abstract class ValueObject : ScriptableObject
    {
        public abstract object ValueAsObject { get; }
        public abstract Type ValueType { get; }
    }

    public abstract class ValueObject<T> :ValueObject
    {
        [SerializeField]
        protected T _value;         // serialized value

        [SerializeField, Tooltip("Readonly object's value can only be modified by editor")]
        protected bool _readonly;   // will be used as readonly or not


        public virtual T Value      // get set property on _value
        { 
            get => _value;
            set { if (!_readonly) _value = value; } // value protection
        }

        public bool isReadonly => _readonly;

        public override object ValueAsObject => _value as object;
        public override Type ValueType => typeof(T);
    }
}
