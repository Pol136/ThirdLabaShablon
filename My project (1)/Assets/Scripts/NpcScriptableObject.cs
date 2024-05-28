using UnityEngine;

[CreateAssetMenu(fileName = "NpcStats", menuName = "ScriptableObject/NpcStats")]
public class NpcScriptableObject : ScriptableObject
{
    [field: SerializeField] public int health {  get; private set; }
    [field: SerializeField] public float Speed { get; private set; }
    [field: SerializeField] public int Damage { get; private set; }
}
