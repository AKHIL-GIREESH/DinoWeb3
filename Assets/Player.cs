using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public Vector3 GetPositionPlayer;



    public void Update()

    {

        GetPositionPlayer = gameObject.transform.position;  

    }

}



