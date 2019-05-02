/// <summary>
/// Project: ProtoBlock Builder
/// Made for use in Projects: Unicorn Snake & Protoblocks (...more to come?)
/// Filename: BlockManager.cs
/// Created by PCPi & AltX
/// Written by: Gary Chisenhall
/// </summary>
#region /// USING
using UnityEngine;
#endregion
namespace PCPi.scripts.Managers
{
    [AddComponentMenu("PCPi/ProtoBlock Scene Manager")]
    public class BlockManager : MonoBehaviour
    {
        #region /// Properties
        private GameObject selectedBlock;
        
        private GameObject baseBlock;
        public GameObject SelectedBlock { get => selectedBlock; set => selectedBlock = value; }
        public GameObject BaseBlock { get => baseBlock; set => baseBlock = value; }
        #endregion

        #region /// Property Methods
        public GameObject GetBaseBlock()
        {
            return BaseBlock;
        }

        public void SetBaseBlock(GameObject value)
        {
            BaseBlock = value;
            //PlaceBase(value);
        }

        public GameObject GetSelectedBlock()
        {
            return SelectedBlock;
        }

        public void SetSelectedBlock(GameObject value)
        {
            SelectedBlock = value;
        }
        #endregion
        //public static void PlaceBase(GameObject baseBlock)
        //{
        //    BlockSpawnManager.PlaceBaseBlock(baseBlock);
        //}
    }
}