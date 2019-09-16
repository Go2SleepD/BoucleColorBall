using UnityEngine;

public class Star : MonoBehaviour
{
    public float speed = 12f;
    public Transform lPos, rPos;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.position.x > rPos.position.x)     // obj x = rpos -> go to lpos
        {
            speed = -speed;        //speed of moving change vector of this moving
        }
        else if (transform.position.x < lPos.position.x)        //obj x = lpos -> go to rpos
        {
            speed = +speed;
        }
    }
    private void OnDrawGizmos()     //graw line from lpos to rpos.
    {
        Gizmos.DrawLine(lPos.position, rPos.position);
    }
}
