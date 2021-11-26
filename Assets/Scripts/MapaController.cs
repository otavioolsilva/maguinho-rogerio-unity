using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapaController : MonoBehaviour
{
    public Animator crossfade;

    public void GetScene_Caverna ()
    {
        StartCoroutine(LoadLevel("lv_caverna"));
        //SceneManager.LoadScene("lv_caverna", LoadSceneMode.Single);
    }

    public void GetScene_Deserto ()
    {
        StartCoroutine(LoadLevel("lv_deserto"));
        //SceneManager.LoadScene("lv_deserto", LoadSceneMode.Single);
    }

    public void GetScene_Floresta ()
    {
        StartCoroutine(LoadLevel("lv_floresta"));
        //SceneManager.LoadScene("lv_floresta", LoadSceneMode.Single);
    }

    public void GetScene_Cemiterio ()
    {
        StartCoroutine(LoadLevel("lv_cemiterio"));
        //SceneManager.LoadScene("lv_cemiterio", LoadSceneMode.Single);
    }

    IEnumerator LoadLevel (string levelName)
    {
        crossfade.SetTrigger("CallStart");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}
