using UnityEngine;

namespace ValueObjects
{
    [CreateAssetMenu(fileName = "New Bool", menuName = "Value Objects/Bool", order = 1)]
    public class BoolValue : ValueObject<bool> { }
}