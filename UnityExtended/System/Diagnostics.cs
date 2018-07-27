using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UnityExtended
{
    public static class Diagnostics
    {
        public static string CallerString
        {
            get
            {
                StackTrace trace = new StackTrace();
                MethodBase method = trace.GetFrame(2).GetMethod();
                return method.DeclaringType.ToString() + "." + method.Name;
            }
        }
    }
}
