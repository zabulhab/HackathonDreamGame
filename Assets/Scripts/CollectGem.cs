using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectGem : MonoBehaviour
{

    //[HideInInspector]
    //public Text GemCountText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gem")
        {
            Destroy(collision.gameObject);
            // TODO: Increase count on UI Text
            //GemCountText = ""
        }
    }
}
