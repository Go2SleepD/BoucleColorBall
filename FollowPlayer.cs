using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if(player.position.y >= transform.position.y)       //check camera y axis = player y axis
        {
            transform.position = new Vector3(0f, player.position.y, -10f);      //move camera to player
        }
    }
}
