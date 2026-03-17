using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<Proyectil>())
        {
            
        }
    }
}
