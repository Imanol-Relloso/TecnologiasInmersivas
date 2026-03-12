using UnityEngine;

public class Tanque : MonoBehaviour
{
    [SerializeField]
    private float velocidad;
    [SerializeField]
    private float velocidadRotacionArma;
    [SerializeField]
    private float velocidadRotacion;

    [SerializeField] private GameObject arma;
    [SerializeField] private GameObject spawnProyectil;
    [SerializeField] private GameObject proyectil;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Rotate(Vector3.down * velocidadRotacion * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            arma.transform.Rotate(Vector3.up * velocidadRotacionArma * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            arma.transform.Rotate(Vector3.down * velocidadRotacionArma * Time.deltaTime);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(proyectil, spawnProyectil.transform.position, spawnProyectil.transform.rotation);
        }
    }
}
