using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turt_move : MonoBehaviour
{
    public Vector2 velocity;
    public float leftBound;
    public float rightBound;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= rightBound)
        {
            if (velocity.x > 0)
            {   
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            else transform.eulerAngles = new Vector3(0, 0, 0);
            
        }
        else if (transform.position.x <= leftBound)
        {
            if (velocity.x < 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            else
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        transform.Translate(velocity * 2 * Time.deltaTime); 
    }
}
