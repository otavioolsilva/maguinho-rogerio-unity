using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    [SerializeField] private GameObject confirmQuitUI;
    public Animator crossfade;

    void Start ()
    {
        confirmQuitUI.SetActive(false);
    }

    //Iniciar
    public void Iniciar ()
    {
        StartCoroutine(LoadStart());
    }

    IEnumerator LoadStart ()
    {
        crossfade.SetTrigger("CallStart");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("lv_caverna", LoadSceneMode.Single);
    }

    //Créditos
    public void LoadCreditos ()
    {
        Debug.Log("load credits");
    }

    //Sair
    public void Quit()
    {
        confirmQuitUI.SetActive(true);
    }

    public void confirmQuit()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void cancelQuit()
    {
        confirmQuitUI.SetActive(false);
    }
}
