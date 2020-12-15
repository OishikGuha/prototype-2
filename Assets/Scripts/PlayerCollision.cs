using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public GameObject influenceSphere;

    public GameObject dieEffect;

    private Vector2 deathPos;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Die();
        }
    }

    void Die() 
    {
        GameObject clone = Instantiate(dieEffect, transform.position, Quaternion.identity);
        Destroy(clone, 1f);
        Destroy(gameObject);
    }

}
