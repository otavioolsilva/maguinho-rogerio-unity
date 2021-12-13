using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapaController : MonoBehaviour
{
    public Animator crossfade;

    public void GetScene_Caverna ()
    {
        if (DataController.item_areia == true && DataController.item_cabelo == true && DataController.item_seiva == true)
            StartCoroutine(LoadLevel("lv_final"));
        else
            StartCoroutine(LoadLevel("lv_caverna"));
    }

    public void GetScene_Deserto ()
    {
        StartCoroutine(LoadLevel("lv_deserto"));
    }

    public void GetScene_Floresta ()
    {
        StartCoroutine(LoadLevel("lv_floresta"));
    }

    public void GetScene_Cemiterio ()
    {
        StartCoroutine(LoadLevel("lv_cemiterio"));
    }

    IEnumerator LoadLevel (string levelName)
    {
        crossfade.SetTrigger("CallStart");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}
