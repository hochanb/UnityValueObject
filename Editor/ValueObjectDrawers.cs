using UnityEditor;
using UnityEngine;

namespace ValueObjects
{
    // String
    [CustomPropertyDrawer(typeof(StringValue))]
    public class StringValueDrawer : ValueObjectDrawer<string> { }

    // Int
    [CustomPropertyDrawer(typeof(IntValue))]
    public class IntValueDrawer : ValueObjectDrawer<int> { }

    // Bool
    [CustomPropertyDrawer(typeof(BoolValue))]
    public class BoolValueDrawer : ValueObjectDrawer<bool> { }

    // Float
    [CustomPropertyDrawer(typeof(FloatValue))]
    public class FloatValueDrawer : ValueObjectDrawer<float> { }

    // Long
    [CustomPropertyDrawer(typeof(LongValue))]
    public class LongValueDrawer : ValueObjectDrawer<long> { }

    // Vector2
    [CustomPropertyDrawer(typeof(Vector2Value))]
    public class Vector2ValueDrawer : ValueObjectDrawer<Vector2> { }

    // Vector3
    [CustomPropertyDrawer(typeof(Vector3Value))]
    public class Vector3ValueDrawer : ValueObjectDrawer<Vector3> { }

    // Vector4
    [CustomPropertyDrawer(typeof(Vector4Value))]
    public class Vector4ValueDrawer : ValueObjectDrawer<Vector4> { }

    // Curve
    [CustomPropertyDrawer(typeof(CurveValue))]
    public class CurveValueDrawer : ValueObjectDrawer<AnimationCurve> { }

    // Guid
    [CustomPropertyDrawer(typeof(GuidValue))]
    public class GuidValueDrawer : ValueObjectDrawer<System.Guid> { }

    //===== Add your own =====//









}
