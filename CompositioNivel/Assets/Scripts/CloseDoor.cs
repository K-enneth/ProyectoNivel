using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject light;
    public HingeJoint joint;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && light.activeInHierarchy)
        {
            joint.useSpring = true;
        }
    }
}
