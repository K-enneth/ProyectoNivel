using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointDestructor : MonoBehaviour
{
    [SerializeField] private FixedJoint fj;
    public Interactuable inter;
    public AudioSource aso;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inter.isEnter && Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button17))
        {
            aso.Play();
            inter.light.SetActive(true);
            Destroy(fj.gameObject);
        }
    }
}
