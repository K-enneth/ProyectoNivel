using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndStop : MonoBehaviour
{
    public float RotDir;
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody rb;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "rot")
        {
            this.transform.rotation = new Quaternion(0, RotDir, 0, RotDir);
        }
        if(other.tag == "Stop")
        {
            Debug.Log("si se");
            anim.applyRootMotion = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
