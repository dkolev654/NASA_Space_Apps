using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    public GameObject entityPrefab; // Prefab of the entity to spawn
    public int numberOfEntities = 10; // Number of entities to generate
    public float spawnRadius = 50f; // Radius around the center where entities will be spawned

    void Start()
    {
        SpawnEntities();
    }

    void SpawnEntities()
    {
        for (int i = 0; i < numberOfEntities; i++)
        {
            // Random position within the radius
            Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
            randomPosition.y = 0; // Keep entities on the ground (adjust based on your game)

            // Instantiate entity at the random position
            Instantiate(entityPrefab, randomPosition, Quaternion.identity);
        }
    }
}
