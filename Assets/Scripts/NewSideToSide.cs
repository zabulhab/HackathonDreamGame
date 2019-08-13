using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSideToSide : MonoBehaviour
{
    // wherever this is placed in the world
    private Vector3 startPos;
    // distance away from starting point
    private Vector3 endPos;
    public int XYZDirChoice;
    public float speed;
    public float distance;
    private bool inReverse;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.gameObject.transform.position;
        if (XYZDirChoice == 1)
        {
            endPos.x = startPos.x + distance;

            endPos.y = startPos.y;
            endPos.z = startPos.z;

        }
        else if (XYZDirChoice == 2)
        {
            endPos.y = startPos.y + distance;
            endPos.x = startPos.x;
            endPos.z = startPos.z;

        }
        else
        {
            endPos.z = startPos.z + distance;
            endPos.y = startPos.y;
            endPos.x = startPos.x;

        }
        inReverse = false;
        Debug.Log(endPos);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        if (inReverse)
            transform.position = Vector3.MoveTowards(transform.position, endPos, step);
        else
            transform.position = Vector3.MoveTowards(transform.position, startPos, step);
        if (transform.position == endPos)
        {
            inReverse = true;
        }
        if (transform.position == startPos)
        {
            inReverse = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.parent = this.transform;
    }
}
