using UnityEngine;

public class playerCollision : MonoBehaviour {

    public PlayerMovement movement;

    public AudioSource hitSource;

    void Start()
    {
        hitSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter (Collision collisionInfo)
    {
        //  Debug.Log(collisionInfo.collider.tag);
        //  Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {

            hitSource.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
            

    }


}
