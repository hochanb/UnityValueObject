using UnityEngine;
using System;

namespace ValueObjects
{
    [CreateAssetMenu(fileName = "New GUID", menuName = "Value Objects/GUID", order = 3)]
    public class GuidValue : ValueObject<Guid> 
    { 
        protected GuidValue() 
        { 
            _value = Guid.NewGuid();
            _readonly = true;
        }

        protected void Reset()
        {
            _value = Guid.NewGuid();
            _readonly = true;
        }
    }

}