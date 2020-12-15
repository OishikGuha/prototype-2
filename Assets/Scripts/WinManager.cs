using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{

    public GameObject Win;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Win.SetActive(true);
        Debug.Log(collision.name);
    }
}
