using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Permanente")]
    public AudioClip musicaFondo;
    private AudioSource audioSourceMusica;

    [Header("Audios de Colisiones")]
    public AudioClip sonidoManzana;
    public AudioClip sonidoPina;

    public static AudioManager Instance;

    void Awake()
    {
        // Singleton - solo una instancia del AudioManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Configurar música de fondo
        if (musicaFondo != null)
        {
            audioSourceMusica = gameObject.AddComponent<AudioSource>();
            audioSourceMusica.clip = musicaFondo;
            audioSourceMusica.loop = true;
            audioSourceMusica.volume = 0.5f;
            audioSourceMusica.Play();
        }
    }

    // Reproducir sonido de manzana
    public void PlaySonidoManzana()
    {
        if (sonidoManzana != null)
        {
            AudioSource.PlayClipAtPoint(sonidoManzana, Camera.main.transform.position);
        }
    }

    // Reproducir sonido de piña
    public void PlaySonidoPina()
    {
        if (sonidoPina != null)
        {
            AudioSource.PlayClipAtPoint(sonidoPina, Camera.main.transform.position);
        }
    }
}