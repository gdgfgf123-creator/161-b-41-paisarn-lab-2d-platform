using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] Vector2 velocity; 
    public Transform[] movePoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(20);
        DamgeHit = 20;

        velocity = new Vector2(-1.0f, 0.0f);
    }

    public override void Behavior()
    {
        rd.MovePosition(rd.position + velocity * Time.fixedDeltaTime);

    }
    private void FixedUpdate()
    {
        Behavior();
    }
    // Update is called once per frame
    void Update()
    {
           
    }
}
