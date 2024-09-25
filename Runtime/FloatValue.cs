using UnityEngine;

namespace ValueObjects
{
    [CreateAssetMenu(fileName = "New Float", menuName = "Value Objects/Float", order = 1)]
    public class FloatValue : ValueObject<float> { }
}