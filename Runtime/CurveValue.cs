using UnityEngine;

namespace ValueObjects
{
    [CreateAssetMenu(fileName = "New Curve", menuName = "Value Objects/Curve", order = 3)]
    public class CurveValue : ValueObject<AnimationCurve> { }
}