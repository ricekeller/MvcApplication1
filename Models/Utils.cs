using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
	public static class Utils
	{
		public static TimeSpan Diff(DateTime date1,DateTime date2)
		{
			return date2.Subtract(date1);
		}

		public static bool IsBackoffTimePassed(DateTime date,int backoffSeconds)
		{
			return DateTime.Now.Subtract(date).TotalSeconds > backoffSeconds;
		}
	}
}