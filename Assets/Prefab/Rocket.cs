using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float Speed;
    Rigidbody2D rb;
    public Rigidbody2D Getrb => rb;
    [SerializeField] Animator Anim;
    bool IsExploded;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponentInChildren<Animator>();

    }






    private void Update()
    {
        if (!IsExploded)
        {
            rb.velocity = new Vector2(Speed * Time.deltaTime, 0f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Explode();
        }

    }



    void Explode()
    {
        IsExploded = true;
        Anim.SetTrigger("Explosion");
    }

    public void DestroyRocketGO()
    {
        Destroy(this.gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Explode();
    }





}
