using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CharacterActionSelectionUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera UICamera;
    public RectTransform ParentRectTransform;

    protected GameObject TargetObject = null;
    protected Vector3 WorldOffset = new Vector3(0f, 0.5f, 0f);
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == false || TargetObject == null)
            return;

        DisplayCharacterActionUI();
    }

    public void ActiveActSelUI(GameObject Target, int ActiveCount)
    {
        TargetObject = Target;
        DisplayCharacterActionUI();
        gameObject.SetActive(true);
    }

    public void InActiveActSelUI()
    {
        gameObject.SetActive(false);
        TargetObject = null;
    }

    protected void DisplayCharacterActionUI()
    {
        Vector3 ScreenPosition = Camera.main.WorldToScreenPoint(TargetObject.transform.position + WorldOffset);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(ParentRectTransform, ScreenPosition, UICamera, out Vector2 localPos);
        gameObject.GetComponent<RectTransform>().anchoredPosition = localPos;
    }
}
