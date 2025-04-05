using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float speed;
    private PlayerAnimations playerAnimations;
    private PlayerActions actions;
    private Rigidbody2D rb2d;
    private Player player;
    private Vector2 moveDirection;

    private void Awake()
    {
        player = GetComponent<Player>();
        actions = new PlayerActions();
        rb2d = GetComponent<Rigidbody2D>();
        playerAnimations = GetComponent<PlayerAnimations>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReadMovement();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (player.Stats.Health <= 0) return;
        rb2d.MovePosition(rb2d.position + moveDirection * (speed * Time.fixedDeltaTime));
    }

    private void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        if (moveDirection == Vector2.zero)
        {
            playerAnimations.SetMoveBoolTransition(false); 
            return;
        }
        playerAnimations.SetMoveBoolTransition(true);
        playerAnimations.SetMoveBoolTransition(moveDirection);

    }

    private void OnEnable()
    {
        actions.Enable();
    }

    private void OnDisable()
    {
        actions.Disable();
    }
}
