using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowDeadScene : MonoBehaviour
{
    public Transform newObject;

    public void Follow()
    {
        transform.position = newObject.position;
        transform.parent = newObject;
    }

}
