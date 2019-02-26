using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manter : MonoBehaviour {

    // Use this for initialization
     void Update()
    {   if (this.isActiveAndEnabled) 
        transform.parent = null; }
    
}
