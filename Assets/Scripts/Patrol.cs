using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    private float waitTime;
    public float startWaitTime;
    

    public Transform[] moveSpots;
    private int spot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[spot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[spot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                spot++;
                waitTime = startWaitTime;

                if (spot >= moveSpots.Length)
                {
                    spot = 0;
                }

            }
            else
            { 
                    waitTime -= Time.deltaTime;
            }
        }
    }
}       
