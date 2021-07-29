using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    public Stat damage;
    public Stat armor;

    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        currentHealth -= damage;
        Debug.Log(transform.name + "take" + damage + "damage.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Debug.Log(transform.name + "parents die");

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }
}
