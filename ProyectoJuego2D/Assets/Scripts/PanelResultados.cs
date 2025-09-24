using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PanelResultados : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject panelResultados;
    public TextMeshProUGUI textManzanas;
    public TextMeshProUGUI textPinas;
    public TextMeshProUGUI textTotal;
    public Button botonSalir;

    public static PanelResultados Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Asegurarse de que el panel esté oculto al inicio
        if (panelResultados != null)
        {
            panelResultados.SetActive(false);
        }

        // Configurar el botón de salir
        if (botonSalir != null)
        {
            botonSalir.onClick.AddListener(SalirDelJuego);
        }
    }

    public void MostrarResultados()
    {
        // Pausar el juego
        Time.timeScale = 0f;

        // Obtener las puntuaciones del GameManager
        int manzanas = GameManager.Instance.ScoreApple;
        int pinas = GameManager.Instance.ScorePineapple;
        int total = manzanas + pinas;

        // Actualizar los textos
        if (textManzanas != null)
            textManzanas.text = "Son: " + manzanas;

        if (textPinas != null)
            textPinas.text = "Son: " + pinas;

        if (textTotal != null)
            textTotal.text = "Puntaje: " + total;

        // Mostrar el panel
        if (panelResultados != null)
        {
            panelResultados.SetActive(true);
        }
    }

    public void SalirDelJuego()
    {
        // Reanudar el tiempo antes de salir
        Time.timeScale = 1f;

        // Salir del juego
        Application.Quit();

        // En el editor, detener el play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}