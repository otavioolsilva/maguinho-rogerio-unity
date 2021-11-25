using UnityEngine;
using UnityEngine.SceneManagement;

public class MapaController : MonoBehaviour
{
    public void GetScene_Caverna ()
    {
        SceneManager.LoadScene("lv_caverna", LoadSceneMode.Single);
    }

    public void GetScene_Deserto()
    {
        SceneManager.LoadScene("lv_deserto", LoadSceneMode.Single);
    }

    public void GetScene_Floresta()
    {
        SceneManager.LoadScene("lv_floresta", LoadSceneMode.Single);
    }

    public void GetScene_Cemiterio()
    {
        SceneManager.LoadScene("lv_cemiterio", LoadSceneMode.Single);
    }
}
