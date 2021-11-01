using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    [SerializeField] Transform Player;
    [SerializeField] Vector3 offSet;
    void LateUpdate()
    {
        transform.position = Player.position + offSet;
    }
}
