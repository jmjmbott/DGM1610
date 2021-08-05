using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAppear : MonoBehaviour
{
   public GameObject myCube;

   
   public void ActivateCube()
    {
        myCube.SetActive(true);
    }

    public void ActivateSphere()
    {
        Debug.Log("Make Sphere Appear");
    }
}
