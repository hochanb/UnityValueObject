using UnityEngine;

namespace ValueObjects
{
    [CreateAssetMenu(fileName = "New Long", menuName = "Value Objects/Long", order = 1)]
    public class LongValue : ValueObject<long> { }
}