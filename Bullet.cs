using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private PlayerMovement player;
    private int damage;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        damage = player.bulletDamage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag!= "Player"&& collision.gameObject.tag != "Coin")
        {
            if (collision.gameObject.GetComponent<Health>() != null)
            {
                collision.gameObject.GetComponent<Health>().TakeDamage(damage);
                Destroy(gameObject);

            }
            else
            {
                Destroy(gameObject);
            }
        }
        
    }
}
