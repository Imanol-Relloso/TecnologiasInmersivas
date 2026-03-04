using UnityEngine;

public class Interpolaciones : MonoBehaviour
{
    public GameObject cube;

    public Vector3 intPos = Vector3.zero;   
    public Vector3 endPos = new Vector3(10,0,0);

    public float moveDirection = 5.0f;
    public float moveTimer = 0;

    public Light miLuz;
    public Color startColor = Color.red;
    public Color endColor = Color.blue;

    public Vector3 intRot = Vector3.zero;
    public Vector3 endRot = new Vector3(0,100,0);
    private void Update()
    {
        moveTimer += Time.deltaTime;
        float t = moveTimer / moveDirection;
        cube.transform.position = Vector3.Lerp(intPos, endPos, t);

        miLuz.color = Color.Lerp(startColor, endColor, t);

        cube.transform.rotation = Quaternion.Lerp(Quaternion.Euler(intRot),Quaternion.Euler(endPos), t);
    }
}
