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


    private float tiempoInicio;
    private void Start()
    {
        posicionInicial = col.transform.position;
        destino = new Vector3(col.transform.position.x, col.transform.position.y +1f, col.transform.position.z);
        rotacionInicialA = a.transform.rotation;
        rotacionInicialCol = col.transform.rotation;
        rotacionFinal = a.transform.rotation * Quaternion.Euler(180, 0, 0); // Rotar 180 grados alrededor del eje Y
        rotacionFinalcol = col.transform.rotation * Quaternion.Euler(-90, 0, 0); // Rotar 180 grados alrededor del eje Y
        tiempoInicio = Time.time;
    }

    private void Update()
    {
        if (canRot)
        {
            // Calcular la fracción de tiempo transcurrido
            float fraccionTiempo = (Time.time - tiempoInicio) * velocidadRotacion;

            // Interpolar entre las rotaciones inicial y final
            col.transform.position = Vector3.Lerp(posicionInicial, destino, fraccionTiempo);
            a.transform.rotation = Quaternion.Lerp(rotacionInicialA, rotacionFinal, fraccionTiempo);
            col.transform.rotation = Quaternion.Lerp(rotacionInicialCol, rotacionFinalcol, fraccionTiempo);

            // Detener la rotación cuando se alcanza la rotación final
            if (fraccionTiempo >= 1.0f)
            {
                enabled = false; // Desactivar este script
            }
        }
        else
        {
            tiempoInicio = Time.time;
        }
    }

}
