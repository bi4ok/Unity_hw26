using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public void GoDestroyObject()
    {
        Destroy(this.gameObject);
    }

    public void ChangeObject(int scale)
    {
        gameObject.transform.localScale = gameObject.transform.localScale * scale;
    }

    public void MoveObjectUp(int forceScale)
    {
        Rigidbody objectBody = GetComponent<Rigidbody>();
        objectBody.AddForce(Vector3.up * forceScale);
    }
}
