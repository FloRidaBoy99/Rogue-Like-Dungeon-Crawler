using System;
using Assets.HeroEditor4D.Common.CharacterScripts;
using Assets.HeroEditor4D.Common.CommonScripts;
using HeroEditor.Common;
using HeroEditor.Common.Data;
using UnityEngine;

namespace Assets.HeroEditor4D.Common.ExampleScripts
{
    [Serializable]
    public class CharacterAppearance
    {
        public string Hair = "BuzzCut";
        public string Ears = "Human";
        public string Eyebrows = "Default";
        public string Eyes = "Boy";
        public string Mouth = "Default";
        public string Body = "HumanMale";

        public Color32 HairColor = new Color32(150, 50, 0, 255);
        public Color32 EyesColor = new Color32(0, 200, 255, 255);
        public Color32 BodyColor = new Color32(255, 200, 120, 255);

        public void Setup(Character4D character)
        {
            character.Parts.ForEach(Setup);
        }

        public void Setup(CharacterBase character)
        {
            character.Hair = Hair.IsEmpty() ? null : character.HairRenderer.GetComponent<SpriteMapping>().FindSprite(SpriteCollection.Instance.Hair.FindSprites(Hair));
            character.HairRenderer.color = HairColor;
            character.Ears = SpriteCollection.Instance.Ears.FindSprites(Ears);

            if (character.Expressions.Count > 0)
            {
                character.Expressions[0] = new Expression
                {
                    Name = "Default",
                    Eyebrows = Eyebrows.IsEmpty() ? null : character.EyebrowsRenderer.GetComponent<SpriteMapping>().FindSprite(SpriteCollection.Instance.Eyebrows.FindSprites(Eyebrows)),
                    Eyes = character.EyesRenderer.GetComponent<SpriteMapping>().FindSprite(SpriteCollection.Instance.Eyes.FindSprites(Eyes)),
                    Mouth = character.MouthRenderer.GetComponent<SpriteMapping>().FindSprite(SpriteCollection.Instance.Mouth.FindSprites(Mouth))
                };
            }

            character.EyesRenderer.color = EyesColor;
            character.BodyRenderers.ForEach(i => i.color = BodyColor);
            character.EarsRenderers.ForEach(i => i.color = BodyColor);
            character.Body = SpriteCollection.Instance.Body.FindSprites(Body);
        }

        public string ToJson()
        {
            return JsonUtility.ToJson(this);
        }

        public static CharacterAppearance FromJson(string json)
        {
            return JsonUtility.FromJson<CharacterAppearance>(json);
        }
    }
}