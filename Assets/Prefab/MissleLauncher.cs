using UnityEngine;

public class MissleLauncher : MonoBehaviour
{

    [SerializeField] GameObject RocketPF;
    [SerializeField] float RocketSpeed;
    [SerializeField] float TimerStart;
    [SerializeField] float TimerCount;

    // Update is called once per frame
    void Update()
    {

        if (TimerCount >= 0)
        {
            TimerCount -= Time.deltaTime;
        }
        else
        {
            ShootRocket();
            TimerCount = TimerStart;
        }








    }



    void ShootRocket()
    {

        if (RocketPF != null)
        {
            GameObject NewRocket = Instantiate(RocketPF, this.transform.position, this.transform.rotation);
            NewRocket.GetComponent<Rocket>().Speed = RocketSpeed;


        }

    }
}
