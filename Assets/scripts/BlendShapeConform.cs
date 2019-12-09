using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SkinnedMeshRenderer))]
[ExecuteInEditMode]
public class BlendShapeConform : MonoBehaviour
{

    public string NameFilter;
    public SkinnedMeshRenderer  SourceMeshRenderer;
    private SkinnedMeshRenderer _targetMeshRenderer;
    private string SourceFilter = "Genesis8Male__";

    // Start is called before the first frame update
    void Start()
    {
        _targetMeshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_targetMeshRenderer==null) return;
        StartCoroutine(UpdateShape());
    }

   IEnumerator UpdateShape()
    {

        var blendShapeCount =_targetMeshRenderer.sharedMesh.blendShapeCount;

        for(int i=0; i<blendShapeCount;i++)
        {
            var blendShapeName = SourceMeshRenderer.sharedMesh.GetBlendShapeName(i).Replace(SourceFilter,string.Empty);
            var blendShapeValue =SourceMeshRenderer.GetBlendShapeWeight(i);

            var targetIndex =_targetMeshRenderer.sharedMesh.GetBlendShapeIndex(NameFilter+blendShapeName);
            _targetMeshRenderer.SetBlendShapeWeight(targetIndex,blendShapeValue);
            yield return null;
            
        }
    }
}
