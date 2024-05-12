using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject light;
    public HingeJoint joint;
    public AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && light.activeInHierarchy)
        {
            audio.Play();
            joint.useSpring = true;
            StartCoroutine(DeactivateAudio());
        }
    }

    IEnumerator DeactivateAudio()
    {
        yield return new WaitForSeconds(1f);
        audio.enabled = false;
    }
}
