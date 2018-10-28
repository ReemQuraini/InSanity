using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour {
 

    public Button startText;
    public Button exitText;



// Use this for initialization
void Start () {
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
    }

    public void ExitPress()
    {
        Application.Quit();
    }

    public void StartPress()
    {
        SceneManager.LoadScene("scene1");
    }
    // Update is called once per frame
    void Update () {
	    
	}
}
