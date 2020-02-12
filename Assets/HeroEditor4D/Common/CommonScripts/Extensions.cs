using System.Collections.Generic;
using System.Linq;
using HeroEditor.Common;
using UnityEngine;

namespace Assets.HeroEditor4D.Common.CommonScripts
{
    public static class Extensions
    {
        public static bool IsEmpty(this string target)
        {
            return string.IsNullOrEmpty(target);
        }

        public static void Clear(this Transform transform)
        {
            foreach (Transform child in transform)
            {
                Object.Destroy(child.gameObject);
            }
        }

        public static T Random<T>(this T[] source)
        {
            return source[UnityEngine.Random.Range(0, source.Length)];
        }

        public static T Random<T>(this List<T> source)
        {
            return source[UnityEngine.Random.Range(0, source.Count)];
        }

        public static T Random<T>(this List<T> source, int seed)
        {
            UnityEngine.Random.InitState(seed);

            return source[UnityEngine.Random.Range(0, source.Count)];
        }

        public static Sprite FindSprite(this List<SpriteGroupEntry> list, string name, string collection = null)
        {
            return list.Single(i => i.Name == name && (collection == null || i.Collection == collection)).Sprite;
        }

        public static List<Sprite> FindSprites(this List<SpriteGroupEntry> list, string name, string collection = null)
        {
            return list.Single(i => i.Name == name && (collection == null || i.Collection == collection)).Sprites;
        }
    }
}