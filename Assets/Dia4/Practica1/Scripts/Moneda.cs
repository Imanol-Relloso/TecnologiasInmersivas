using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField] private float rotSpeed;
    private void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jugador")
        {
            PickUp();
        }
    }

    void PickUp()
    {
        Destroy(gameObject);
    }
}
