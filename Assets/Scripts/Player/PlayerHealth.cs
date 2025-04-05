using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    private PlayerAnimations playerAnimations;

    private void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(50f);
        }
    }
    public void TakeDamage(float amount)
    {
        stats.Health -= amount;
        if(stats.Health <= 0f)
        {
            PlayerDead();
        }
        
    }

    public void PlayerDead()
    {
        playerAnimations.SetDeadAnimation();
    }
}
