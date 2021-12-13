using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreens : MonoBehaviour
{
    public Animator crossfade;

    [SerializeField] private Image img_win;
    [SerializeField] private Image img_win_keys;

    void Start ()
    {
        if (DataController.keys == 3)
        {
            img_win.enabled = false;
            img_win_keys.enabled = true;
        }
        else
        {
            img_win_keys.enabled = false;
            img_win.enabled = true;
        }
    }

    public void callFinalQuit ()
    {
        StartCoroutine(FinalQuit());
    }

    IEnumerator FinalQuit()
    {
        crossfade.SetTrigger("CallStart");

        yield return new WaitForSeconds(1f);

        Application.Quit();
        Debug.Log("quit");
    }
}
