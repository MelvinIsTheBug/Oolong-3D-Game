using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitCamera : MonoBehaviour
{

    //Serialized reference to the object to orbit around
    [SerializeField] private Transform target;
    public float rotSpeed = 1.5f;

    private float _rotY;
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _rotY = transform.eulerAngles.y;

        //store the starting position offset between the camera and target
        _offset = target.position - transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");

        //either rotates cmaera slowly using arrow keys, or rotate quickly with the mouse
        if (horInput != 0)
        {
            _rotY += horInput * rotSpeed;
        } else
        {
            _rotY += Input.GetAxis("Mouse X") * rotSpeed * 3;
        }

        Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
        //Maintain the starting offset, shifted according to the camera's position
        transform.position = target.position - (rotation * _offset);
        //no matter where the camera is relative to the target, always face the target
        transform.LookAt(target);
        
    }
}
