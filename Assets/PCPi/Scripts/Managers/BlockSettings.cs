/// <summary>
/// Project: ProtoBlock Builder
/// Made for use in Projects: Unicorn Snake & Protoblocks (...more to come?)
/// Filename: BlockSettings.cs
/// Created by PCPi & AltX
/// Written by: Gary Chisenhall & Topher Lee
/// </summary>
#region /// USING
using UnityEngine;
#endregion
namespace PCPi.scripts.Managers
{
    /// <summary>
    /// BlockSettings Class for ProtoBlock Builder
    /// </summary>
    public class BlockSettings : MonoBehaviour
    {
        #region /// Constants
        private const string MANAGER_PATH = "/PCPi/Prefabs/Managers/ProtoBlockSceneManager.prefab";
        #endregion
        #region /// Local Variables
        private GameObject BlockManager;
        private GameObject BlockToSpawn;
        private Color blockColor;
        private GameObject blockSurface;
        #endregion
        #region /// Global Variables
        public Material defaultMaterial;
        public Material highlightMaterial;
        #endregion
        void Start()
        {
            BlockManager = Resources.Load<GameObject>(MANAGER_PATH);
            if (!BlockManager)
            {
                Instantiate(BlockManager);
            }
            else
            {
                /// Do nothing
            }
            defaultMaterial = gameObject.GetComponent<Renderer>().material;
        }
        private void OnMouseDown()
        {
            BlockSpawnManager.PlaceSelectedBlock(BlockToSpawn, transform.position + transform.position, transform);
        }
        /// <summary>
        /// Activates highlighter material & assigns block to spawn
        /// </summary>
        private void OnMouseEnter()
        {
            if (BlockManager)
            {
                BlockToSpawn = BlockManager.GetComponent<BlockManager>().GetSelectedBlock();
            }
            gameObject.GetComponent<Renderer>().material = highlightMaterial;
        }
        /// <summary>
        /// Deactivates highlighter material
        /// </summary>
        private void OnMouseExit()
        {
            gameObject.GetComponent<Renderer>().material = defaultMaterial;
        }
    }
}
