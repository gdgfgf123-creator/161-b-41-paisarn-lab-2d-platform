using UnityEngine;

public class player : Character
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(100);
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamgeHit);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null){
            OnHitWith(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
