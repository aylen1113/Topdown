using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    //public Vector3 offset; 

    void Start()
    {
    
        //if (player != null)
        //{
        //    offset = transform.position - player.position;
        //}
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        
    }
}
