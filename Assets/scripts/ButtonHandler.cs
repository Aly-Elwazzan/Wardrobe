using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SkinnedMeshRenderer))]
[ExecuteInEditMode]
public class ButtonHandler : MonoBehaviour
{
    public SkinnedMeshRenderer  skinnedMeshRenderer;
    public void increaseBlendShape()
    {  // increase first blendshape by 1
      float blendShapeWeight1= skinnedMeshRenderer.GetBlendShapeWeight(1);
      blendShapeWeight1=blendShapeWeight1+1;
      print(blendShapeWeight1);
        skinnedMeshRenderer.SetBlendShapeWeight (1,blendShapeWeight1) ;
    }
}
