using UnityEngine;

public class FruitSpawnerScene2 : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject pineapplePrefab;

    void Start()
    {
        CreateFruits();
    }

    public void CreateFruits()
    {
        // Lista de posiciones específicas donde pueden aparecer las frutas
        Vector3[] spawnPoints = {
            new Vector3(-4.5f, -0.5f, 0f),
            new Vector3(-4f, 0f, 0f),
            new Vector3(-3.5f, -0.8f, 0f),
            new Vector3(-3f, -0.2f, 0f),
            new Vector3(-2.5f, -1f, 0f),
            new Vector3(-2f, 0.1f, 0f),
            new Vector3(-1.5f, -0.6f, 0f),
            new Vector3(-1f, -0.3f, 0f),
            new Vector3(-0.8f, -0.9f, 0f),
            new Vector3(-0.6f, 0f, 0f)
        };

        // Crear una lista de índices disponibles
        System.Collections.Generic.List<int> availableIndices = new System.Collections.Generic.List<int>();
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            availableIndices.Add(i);
        }

        // Generar manzanas (0 a 5)
        int totalApples = Random.Range(0, 6);
        for (int i = 0; i < totalApples && availableIndices.Count > 0; i++)
        {
            int randomIndex = Random.Range(0, availableIndices.Count);
            int spawnIndex = availableIndices[randomIndex];
            availableIndices.RemoveAt(randomIndex);

            GameObject apple = Instantiate(applePrefab) as GameObject;
            apple.transform.position = spawnPoints[spawnIndex];
        }

        // Generar piñas (0 a 7)
        int totalPineapples = Random.Range(0, 8);
        for (int i = 0; i < totalPineapples && availableIndices.Count > 0; i++)
        {
            int randomIndex = Random.Range(0, availableIndices.Count);
            int spawnIndex = availableIndices[randomIndex];
            availableIndices.RemoveAt(randomIndex);

            GameObject pineapple = Instantiate(pineapplePrefab) as GameObject;
            pineapple.transform.position = spawnPoints[spawnIndex];
        }
    }
}