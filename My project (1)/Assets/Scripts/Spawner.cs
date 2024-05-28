using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private NpcScriptableObject stats;
    [SerializeField] private NPC npc;

    private void Start()
    {
        for (int x = 0; x < 100; x++)
        {
            for (int y = 0; y < 100; y++)
            {
                Spawn(new Vector2(x, y) + (Vector2)transform.position);
            }
        }
    }
    private void Spawn(Vector2 position)
    {
        NPC newNPC = Instantiate(npc);

        newNPC.Init(stats, position);
    }
}
