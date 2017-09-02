using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    public AudioSource endSource;

    void Start()
    {
        endSource = GetComponent<AudioSource>();
    }


    void OnTriggerEnter()
    {
        endSource.Play();
        gameManager.CompleteLevel();
    }

}
