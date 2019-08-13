using UnityEngine;

public class SpinInPlace : MonoBehaviour
{
    public float speed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime*3);
    }
}