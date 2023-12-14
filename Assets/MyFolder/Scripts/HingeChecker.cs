using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeChecker : MonoBehaviour
{
    public BoxCollider secondObj;
    public HingeJoint engsel;
    public List<BoxCollider> colliderPengunci;


    void Update()
    {
        // Debug.Log(engsel.angle);

        if (engsel.angle < -60)
        {
            Debug.Log("terbuka");

            secondObj.enabled = true;

            foreach (var item in colliderPengunci)
            {
                item.enabled = false;
            }
        }
        else
        {
            Debug.Log("tertutup");

            secondObj.enabled = false;

            foreach (var item in colliderPengunci)
            {
                item.enabled = true;
            }
        }
    }
}
