using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour
{
    public GameObject snowBallCloneTemplate;

    Animator animator;
    // Start is called before the first frame update
    void Start()

    {
        animator = GetComponent<Animator>();
        if (animator == null)
            animator = GetComponent<Animator>();
        else
            print("Animator Component found");





    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            GameObject newSnowballGO = Instantiate(snowBallCloneTemplate, transform.position + transform.forward + Vector3.up, Quaternion.identity);
            snowball myNewSnowball = newSnowballGO.GetComponent<snowball>();
            myNewSnowball.throwSnowball(transform);
        }

        animator.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.down, 30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.position += Vector3.back * Time.deltaTime;





    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collision.gameObject.name");
        collision.gameObject.transform.position += Vector3.forward;
        FootballScript myFootball = collision.gameObject.GetComponent<FootballScript>();
        if (myFootball != null)
        {
            myFootball.kick();
        }

    }
}
        


