using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_line : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject WinMenu;
    public AppleCounter ac;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ac.apples == 7)
        {
            anim.SetBool("Open", true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && ac.apples == 7)
        {
            WinMenu.SetActive(true);
        }
    }
}
