using UnityEngine;
using UnityEditor.SceneManagement;

public class PauseGame : MonoBehaviour {

    public Transform pauseCanvas;
    public Transform pauseMenu;
    public Transform soundSettings;
    // public Transform controlSettings;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}

    public void Pause()
    {
        if (pauseCanvas.gameObject.activeInHierarchy == false)
        {
            if (pauseMenu.gameObject.activeInHierarchy == false)
            {
                pauseMenu.gameObject.SetActive(true);
                soundSettings.gameObject.SetActive(false);
            }
            pauseCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pauseCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void SoundControl(bool soundControlChecked)
    {
        if (soundControlChecked)
        {
            soundSettings.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);

           }
        if (!soundControlChecked)
        {
            soundSettings.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }

    
    //        AudioListener.pause = true;

}
