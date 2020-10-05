using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingTextAnimations : MonoBehaviour
{
    [SerializeField] private bool animationEnabled = default;
    #region Text animation
    [SerializeField] private TMP_Text screenText = default;
    [SerializeField] private string[] textLines = default;
    [SerializeField] private float textFrameDuration = default;
    private int currentLine;
    #endregion
    #region Circle animation
    [SerializeField] private RectTransform circleTransform;
    /// <summary>
    /// Degrees of rotation for each frame
    /// </summary>
    [SerializeField] private int rotation = default;
    [SerializeField] private float circleFrameDuration = default;
    #endregion


    private void Start()
    {
        StartCoroutine(AnimateTextCoroutine());
        StartCoroutine(AnimateLoadingCircle());
    }

    private IEnumerator AnimateTextCoroutine()
    {
        while (animationEnabled)
        {
            screenText.text = textLines[currentLine];
            yield return new WaitForSeconds(textFrameDuration);
            currentLine = (currentLine + 1) % textLines.Length;
        }
    }

    private IEnumerator AnimateLoadingCircle()
    {
        while (animationEnabled)
        {
            circleTransform.Rotate(new Vector3(0,0, rotation));
            yield return new WaitForSeconds(circleFrameDuration);
        }
    }
}
