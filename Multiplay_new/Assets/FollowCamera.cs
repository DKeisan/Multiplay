using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonobitEngine;

public class FollowCamera : MonobitEngine.MonoBehaviour
{
    public GameObject marker;
    private GameObject camRigObj;

    void Awake()
    {
        if (monobitView.isMine)
        {
            camRigObj = GameObject.FindGameObjectWithTag("MainCamera");
        }
        else
        {
            marker.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (monobitView.isMine)
        {
            transform.position = camRigObj.transform.position;
            transform.rotation = camRigObj.transform.rotation;
        }
    }
}
