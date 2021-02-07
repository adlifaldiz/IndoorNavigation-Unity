using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update init back is processed");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("back is pressed");
            backtoMenu();
        }
    }

    public void backtoMenu()
    {
        Debug.Log("back to menu is processed");
        SceneManager.LoadScene("Main_menu");
    }
}
