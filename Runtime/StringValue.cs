using UnityEngine;


namespace ValueObjects
{
    [CreateAssetMenu(fileName ="New String",menuName ="Value Objects/String", order = 1)]
    public class StringValue : ValueObject<string> { }
}