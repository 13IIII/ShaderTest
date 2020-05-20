using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MeshHighlighter : MonoBehaviour
{
    private MeshRenderer originalMesh;
    [SerializeField]
    private MeshRenderer highlightMesh;

    void Start()
    {
        originalMesh = GetComponent<MeshRenderer>();
        EnableHighlight(false);
    }

    public void EnableHighlight(bool onOff)
    {
        if(highlightMesh != null)
        {
            highlightMesh.enabled = onOff;
            originalMesh.enabled = !onOff;
        }
    }

    private void OnMouseEnter()
    {
        EnableHighlight(true);
    }

    private void OnMouseExit()
    {
        EnableHighlight(false);
    }
}
