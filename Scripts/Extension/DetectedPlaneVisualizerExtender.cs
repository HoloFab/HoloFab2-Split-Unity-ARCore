#if UNITY_ANDROID
using UnityEngine;
//using GoogleARCore.Examples.Common;
using UnityEngine.XR.ARCore;

public class DetectedPlaneVisualizerExtender : MonoBehaviour {
	public static bool flagVisible = true;
	// private string layerScanMesh = "Spatial Awareness";
	private MeshRenderer m_MeshRenderer;
	private MeshCollider m_MeshCollider;
    
	public void Awake()
	{
		m_MeshRenderer = GetComponent<MeshRenderer>();
		// gameObject.AddComponent<MeshCollider>();
		// gameObject.layer = LayerMask.NameToLayer(this.layerScanMesh);
		m_MeshCollider = GetComponent<MeshCollider>();
	}
    
	public void Update(){
		m_MeshCollider.sharedMesh = GetComponent<MeshFilter>().mesh;
		m_MeshRenderer.enabled = DetectedPlaneVisualizerExtender.flagVisible;
	}
}
#endif