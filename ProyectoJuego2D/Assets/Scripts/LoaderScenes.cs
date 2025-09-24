using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void LoaderScenesM(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    // Método específico para la bandera
    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene 2");
    }

    // Trigger para objetos específicos como la bandera
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Mostrar panel de resultados en lugar de cambiar de escena
            if (PanelResultados.Instance != null)
            {
                PanelResultados.Instance.MostrarResultados();
            }
            else
            {
                // Si no hay panel, cargar la siguiente escena como antes
                LoadScene2();
            }
        }
    }
}