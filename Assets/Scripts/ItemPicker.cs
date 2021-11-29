using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    void Start ()
    {
        //gelo
        if (gameObject.name == "item_gelo")
        {
            if (DataController.item_gelo == true) Destroy(gameObject);
        }

        //areia
        else if (gameObject.name == "item_areia")
        {
            if (DataController.item_areia == true) Destroy(gameObject);
        }

        //cabelo
        else if (gameObject.name == "item_cabelo")
        {
            if (DataController.item_cabelo == true) Destroy(gameObject);
        }

        //seiva
        else if (gameObject.name == "item_seiva")
        {
            if (DataController.item_seiva == true) Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (gameObject.name == "item_gelo")
                DataController.item_gelo = true;

            else if (gameObject.name == "item_areia")
                DataController.item_areia = true;

            else if (gameObject.name == "item_cabelo")
                DataController.item_cabelo = true;
            
            else if (gameObject.name == "item_seiva")
                DataController.item_seiva = true;

            Destroy(gameObject);
        }
    }
}
