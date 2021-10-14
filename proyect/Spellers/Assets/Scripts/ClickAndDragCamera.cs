using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Camera))]
public class ClickAndDragCamera : MonoBehaviour
{
    #region Scene References
    [SerializeField] private RectTransform tf_panel;
    [Range(0, 100)]
    [SerializeField] private float speed = 20f;
    #endregion

    #region Private Fields
    private Vector2 minPos, maxPos;
    private Vector3 clickWorldPos, dragWorldPos;
    #endregion

    #region UnityEvents
    private void OnEnable()
    {
        SetBounds();
    }

    private void LateUpdate()
    {
        HandleMouseInput();
    }
    #endregion

    #region Private Methods

    private void SetBounds()
    {
        Camera cam = this.GetComponent<Camera>();
        Vector2 camSize = cam.rect.size * cam.orthographicSize * new Vector2(cam.aspect, 1);
        minPos = tf_panel.rect.position + camSize;
        maxPos = minPos + tf_panel.rect.size - 2f * camSize;
    }

    private void HandleMouseInput()
    {
        Vector3 newPos = transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            if (GetMouseWorldPosition(out Vector3 mousePos))
            {
                clickWorldPos = mousePos;
            }
        }
        else if (Input.GetMouseButton(0))
        {
            if (GetMouseWorldPosition(out Vector3 mousePos))
            {
                dragWorldPos = mousePos;
                newPos = transform.position + clickWorldPos - dragWorldPos;
            }
        }
        newPos.x = Mathf.Clamp(newPos.x, minPos.x, maxPos.x);
        newPos.y = Mathf.Clamp(newPos.y, minPos.y, maxPos.y);
        transform.position = Vector3.Lerp(newPos, transform.position, Time.deltaTime * 5f);
    }

    private static bool GetMouseWorldPosition(out Vector3 mousePos)
    {
        Plane plane = new Plane(Vector3.back, Vector2.zero);
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool hit = (plane.Raycast(mouseRay, out float dist));
        mousePos = mouseRay.GetPoint(dist);
        return hit;
    }
    #endregion
}

