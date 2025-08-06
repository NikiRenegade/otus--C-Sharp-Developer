using System;
using System.Collections;
using System.Collections.Generic;

namespace hw8_Delegate
{
	public static class IEnumerableExtension
	{
		public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
		{
			if (collection == null)
			{
				throw new ArgumentNullException(nameof(collection), "Collection cannot be null");
			}
			var max = collection.OrderByDescending(convertToNumber).FirstOrDefault();

			return max;
		}


	}
}


