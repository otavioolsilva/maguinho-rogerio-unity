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
            if (DataController.item_areia == true && DataController.item_cabelo == true && DataController.item_seiva == true)
            {
                StartCoroutine(LoadMap("lv_final"));
            }
            else
            {
                StartCoroutine(LoadMap("mapa"));
                Debug.Log("call map");
            }
        }
    }

    IEnumerator LoadMap (string levelName)
    {
        crossfade.SetTrigger("CallStart");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}
