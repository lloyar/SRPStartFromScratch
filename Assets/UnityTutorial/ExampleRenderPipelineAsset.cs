using UnityEngine;
using UnityEngine.Rendering;

namespace UnityTutorial
{
    [CreateAssetMenu(menuName = "Rendering/Example Render Pipeline")]
    public class ExampleRenderPipelineAsset : RenderPipelineAsset
    {
        protected override RenderPipeline CreatePipeline()
        {
            return new ExampleRenderPipeline();
        }
    }
}
