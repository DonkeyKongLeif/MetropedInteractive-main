using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float timer = 0f; 
    private float returnInterval = 3f; 
    private MeshRenderer meshRenderer;
    Vector3 originalPos;
    public Vector3 stopPos;

    public float speed = 10f;
    public float topSpeed = 10f;
    public float accelleration = 0.04f;

    private bool brake;
    private bool isStationary = false;
    public float timeBeforeOpen = 3;
    public float timeWhileOpen = 3;
    public float timeAfterClose = 3;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        // originalPos = transform.position;
        originalPos = new Vector3(-40, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if (transform.position.x < 170)
        {
            if (speed > 0 && brake) {
                // Debug.Log("Braking");
                speed -= accelleration;
            } else if (speed <= 0 && brake && !isStationary) {
                // Debug.Log("Stopped");
                speed = 0;
                StartStationary();
            }

            if(speed < topSpeed && !brake) {speed += accelleration;}
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            timer += Time.deltaTime;

            if (timer >= returnInterval)
            {
                transform.position = originalPos;
                speed = topSpeed;
                timer = 0f;
            }
        }
    }

    void StartStationary(){
        if (!isStationary) {
            isStationary = true;
            StartCoroutine(StationaryTimer(()=>{brake = false; isStationary = false;}));
        }
    }

    IEnumerator StationaryTimer(System.Action action) {
        yield return new WaitForSeconds(timeBeforeOpen);
        OpenDoors();
        yield return new WaitForSeconds(timeWhileOpen);
        CloseDoors();
        yield return new WaitForSeconds(timeAfterClose);        
        action?.Invoke();
    }

    void OpenDoors() {
        Debug.Log("Opening Doors");
    }

    void CloseDoors() {
        Debug.Log("Closing Doors");
    }

    void OnTriggerEnter(Collider collision) {
        if (collision.CompareTag("BrakePoint")) {brake = true;}
        Debug.Log("Breakpint hit");
    }
}