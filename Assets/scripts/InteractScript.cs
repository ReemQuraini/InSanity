using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractScript : MonoBehaviour {

    public string interactButton;
    public bool isInteracting;
    public AudioSource audioSurce;
    public float interactionDistance = 3f;
    public LayerMask interactLayer;
    //filter

    public Image interactionIcon;
    // Use this for initialization
    void Start () {



        if (interactionIcon != null)
        {
            interactionIcon.enabled = false;

        }

    }

    // Update is called once per frame
    void Update () {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
       
        //shoots a ray
        if (Physics.Raycast(ray, out hit, interactionDistance, interactLayer))
        {
            //checks if we are not interacting
            if (isInteracting == false)
            {
                if (interactionIcon != null)
                {
                    interactionIcon.enabled = true;
                }

                //if we press the interaction button
                if (Input.GetButtonDown(interactButton))
                {
                    //if it's a door
                    if (hit.collider.CompareTag("Door"))
                    {
                        //Open,close door
                        hit.collider.GetComponent<DoorScript>().ChangeDoorState();
                    }

					//if it's a Fridge
                    if (hit.collider.CompareTag("Fridge"))
                    {
                        //Open,close door
                        hit.collider.GetComponent<FridgeScript>().ChangeDoorState();
                    }

                    //if it's a Note
                      else if (hit.collider.CompareTag("Note"))
                     {
                         hit.collider.GetComponent<Note>().showNote();

                     }
					//if it's a CellPhone
					else if (hit.collider.CompareTag("CellPhone"))
					{
						hit.collider.GetComponent<Note>().showNote();

					}
					//if it's a TV
					else if (hit.collider.CompareTag("TV"))
					{
						hit.collider.GetComponent<Note>().showNote();

					}
					//if it's pills
					else if (hit.collider.CompareTag("Pills"))
					{
						hit.collider.GetComponent<Pills>().Place();

					}
					else if (hit.collider.CompareTag("Knife"))
					{
						hit.collider.GetComponent<Knife>().Place();

					}
                }

            }

        }
        else
        {
            interactionIcon.enabled = false;
        }
    }
}

