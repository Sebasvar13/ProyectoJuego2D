using UnityEngine;

public class CollectorItem : MonoBehaviour
{
    public enum ItemType { Apple, Pineapple }

    public ItemType type = ItemType.Apple;
    public int itemValue = 1;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        switch (type)
        {
            case ItemType.Apple:
                GameManager.Instance.TotalApple(itemValue);
                // Verificar que AudioManager exista antes de usarlo
                if (AudioManager.Instance != null)
                {
                    AudioManager.Instance.PlaySonidoManzana();
                }
                break;
            case ItemType.Pineapple:
                GameManager.Instance.TotalPineapple(itemValue);
                // Verificar que AudioManager exista antes de usarlo
                if (AudioManager.Instance != null)
                {
                    AudioManager.Instance.PlaySonidoPina();
                }
                break;
        }

        Destroy(gameObject);
    }
}