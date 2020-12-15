using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 20f;

    private Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        mousePos = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0)) 
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        }
        transform.position = Vector2.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
    }
}
