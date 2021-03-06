﻿using FormEditor.Validation.Conditions;

namespace FormEditor.Rendering
{
	public class ConditionData
	{
		public ConditionData(Condition condition)
		{
			Type = condition.Type;
		}

		public string Type { get; private set; }
	}
}