using System;

namespace Constants
{
    public enum Scenes
    {
        [SceneName("_prescene")]
        Preload = 0,
        [SceneName("MainMenu")]
        MainMenu = 1,
        [SceneName("StreetBattle")]
        StreetBattle = 2,
        [SceneName("TestingScene")]
        Testing = 3
    }
    
    public static class GameSceneExtensions
    {
        public static string GetSceneName(this Scenes val)
        {
            SceneNameAttribute[] attributes = (SceneNameAttribute[])val
                .GetType()
                .GetField(val.ToString())
                .GetCustomAttributes(typeof(SceneNameAttribute), false);
            return attributes.Length > 0 ? attributes[0].SceneName : string.Empty;
        }
    }

    internal class SceneNameAttribute : Attribute
    {
        public string SceneName;
        public SceneNameAttribute(string sceneName)
        {
            SceneName = sceneName;
        }
    }
}