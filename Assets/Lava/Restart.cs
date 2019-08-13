using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Restart : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ThirdPersonController")
        {
            SceneManager.LoadScene(1);
        }
    }
}
