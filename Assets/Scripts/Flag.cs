using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player") {
            SceneManager.LoadScene("mapa", LoadSceneMode.Single);
        }
    }
}
