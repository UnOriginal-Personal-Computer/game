using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtscript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c){
       if (c.tag == "Player"){
            c.transform.position = new Vector2(0f, 0f);
       }
    }
}
