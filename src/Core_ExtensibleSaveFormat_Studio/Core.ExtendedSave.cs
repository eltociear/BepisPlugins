﻿using System.Collections.Generic;

namespace ExtensibleSaveFormat
{
    public partial class ExtendedSave
    {
        internal static Dictionary<string, PluginData> internalSceneDictionary = new Dictionary<string, PluginData>();

        /// <summary>
        /// Get PluginData for a scene for the specified extended save data ID
        /// </summary>
        /// <param name="id">ID of the data saved to the card</param>
        /// <returns>PluginData</returns>
        public static PluginData GetSceneExtendedDataById(string id) => id != null && internalSceneDictionary.TryGetValue(id, out var extendedSection) ? extendedSection : null;

        /// <summary>
        /// Set PluginData for a scene for the specified extended save data ID
        /// </summary>
        /// <param name="id">ID of the data to be saved to the card</param>
        /// <param name="extendedFormatData">PluginData to save to the card</param>
        public static void SetSceneExtendedDataById(string id, PluginData extendedFormatData) => internalSceneDictionary[id] = extendedFormatData;


        internal static Dictionary<string, PluginData> internalPoseDictionary = new Dictionary<string, PluginData>();

        /// <summary>
        /// Get PluginData for a pose for the specified extended save data ID
        /// </summary>
        /// <param name="id">ID of the data saved to the card</param>
        /// <returns>PluginData</returns>
        public static PluginData GetPoseExtendedDataById(string id) => id != null && internalPoseDictionary.TryGetValue(id, out var extendedSection) ? extendedSection : null;

        /// <summary>
        /// Set PluginData for a pose for the specified extended save data ID
        /// </summary>
        /// <param name="id">ID of the data to be saved to the card</param>
        /// <param name="extendedFormatData">PluginData to save to the card</param>
        public static void SetPoseExtendedDataById(string id, PluginData extendedFormatData) => internalPoseDictionary[id] = extendedFormatData;
    }
}