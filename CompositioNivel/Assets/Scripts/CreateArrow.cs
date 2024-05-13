using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArrow : MonoBehaviour
{
    public GameObject a;
    public GameObject col;
    public float velocidadRotacion = 1.0f;
    public bool canRot = false;
    private Quaternion rotacionInicialA;
    private Quaternion rotacionInicialCol;
    private Quaternion rotacionFinal;
    private Quaternion rotacionFinalcol;
    public Vector3 destino;
    private Vector3 posicionInicial;
    public AudioSource ad;
    public bool cansound = true;


    private float tiempoInicio;
    private void Start()
    {
        posicionInicial = col.transform.position;
        destino = new Vector3(col.transform.position.x, col.transform.position.y +0.65f, col.transform.position.z);
        rotacionInicialA = a.transform.rotation;
        rotacionInicialCol = col.transform.rotation;
        rotacionFinal = a.transform.rotation * Quaternion.Euler(180, 0, 0); 
        rotacionFinalcol = col.transform.rotation * Quaternion.Euler(-90, 0, 0); 
        tiempoInicio = Time.time;
    }

    private void Update()
    {
        if (canRot)
        {
            if(cansound)
            {
                ad.Play();
                cansound = false;
            }
            // Calcular la fracci�n de tiempo transcurrido
            float fraccionTiempo = (Time.time - tiempoInicio) * velocidadRotacion;
            // Interpolar entre las rotaciones inicial y final
            col.transform.position = Vector3.Lerp(posicionInicial, destino, fraccionTiempo);
            a.transform.rotation = Quaternion.Lerp(rotacionInicialA, rotacionFinal, fraccionTiempo);
            col.transform.rotation = Quaternion.Lerp(rotacionInicialCol, rotacionFinalcol, fraccionTiempo);

            // Detener la rotaci�n cuando se alcanza la rotaci�n final
            if (fraccionTiempo >= 1.0f)
            {
                ad.Stop();
                enabled = false; // Desactivar este script
            }
        }
        else
        {
            tiempoInicio = Time.time;
        }
    }

}
