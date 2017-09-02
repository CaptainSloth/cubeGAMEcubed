using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public AudioSource buttonSource;

    public float startDelay = 2f;

    void GoButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        buttonSource = GetComponent<AudioSource>();
    }

    public void StartButton ()
    {
        Invoke("Start", startDelay);
        Debug.Log("startDelay");
    }

    void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("StartGame");
        Invoke("GoButton", startDelay);
    }
}
