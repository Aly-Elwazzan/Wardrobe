using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(SkinnedMeshRenderer))]
[ExecuteInEditMode]
public class SliderFat : MonoBehaviour
{
    public Slider slider;
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public int blendShapeNumber = 0;
    public void ChangeBlendShape()
    {  // get slider value
        //float blendShapeWeight1 = skinnedMeshRenderer.GetBlendShapeWeight(blendShapeNumber);
        //blendShapeWeight1 = blendShapeWeight1 + 1;
       // print(blendShapeWeight1);
        skinnedMeshRenderer.SetBlendShapeWeight(blendShapeNumber, slider.value);
    }
}
