using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollow : MonoBehaviour {

    public Transform followTarget;
    
	void LateUpdate ()
    {
        transform.LookAt(followTarget);
        //transform.rotation = Random.rotation;
    }
}
