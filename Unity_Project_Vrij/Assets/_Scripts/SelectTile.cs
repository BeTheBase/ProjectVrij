using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTile : MonoBehaviour
{
    public GameObject SelectedGameObject;
    public GameObject UIPrefab;

    private Camera _mainCamera;

    // Use this for initialization
    public void Awake()
    {
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SetHudActive();
        }
    }

    //make the hud for object manipulation active and parent it on the right object
    private void SetHudActive()
    {
        SelectedGameObject = SelectObject();
        if (SelectedGameObject == null)
            return;
        if (UIPrefab.gameObject.activeSelf)
            UIPrefab.SetActive(false);
        else
            UIPrefab.SetActive(true);
        UIPrefab.transform.SetParent(SelectedGameObject.transform);
        UIPrefab.transform.position = SelectedGameObject.transform.position + new Vector3(0,1f, 0);
        //UIPrefab.transform.localScale = new Vector3(1, 1, 1);
    }

    //return the object that is selected by mouse using a raycast
    public GameObject SelectObject()
    {
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            return hit.transform.tag == "TowerTile" ? hit.transform.gameObject : null;
        else
            return null;
    }
}
