using System;
using System.Collections.Generic;
using HeroEditor.Common;
using UnityEngine;

namespace Assets.HeroEditor4D.Common.CharacterScripts
{
	/// <summary>
	/// Controls 4 characters (for each direction).
	/// </summary>
	public class Character4D : Character4DBase
	{
		public List<GameObject> Shadows;

		public void OnValidate()
		{
			Parts = new List<CharacterBase> { Front, Back, Left, Right };
			Parts.ForEach(i => i.BodyRenderers.ForEach(j => j.color = BodyColor));
			Parts.ForEach(i => i.EarsRenderers.ForEach(j => j.color = BodyColor));
		}

		public override void Initialize()
		{
			Parts.ForEach(i => i.Initialize());
		}

		public override void CopyFrom(Character4DBase character)
		{
			for (var i = 0; i < Parts.Count; i++)
			{
				Parts[i].CopyFrom(character.Parts[i]);
			}
		}

		public override string ToJson()
		{
		    return Front.ToJson();
		}

		public override void LoadFromJson(string json)
		{
		    Parts.ForEach(i => i.LoadFromJson(json));
		}

		public Vector2 Direction { get; private set; }

		public void SetDirection(Vector2 direction)
		{
			Direction = direction;

			Parts.ForEach(i => i.transform.localPosition = Vector3.zero);
			Shadows.ForEach(i => i.transform.localPosition = Vector3.zero);

			int index;

			if (direction == Vector2.left)
			{
				index = 2;
			}
			else if (direction == Vector2.right)
			{
				index = 3;
			}
			else if (direction == Vector2.up)
			{
				index = 1;
			}
			else if (direction == Vector2.down)
			{
				index = 0;
			}
			else
			{
				throw new NotSupportedException();
			}

			var parts = new[] { Front, Back, Left, Right };

			for (var i = 0; i < parts.Length; i++)
			{
				parts[i].gameObject.SetActive(i == index);
				Shadows[i].SetActive(i == index);
			}
		}
	}
}