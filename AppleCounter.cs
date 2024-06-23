using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public int apples;
    public Text appleText;
    void Start()
    {
        apples = 0;
    }

    // Update is called once per frame
    void Update()
    {
        appleText.text = " : " + apples.ToString();
    }
}
