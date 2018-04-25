using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeBlink : MonoBehaviour {

    public int blinkMin, blinkMax;

	void LateUpdate ()
    {
        float blinkSpeed = Random.Range(blinkMin, blinkMax);

        transform.Rotate(Mathf.Sin(1), 0, 0 * Time.deltaTime);
    }
}
