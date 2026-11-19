
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadHouse()
    {
        SceneManager.LoadScene("House");
    }

    public void LoadLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void LoadSolitaire()
    {
        SceneManager.LoadScene("Solitaire");
    }

    public void LoadBlockBlast()
    {
        SceneManager.LoadScene("BlockBlast");
    }
}

