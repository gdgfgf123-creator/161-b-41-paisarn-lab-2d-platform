using UnityEngine;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{
    [SerializeField] public Slider HP;
    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }
    protected Animator anim;
    protected Rigidbody2D rd;


    public void Intialize(int startHealth)
    {
        Health = startHealth;
        Debug.Log($"{this.name} is intialized Health : {this.Health}");
        rd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}Current Health: {Health}");

        IsDead();

    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Destroy(HP.gameObject);
            return true;
        }
        else { return false; }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
