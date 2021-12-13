using UnityEngine;
using UnityEngine.UI;

public class InimigoOrc : MonoBehaviour
{
    [SerializeField] private float speed_orc = 2;
    [SerializeField] private GameObject flagEsq;
    [SerializeField] private GameObject flagDir;

    [SerializeField] private Animator anim_orc;

    [SerializeField] private Canvas healthbar_canvas;
    [SerializeField] private Image healthbar;

    void Start ()
    {
        healthbar_canvas.enabled = true;
    }

    void Update ()
    {
        //Move
        transform.Translate(Vector2.right * speed_orc * Time.deltaTime);

        //Check vida_orc
        Debug.Log("Vida orc: " + DataController.life_orc);
        if (DataController.life_orc <= 0)
        {
            Destroy(gameObject);
            healthbar_canvas.enabled = false;
        }

        UpdateHealthBarOrc();
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("morreu");
            DataController.life = false;
            speed_orc = 0;
            anim_orc.enabled = false;
        }
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if (coll.gameObject == flagEsq)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            Debug.Log("esq");
        }

        if (coll.gameObject == flagDir)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            Debug.Log("dir");
        }
    }

    private void UpdateHealthBarOrc ()
    {
        healthbar.fillAmount = (float)DataController.life_orc / (float)25.0;
    }
}
