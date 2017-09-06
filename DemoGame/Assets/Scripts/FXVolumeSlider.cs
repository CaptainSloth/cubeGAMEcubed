using UnityEngine;
using UnityEngine.UI;

public class FXVolumeSlider : MonoBehaviour {

    private bool mute;
    // private AudioSource source;
    public Slider FXVolume;
    public AudioSource FXAudio;
    public void FXVolumeControl(float FXvolumeControl)
    {
        AudioListener.volume = FXvolumeControl;

    }

    private void Start()
    {
        FXAudio = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("Volume"))
        {
            FXAudio.volume = PlayerPrefs.GetInt("Volume");
        }
    }

    public void Mute()
    {
        mute = !mute;
        if (mute)
        {
            FXAudio.volume = 0;
        }
        else
        {
            FXAudio.volume = 1;
        }

        PlayerPrefs.SetFloat("Volume", FXAudio.volume);
    }
    
    void Update () {

        FXAudio.volume = FXVolume.value;

	}
}
