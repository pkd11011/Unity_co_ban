using UnityEngine; // Chỉ cần giữ lại cái này

public class WorldToScreen : MonoBehaviour
{
    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // Bây giờ Unity sẽ hiểu đúng là lệnh của UnityEngine
        Debug.Log(screenPos);
    }
}