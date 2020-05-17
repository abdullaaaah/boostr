using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followPlayer();
    }

    void followPlayer()
    {
        mainCamera.transform.position = new Vector3(0f, 3f + transform.position.y, -10f);
    }
}
