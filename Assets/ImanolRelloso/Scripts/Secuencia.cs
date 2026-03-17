using System.Collections;
using UnityEngine;

public class Secuencia : MonoBehaviour
{
    [SerializeField] private GameObject cube;

    [SerializeField] private Vector3 A;
    [SerializeField] private Vector3 B;

    [SerializeField] private Vector3 startRot = Vector3.zero;
    [SerializeField] public Vector3 endRot = new Vector3(0, 90, 0);

    public float moveDuration = 2f;  
    public float rotateDuration = 2f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject c = Instantiate(cube);
            StartCoroutine(MoveCube(c));
        }
    }

    IEnumerator MoveCube(GameObject go)
    {
        float timer = 0;

        while (timer < moveDuration)
        {
            timer += Time.deltaTime;
            float t = timer / moveDuration;

            go.transform.position = Vector3.Lerp(A, B, t);
            yield return null;
        }

        go.transform.position = B;

        yield return new WaitForSeconds(1);
        RotateCube(go);
    }

    IEnumerator RotateCube(GameObject go)
    {
        float timer = 0;

        while (timer < rotateDuration)
        {
            timer += Time.deltaTime;
            float t = timer / rotateDuration;

            go.transform.rotation = Quaternion.Slerp(Quaternion.Euler(startRot), Quaternion.Euler(endRot),t);

            yield return null;
        }
        yield return new WaitForSeconds(1);

        timer = 0;

        while (timer < rotateDuration)
        {
            timer += Time.deltaTime;
            float t = timer / rotateDuration;

            go.transform.rotation = Quaternion.Slerp(Quaternion.Euler(endRot), Quaternion.Euler(startRot), t);

            yield return null;
        }
    }
}