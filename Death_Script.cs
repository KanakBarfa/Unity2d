using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Script : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject Player;
    public AppleCounter ac;
    public PlayerHealth ph;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ph.TakeDamage(40);
        }
    } 
}
