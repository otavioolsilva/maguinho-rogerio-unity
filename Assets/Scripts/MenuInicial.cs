using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    [SerializeField] private GameObject confirmQuitUI;
    public Animator crossfade;

    [SerializeField] private GameObject img_creditos;

    void Start ()
    {
        img_creditos.SetActive(false);
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
        img_creditos.SetActive(true);
    }

    public void UnloadCreditos ()
    {
        img_creditos.SetActive(false);
    }

    //Sair
    public void Quit ()
    {
        confirmQuitUI.SetActive(true);
    }

    public void confirmQuit ()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void cancelQuit()
    {
        confirmQuitUI.SetActive(false);
    }
}
