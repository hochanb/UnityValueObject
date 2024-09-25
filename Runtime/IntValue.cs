using UnityEngine;

namespace ValueObjects
{
    [CreateAssetMenu(fileName = "New Int", menuName = "Value Objects/Int", order = 1)]
    public class IntValue : ValueObject<int> { }
}