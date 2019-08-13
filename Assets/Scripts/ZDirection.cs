using UnityEngine;

public class ZDirection : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float frequency = 1f;

    ///how far the object should move
    //public float distance;
    // how long the object should stop
    //public float stopTime;
    // How many cycles this object should complete for a given cycle length

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start()
    {   
        posOffset = transform.position;
    }

    private void FixedUpdate()
    {

    }

    void Update()
    {

        tempPos = posOffset;
        tempPos.z += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude*3;

        transform.position = tempPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.parent = this.transform;
    }
}