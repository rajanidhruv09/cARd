using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArButtons_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit) )
                {
                    string name = hit.collider.name;

                    switch (name) {
                        case "LinkedIn":
                            Application.OpenURL("https://www.linkedin.com/in/dhruv-rajani");
                            Debug.Log("LinkedIn pressed");
                            break;
                        case "Resume":
                            Application.OpenURL("https://drive.google.com/file/d/1TY2wOEuUI6HJGVamudK194zCcLrwwi9A/view?usp=sharing");
                            Debug.Log("Resume pressed");
                            break;
                        case "Call":
                            Application.OpenURL("tel://+16479014511");
                            Debug.Log("Call pressed");
                            break;
                        case "Email":
                            Application.OpenURL("mailto:rajanidhruv09@gmail.com");
                            Debug.Log("Email pressed");
                            break;
                        default:
                            Debug.Log("No button pressed");
                            break;
                    }
                }
            }
        }
    }
}
