using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Canvas gameOver;
   

    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.Find("Canvas").GetComponent<Canvas>();
       
        gameOver.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        gameOver.enabled = true;
    }

}
