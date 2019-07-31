using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draggableBox : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public Camera myCam;
    public GameObject handHover;
    public GameObject handGrab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnMouseEnter()
    {
        handHover.SetActive(true);
        
    }
    void OnMouseDown()
    {
        
        screenPoint = myCam.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - myCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
    }
    private void OnMouseUp()
    {
        handGrab.SetActive(false);
        handHover.SetActive(true);
    }
    void OnMouseDrag()
    {
        handHover.SetActive(false);
        handGrab.SetActive(true);
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        Vector3 cursorPosition = myCam.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }

    private void OnMouseExit()
    {
        handGrab.SetActive(false);
        handHover.SetActive(false);

    }
}
