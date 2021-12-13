using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField] private float speed_inimigo = 4;
    [SerializeField] private float ronda_esq;
    [SerializeField] private float ronda_dir;

    void Update ()
    {
        Patrulha();
    }
    
    private void Patrulha ()
    {
        transform.Translate(Vector2.right * speed_inimigo * Time.deltaTime);

        if (gameObject.transform.position.x >= ronda_dir)
            transform.localRotation = Quaternion.Euler(0, 180, 0);

        if (gameObject.transform.position.x <= ronda_esq)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("morreu");
            DataController.life = false;
            Destroy(gameObject);
        }
    }
}
