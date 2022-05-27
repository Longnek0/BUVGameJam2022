using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    private Camera mainCamera;

    [SerializeField]
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FollowMousePos()
    {
        transform.position = GetWorldPosFromMouse();
    }

    Vector2 GetWorldPosFromMouse()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
