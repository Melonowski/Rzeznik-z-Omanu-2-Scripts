using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{

    [Header("References")]
    public RectTransform minimapPoint_1;
    public RectTransform minimapPoint_2;
    public Transform worldPoint_1;
    public Transform worldPoint_2;

    [Header("Player")]
    public RectTransform playerMinimap;
    public Transform playerWorld;

    private float minimapRatio;

    private void Awake()
    {
        CalculateMapRatio();
    }

    private void Update()
    {
        playerMinimap.anchoredPosition = minimapPoint_1.anchoredPosition + new Vector2((playerWorld.position.x - worldPoint_1.position.x) * minimapRatio, (playerWorld.position.y - worldPoint_1.position.y) * minimapRatio);
    }

    public void CalculateMapRatio()
    {

        Vector3 distanceWorldVector = worldPoint_1.position - worldPoint_2.position;
        distanceWorldVector.z = 0f;
        float distanceWorld = distanceWorldVector.magnitude;


        float distanceMinimap = Mathf.Sqrt(
            Mathf.Pow((minimapPoint_1.anchoredPosition.x - minimapPoint_2.anchoredPosition.x), 2) +
            Mathf.Pow((minimapPoint_1.anchoredPosition.y - minimapPoint_2.anchoredPosition.y), 2));


        minimapRatio = distanceMinimap / distanceWorld;
    }

}
