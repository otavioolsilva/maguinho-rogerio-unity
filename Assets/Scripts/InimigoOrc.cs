using UnityEngine;
using UnityEngine.UI;

public class InimigoOrc : MonoBehaviour
{
    [SerializeField] private float speed_orc = 2;
    [SerializeField] private float rondaDistancia;
    private float ronda = 0;

    [SerializeField] private Animator anim_orc;

    [SerializeField] private Canvas healthbar_canvas;
    [SerializeField] private Image healthbar;

    void Start ()
    {
        healthbar_canvas.enabled = true;
    }

    void Update ()
    {
        Patrulha();

        //Check vida_orc
        Debug.Log("Vida orc: " + DataController.life_orc);
        if (DataController.life_orc <= 0)
        {
            Destroy(gameObject);
            healthbar_canvas.enabled = false;
        }

        UpdateHealthBarOrc();
    }

    private void Patrulha ()
    {
        ronda++;

        transform.Translate(Vector2.right * speed_orc * Time.deltaTime);

        if (ronda >= 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        else
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        if (ronda > rondaDistancia / 2)
            ronda = ronda * -1;

        //Debug.Log("ronda = " + ronda);
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

    private void UpdateHealthBarOrc ()
    {
        healthbar.fillAmount = (float)DataController.life_orc / (float)25.0;
    }
}
