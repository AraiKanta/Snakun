using UnityEngine;
using System;
using UnityEngine.EventSystems;
[Serializable]
public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, ISubmitHandler
{
    public static EventHandler buttonDown, buttonUp;
    void OnEnable()
    {
        //	buttonDown += onButtonDown;
        buttonUp += onButtonDown;
    }
    void OnDisable()
    {
        //buttonDown -= onButtonDown;
        buttonUp -= onButtonDown;
    }
    public void OnSubmit(BaseEventData eventData)
    {
        Debug.Log(eventData.selectedObject.name);
		onButtonDown(eventData.selectedObject.name, null);
	
    }
    void onButtonDown(System.Object obj, EventArgs args)
    {
        if (!gameObject.activeSelf)
            return;
        if (!obj.ToString().Contains(gameObject.name))
            return;
    }
    public void OnPointerDown(PointerEventData data)
    {
		if (buttonDown != null) {
			buttonDown (gameObject.name, null);
		}

    }
    public void OnPointerUp(PointerEventData data)
    {
        if (buttonUp != null)
            buttonUp(gameObject.name, null);
    }
}
