using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowActivated : MonoBehaviour
{
    public CreateArrow create;
    public GameObject lightA;
    public GameObject lightB;
    public HingeJoint hj;
    public AudioSource aso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && lightA.activeInHierarchy && lightB.activeInHierarchy)
        {
            aso.Play();
            hj.useSpring = true;
            create.canRot = true;
        }
    }
}
