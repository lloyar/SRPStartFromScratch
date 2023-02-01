using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/Custom Rneder Pipeline")]
public class CustomRenderPipelineAsset : RenderPipelineAsset
{
	protected override RenderPipeline CreatePipeline () {
		return new CustomRenderPipeline();
	}
}
