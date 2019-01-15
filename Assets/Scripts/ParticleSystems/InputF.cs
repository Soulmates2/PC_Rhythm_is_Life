using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputF : MonoBehaviour
{
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("Particle System (3)").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ps.Emit(10);
        }
    }
}
