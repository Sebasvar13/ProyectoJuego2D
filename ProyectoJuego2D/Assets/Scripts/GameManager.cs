using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int scoreApple=0;
    private int scorePineapple = 0;



    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TotalApple(int apple)
    {
        scoreApple += apple;
    }

    public void TotalPineapple(int pineapple)
    {
        scorePineapple += pineapple;
    }
    public int ScoreApple { get => scoreApple; set => scoreApple = value; }
    public int ScorePineapple { get => scorePineapple; set => scorePineapple = value; }

}
