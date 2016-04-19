using UnityEngine;

public class ResponsiveUI : MonoBehaviour {

    public RectTransform.Axis mainAxis;
    public Unit resizeUnits = Unit.Percentage;
    public float size;
    public bool limitCrossAxis = false;
    public Unit crossAxisUnits = Unit.Percentage;
    public float maxCrossSize;

    public enum Unit
    {
        Pixels,
        Percentage
    }

    // Rect Transform will be resized on Start().
    void Start()
    {
        RectTransform rect = this.GetComponent<RectTransform>();
        rect.SetSizeWithCurrentAnchors(
            mainAxis,
            resizeUnits == Unit.Percentage ? GetPixelsForPercentage(mainAxis, size) : size
        );

        if (limitCrossAxis)
        {
            RectTransform.Axis crossAxis = (mainAxis == RectTransform.Axis.Horizontal) ? RectTransform.Axis.Horizontal : RectTransform.Axis.Vertical;

            rect.SetSizeWithCurrentAnchors(
                crossAxis,
                crossAxisUnits == Unit.Percentage ? GetPixelsForPercentage(crossAxis, maxCrossSize) : maxCrossSize
            );
        }

    }

    //Given an axis and a percentage, return the screen percentage in pixels.
    public static float GetPixelsForPercentage(RectTransform.Axis axis, float percentage)
    {

        if (axis == RectTransform.Axis.Horizontal)
        {
            return Screen.width / 100 * percentage;
        }
        else if (axis == RectTransform.Axis.Vertical)
        {
            return Screen.height / 100 * percentage;
        }
        return 0f;
    }

}
