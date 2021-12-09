using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
            DataController.keys++;

        if (gameObject.name == "key_cemiterio")
            DataController.key_cemiterio = true;

        else if (gameObject.name == "key_deserto")
            DataController.key_deserto = true;

        else if (gameObject.name == "key_floresta")
            DataController.key_floresta = true;

        Destroy(gameObject);
    }
}
