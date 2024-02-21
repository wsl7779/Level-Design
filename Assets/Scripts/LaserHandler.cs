using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHandler : MonoBehaviour
{
    GameObject beam;
    float time;
    [SerializeField] float maxTimeOn, maxTimeOff;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        beam = gameObject.transform.Find("Beam").gameObject;
        beam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= maxTimeOn + maxTimeOff)
        {
            time = 0;
            beam.SetActive(false);
        } else if (time >= maxTimeOff)
        {
            beam.SetActive(true);
        }
    }
}
