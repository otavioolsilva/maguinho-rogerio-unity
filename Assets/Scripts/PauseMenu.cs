using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private static bool IsPaused = false;

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject confirmQuitUI;
    [SerializeField] private Animator anim;

    //Icon images
    [SerializeField] private Image iconPocao;
    public bool setIconPocao;
    [SerializeField] private Image iconGelo;
    public bool setIconGelo;
    [SerializeField] private Image iconAreia;
    public bool setIconAreia;
    [SerializeField] private Image iconCabelo;
    public bool setIconCabelo;
    [SerializeField] private Image iconSeiva;
    public bool setIconSeiva;

    void Start ()
    {
        pauseMenuUI.SetActive(false);
        confirmQuitUI.SetActive(false);
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

        //Icons
        iconPocao.enabled = setIconPocao;
        iconGelo.enabled = setIconGelo;
        iconAreia.enabled = setIconAreia;
        iconCabelo.enabled = setIconCabelo;
        iconSeiva.enabled = setIconSeiva;
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        confirmQuitUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
        anim.enabled = true;
    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        confirmQuitUI.SetActive(false);
        Time.timeScale = 0f;
        IsPaused = true;
        anim.enabled = false;
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
}
