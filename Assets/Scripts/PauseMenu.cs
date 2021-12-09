using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject confirmQuitUI;
    [SerializeField] private GameObject controlesUI;
    [SerializeField] private Animator anim;

    //Icon images
    [SerializeField] private Image iconPocao;
    [SerializeField] private Image iconGelo;
    [SerializeField] private Image iconAreia;
    [SerializeField] private Image iconCabelo;
    [SerializeField] private Image iconSeiva;

    void Start ()
    {
        pauseMenuUI.SetActive(false);
        confirmQuitUI.SetActive(false);
        controlesUI.SetActive(false);
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        ItemIcons();
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        confirmQuitUI.SetActive(false);
        controlesUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
        anim.enabled = true;
    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        confirmQuitUI.SetActive(false);
        controlesUI.SetActive(false);
        Time.timeScale = 0f;
        IsPaused = true;
        anim.enabled = false;
    }

    public void ControlesOpen ()
    {
        controlesUI.SetActive(true);
    }

    public void ControlesClose()
    {
        controlesUI.SetActive(false);
    }

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

    //Icons
    private void ItemIcons ()
    {
        if (DataController.item_pocao == true) iconPocao.enabled = true;
        else iconPocao.enabled = false;

        if (DataController.item_gelo == true) iconGelo.enabled = true;
        else iconGelo.enabled = false;

        if (DataController.item_areia == true) iconAreia.enabled = true;
        else iconAreia.enabled = false;

        if (DataController.item_cabelo == true) iconCabelo.enabled = true;
        else iconCabelo.enabled = false;

        if (DataController.item_seiva == true) iconSeiva.enabled = true;
        else iconSeiva.enabled = false;
    }
}
