using UnityEngine;

public class Hole : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //Quicksand
        if (col.gameObject.tag == "Player")
            DataController.life = false;

        else
            Destroy(col.gameObject);
    }
}
