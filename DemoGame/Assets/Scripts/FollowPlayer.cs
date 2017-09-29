using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public float xRot;

	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
        Camera.main.transform.rotation = Quaternion.Euler(xRot , 0, 0);
    }
}
