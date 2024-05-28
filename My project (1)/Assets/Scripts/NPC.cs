using UnityEngine;

public class NPC : MonoBehaviour
{
    private NpcScriptableObject npcStats;

    public Vector2 position;

    public void Init(NpcScriptableObject _stats, Vector2 _position)
    {
        npcStats = _stats;
        position = _position;
        transform.position = _position;
    }
}
