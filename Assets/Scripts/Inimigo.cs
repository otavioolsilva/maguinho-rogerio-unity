using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField] private float speed_inimigo = 4;
    [SerializeField] private float rondaDistancia;
    private float ronda = 0;

    void Update ()
    {
        Patrulha();
    }
    
    private void Patrulha ()
    {
        ronda++;

        transform.Translate(Vector2.right * speed_inimigo * Time.deltaTime);

        if (ronda >= 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        else
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        if (ronda > rondaDistancia/2)
            ronda = ronda * -1;

        //Debug.Log("ronda = " + ronda);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("morreu");
            Destroy(gameObject);
        }
    }
}
