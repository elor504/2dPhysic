using UnityEngine;

public class SoldierSpawner : MonoBehaviour
{
    [SerializeField] GameObject SoldierPF;

    [SerializeField] float TimerStart1;
    [SerializeField] float TimerStart2;
    [SerializeField] float TimerStart3;
    [SerializeField] float TimerCount;

    [SerializeField] float XMin;
    [SerializeField] float XMax;
    [SerializeField] float MoveSpeed;
    bool goingRight;
    int TimerRandomizer;
    void Update()
    {
        moveSpawner();
        SpawnSoldiers();
    }


    void moveSpawner()
    {
        if (transform.position.x < XMin)
        {
            goingRight = true;
        }
        if (transform.position.x > XMax)
        {
            goingRight = false;
        }
        if (goingRight)
        {
            transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0f, 0f);
        }
        else
        {
            transform.position -= new Vector3(MoveSpeed * Time.deltaTime, 0f, 0f);
        }




    }


    void SpawnSoldiers()
    {
        if (TimerCount <= 0)
        {
          
            TimerRandomizer = Random.Range(0, 4);
            if (TimerRandomizer == 0)
            {
                TimerCount = TimerStart1;
            }
            else if (TimerRandomizer == 2)
            {
                TimerCount = TimerStart1;
            }
            else if (TimerRandomizer == 2)
            {
                TimerCount = TimerStart3;
            }
            GameObject InstatiatedSoldier = Instantiate(SoldierPF, this.transform.position, transform.rotation);
        }
        else if (TimerCount > 0)
        {
            TimerCount -= Time.deltaTime;
        }
        
    }
}


    


