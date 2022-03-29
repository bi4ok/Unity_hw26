using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    [SerializeField] private GameObject _door;
    [SerializeField] private GameObject _loop;

    private void Start()
    {
        
    }
    public void DoorOpen()
    {
        _door.transform.RotateAround(_loop.transform.position, Vector3.forward, 90);
    }
}
