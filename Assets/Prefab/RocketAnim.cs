using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAnim : MonoBehaviour
{

    Rocket rocket;

    // Start is called before the first frame update
    private void Awake()
    {
        rocket = transform.GetComponentInParent<Rocket>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void DestroyRocketGO()
    {
        rocket.DestroyRocketGO();
    }







}
