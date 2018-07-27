using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UnityExtended
{
    public static partial class Extensions
    {
        /// <summary>
        /// TODO
        /// </summary>
        public static string ToLongString(this ParameterInfo param)
        {
            string text = string.Empty;

            if (param.IsIn) text += "in";
            else if (param.IsOut) text += "out";
            else if (param.ParameterType.IsByRef) text += "ref";

            text += " " + param.ParameterType.ToString() + " " + param.Name;

            if (param.IsOptional)
            {
                text += " = ";
                if (param.DefaultValue != null)
                    text += param.DefaultValue.ToString();
                else
                    text += "null";
            }

            return text;
        }

        /// <summary>
        /// TODO
        /// </summary>
        public static string ToLongString(this MethodBase method)
        {
            MethodInfo info = method as MethodInfo;

            Match match = Regex.Match(info.ReturnType.ToString(), @"(\d+)[^.]*$");

            string text = match.Groups[match.Groups.Count - 1].Value;

            ParameterInfo[] prmsInfo = method.GetParameters();

            string cls = method.DeclaringType.ToString();
            string prms = string.Empty;
            if (prmsInfo != null)
            {
                for (int i = 0; i < prmsInfo.Length; i++)
                    prms += prmsInfo[i].ParameterType + " " + prmsInfo[i].Name;
            }
            return prms;
        }
    }
}