using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public static bool shoot = false;
    private Rigidbody2D fireballRigidbody;

    void Start ()
    {
        fireballRigidbody = GetComponent<Rigidbody2D>();
        
        if (CharacterController2D.m_FacingRight == false)
            transform.Rotate(0f, 180f, 0f);

        fireballRigidbody.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            End();
        }
    }

    void End ()
    {
        Destroy(gameObject);
    }
}
