using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingUIManager : MonoBehaviour
{
    public CharacterActionSelectionUI Character_ActSelUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Character_ActSelUI.ActiveActSelUI(hit.transform.gameObject, 1);
                //ShowUIOnTarget(hit.transform);
            }
        }
    }
}
