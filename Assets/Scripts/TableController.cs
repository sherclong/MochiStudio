using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    public Animator slideAnim;
    public GameObject playerTogGroup;
    public GameObject player1Panel;
    public GameObject player2Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SlideInTable()
    {
        slideAnim.SetBool("open", true);
    }
    public void SlideOutTable()
    {
        slideAnim.SetBool("open", false);
    }
}
