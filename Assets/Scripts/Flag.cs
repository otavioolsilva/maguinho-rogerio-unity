using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    public Animator crossfade;

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player") {
            StartCoroutine(LoadMap());
            Debug.Log("call map");
        }
    }

    IEnumerator LoadMap ()
    {
        crossfade.SetTrigger("CallStart");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("mapa", LoadSceneMode.Single);
    }
}
