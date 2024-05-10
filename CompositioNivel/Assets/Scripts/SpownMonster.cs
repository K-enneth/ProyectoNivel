using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownMonster : MonoBehaviour
{
    public Transform spownPos;
    public GameObject monster;
    public Interactuable inter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.isEnter && Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button17))
        {
            Instantiate(monster, spownPos);
        }
    }
}
