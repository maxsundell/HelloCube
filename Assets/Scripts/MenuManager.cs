using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{

    public string levelToLoad = "Level1";

    public void Play()
    {
        // Makes sure the button doesn't loop the selected state after pressed
        EventSystem.current.SetSelectedGameObject(null);

        SceneManager.LoadScene(levelToLoad);
    }

    public void Quit()
    {
        EventSystem.current.SetSelectedGameObject(null);

        Debug.Log("Quitting...");
        Application.Quit();
    }

    public void LevelSelect()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void Options()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

}
