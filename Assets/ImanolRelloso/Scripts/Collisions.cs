using UnityEngine;

public class Collisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision" + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
