using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuable : MonoBehaviour
{
    private string _message = "press B";
    public bool isEnter = false;
    [SerializeField] Canvas presCanbas;
    private BoxCollider _bc;
    // Start is called before the first frame update
    void Start()
    {
        _bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnter && Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button17))
        {
            presCanbas.gameObject.SetActive(false);
            _bc.enabled = false;
            StartCoroutine(ChangeFalse());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isEnter = true;
        presCanbas.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        isEnter = false;
        presCanbas.gameObject.SetActive(false);
    }

    IEnumerator ChangeFalse()
    {
        yield return new WaitForSeconds(1f);
        isEnter = false;
    }
}
