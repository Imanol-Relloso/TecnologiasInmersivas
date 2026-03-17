using System;
using System.Collections;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private void Start()
    {
        transform.Rotate(90, 0, 0, Space.Self);
        transform.GetComponent<Rigidbody>().AddForce(transform.up * 200);
        StartCoroutine(TiempoEnPantalla());
    }

    private IEnumerator TiempoEnPantalla()
    {
        float tiempo = 0;
        float tiempoEnPantalla = 3f;
        while (tiempo < tiempoEnPantalla)
        {
            tiempo += Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);
    }
}
