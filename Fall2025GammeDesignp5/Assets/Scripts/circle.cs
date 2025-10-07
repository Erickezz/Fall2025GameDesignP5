using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Circle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Make a Singleton
    public static Circle Instance;
    public InputActionReference move;
    public InputActionReference interact; 
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public Rigidbody2D rb;
    public float movespeed;
    private Vector2 _movedirection;
    

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x: _movedirection.x * movespeed, y:_movedirection.y);
    }
    void Update()
    {
        _movedirection = move.action.ReadValue<Vector2>();
        if (interact.action.WasPressedThisFrame())
        {
            Gamemanager.instance.score++;
        }
    }
}
