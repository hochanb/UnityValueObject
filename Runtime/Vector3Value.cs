using UnityEngine;

namespace ValueObjects
{
    [CreateAssetMenu(fileName = "New Vector3", menuName = "Value Objects/Vector3", order = 2)]
    public class Vector3Value : ValueObject<Vector3> { }
}