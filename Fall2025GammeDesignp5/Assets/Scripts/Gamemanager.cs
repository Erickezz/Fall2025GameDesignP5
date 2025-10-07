using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    public int score = 0;
    public TextMeshProUGUI Text;

    //Make an Array 
    private string newgamename = "Metroid";
    public string[] gamelist = new string[10] { "Fortnite", "Street_Fighter", "Silksong", "Yazuka", "BluePrints", "Ghost of Totei", "God of War", "Mario", "Sonic", ";)" }; 
    


    public static Gamemanager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamelist[0] = newgamename;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = gamelist[score];
    }
}

