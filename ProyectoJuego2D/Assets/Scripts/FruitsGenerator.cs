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
        // Generar manzanas
        int totalApples = Random.Range(0, 6);
        for (int i = 0; i < totalApples; i++)
        {
            float randomX = Random.Range(-4.899f, -0.563f);
            float randomY = Random.Range(-1.14f, 0.174f);
            GameObject apple = Instantiate(applePrefab) as GameObject;
            apple.transform.position = new Vector3(randomX, randomY, 0f);
        }

        // Generar piñas
        int totalPineapples = Random.Range(0, 8);
        for (int i = 0; i < totalPineapples; i++)
        {
            float randomX = Random.Range(-4.899f, -0.563f);
            float randomY = Random.Range(-1.14f, 0.174f);
            GameObject pineapple = Instantiate(pineapplePrefab) as GameObject;
            pineapple.transform.position = new Vector3(randomX, randomY, 0f);
        }
    }
}