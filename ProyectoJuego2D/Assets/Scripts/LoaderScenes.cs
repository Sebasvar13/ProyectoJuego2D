using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoaderScenesM(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    
    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene 2");
    }

    // Trigger bandera
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadScene2();
        }
    }
}