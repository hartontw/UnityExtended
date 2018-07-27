using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{

    /// <summary>
    /// An extended version of UnityEngine.Debug
    /// </summary>
    public static class HDebug
    {
        /// <summary>
        /// Draw precision over radius.
        /// </summary>
        public static int drawPrecision = 1000;

        /// <summary>
        /// Reports whether the development console is visible. The development console cannot be made to appear using:
        /// </summary>
        public static bool developerConsoleVisible
        {
            get { return Debug.developerConsoleVisible; }
            set { Debug.developerConsoleVisible = value; }
        }

        /// <summary>
        /// Get default debug logger.
        /// </summary>
        public static ILogger unityLogger { get { return Debug.unityLogger; } }

        /// <summary>
        /// In the Build Settings dialog there is a check box called "Development Build".
        /// </summary>
        public static bool isDebugBuild { get { return Debug.isDebugBuild; } }

        /// <summary>
        /// Assert a condition and logs an error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="message">String representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void Assert(bool condition, string message, Object context)
        {
            Debug.Assert(condition, message, context);
        }

        /// <summary>
        /// Assert a condition and logs an error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void Assert(bool condition, object message, Object context)
        {
            Debug.Assert(condition, message, context);
        }

        /// <summary>
        /// Assert a condition and logs an error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="message">String representation for display.</param>
        public static void Assert(bool condition, string message)
        {
            Debug.Assert(condition, message);
        }

        /// <summary>
        /// Assert a condition and logs an error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        public static void Assert(bool condition, object message)
        {
            Debug.Assert(condition, message);
        }

        /// <summary>
        /// Assert a condition and logs an error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void Assert(bool condition, Object context)
        {
            Debug.Assert(condition, context);
        }

        /// <summary>
        /// Assert a condition and logs an error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        public static void Assert(bool condition)
        {
            Debug.Assert(condition);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void AssertFormat(bool condition, string format, params object[] args)
        {
            Debug.AssertFormat(condition, format, args);
        }

        /// <summary>
        /// Assert a condition and logs a formatted error message to the Unity console on failure.
        /// </summary>
        /// <param name="condition">Condition you expect to be true.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void AssertFormat(bool condition, Object context, string format, params object[] args)
        {
            Debug.AssertFormat(condition, context, format, args);
        }

        /// <summary>
        /// Pauses the editor.
        /// </summary>
        public static void Break()
        {
            Debug.Break();
        }

        /// <summary>
        /// Clears errors from the developer console.
        /// </summary>
        public static void ClearDeveloperConsole()
        {
            Debug.ClearDeveloperConsole();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DebugBreak()
        {
            Debug.DebugBreak();
        }

        /// <summary>
        /// Draws a line between specified start and end points.
        /// </summary>
        /// <param name="start">Point in world space where the line should start.</param>
        /// <param name="end">Point in world space where the line should end.</param>
        /// <param name="color">Color of the line.</param>
        /// <param name="duration">How long the line should be visible for.</param>
        /// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
        public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
        {
            Debug.DrawLine(start, end, color, duration, depthTest);
        }

        /// <summary>
        /// Draws a line between specified start and end points.
        /// </summary>
        /// <param name="start">Point in world space where the line should start.</param>
        /// <param name="end">Point in world space where the line should end.</param>
        /// <param name="color">Color of the line.</param>
        /// <param name="duration">How long the line should be visible for.</param>
        public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
        {
            Debug.DrawLine(start, end, color, duration);
        }

        /// <summary>
        /// Draws a line between specified start and end points.
        /// </summary>
        /// <param name="start">Point in world space where the line should start.</param>
        /// <param name="end">Point in world space where the line should end.</param>
        /// <param name="color">Color of the line.</param>
        public static void DrawLine(Vector3 start, Vector3 end, Color color)
        {
            Debug.DrawLine(start, end, color);
        }

        /// <summary>
        /// Draws a line between specified start and end points.
        /// </summary>
        /// <param name="start">Point in world space where the line should start.</param>
        /// <param name="end">Point in world space where the line should end.</param>
        public static void DrawLine(Vector3 start, Vector3 end)
        {
            Debug.DrawLine(start, end);
        }

        /// <summary>
        /// Draws a line from start to start + dir in world coordinates.
        /// </summary>
        /// <param name="start">Point in world space where the ray should start.</param>
        /// <param name="dir">Direction and length of the ray.</param>
        /// <param name="color">Color of the drawn line.</param>
        /// <param name="duration">How long the line will be visible for (in seconds).</param>
        /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
        public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
        {
            Debug.DrawRay(start, dir, color, duration, depthTest);
        }

        /// <summary>
        /// Draws a line from start to start + dir in world coordinates.
        /// </summary>
        /// <param name="start">Point in world space where the ray should start.</param>
        /// <param name="dir">Direction and length of the ray.</param>
        /// <param name="color">Color of the drawn line.</param>
        /// <param name="duration">How long the line will be visible for (in seconds).</param>
        public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
        {
            Debug.DrawRay(start, dir, color, duration);
        }

        /// <summary>
        /// Draws a line from start to start + dir in world coordinates.
        /// </summary>
        /// <param name="start">Point in world space where the ray should start.</param>
        /// <param name="dir">Direction and length of the ray.</param>
        /// <param name="color">Color of the drawn line.</param>
        public static void DrawRay(Vector3 start, Vector3 dir, Color color)
        {
            Debug.DrawRay(start, dir, color);
        }

        /// <summary>
        /// Draws a line from start to start + dir in world coordinates.
        /// </summary>
        /// <param name="start">Point in world space where the ray should start.</param>
        /// <param name="dir">Direction and length of the ray.</param>
        public static void DrawRay(Vector3 start, Vector3 dir)
        {
            Debug.DrawRay(start, dir);
        }

        /// <summary>
        /// Logs message to the Unity Console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void Log(object message, Object context)
        {
            Debug.Log(message, context);
        }

        /// <summary>
        /// Logs message to the Unity Console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        public static void Log(object message)
        {
            Debug.Log(message);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an assertion message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogAssertion(object message, Object context)
        {
            Debug.LogAssertion(message, context);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an assertion message to the console.
        /// </summary>
        /// <param name="message">Object to which the message applies.</param>
        public static void LogAssertion(object message)
        {
            Debug.LogAssertion(message);
        }

        /// <summary>
        /// Logs a formatted assertion message to the Unity console.
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogAssertionFormat(Object context, string format, params object[] args)
        {
            Debug.LogAssertionFormat(context, format, args);
        }

        /// <summary>
        /// Logs a formatted assertion message to the Unity console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogAssertionFormat(string format, params object[] args)
        {
            Debug.LogAssertionFormat(format, args);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogError(object message, Object context)
        {
            Debug.LogError(message, context);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        public static void LogError(object message)
        {
            Debug.LogError(message);
        }

        /// <summary>
        /// Logs a formatted error message to the Unity console.
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogErrorFormat(Object context, string format, params object[] args)
        {
            Debug.LogErrorFormat(context, format, args);
        }

        /// <summary>
        /// Logs a formatted error message to the Unity console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogErrorFormat(string format, params object[] args)
        {
            Debug.LogErrorFormat(format, args);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="exception">Runtime Exception</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogException(System.Exception exception, Object context)
        {
            Debug.LogException(exception, context);
        }

        /// <summary>
        /// A variant of Debug.Log that logs an error message to the console.
        /// </summary>
        /// <param name="exception">Runtime Exception.</param>
        public static void LogException(System.Exception exception)
        {
            Debug.LogException(exception);
        }

        /// <summary>
        /// Logs a formatted message to the Unity Console.
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogFormat(Object context, string format, params object[] args)
        {
            Debug.LogFormat(context, format, args);
        }

        /// <summary>
        /// Logs a formatted message to the Unity Console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogFormat(string format, params object[] args)
        {
            Debug.LogFormat(format, args);
        }

        /// <summary>
        /// A variant of Debug.Log that logs a warning message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogWarning(object message, Object context)
        {
            Debug.LogWarning(message, context);
        }

        /// <summary>
        /// A variant of Debug.Log that logs a warning message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        public static void LogWarning(object message)
        {
            Debug.LogWarning(message);
        }

        /// <summary>
        /// Logs a formatted warning message to the Unity Console.
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogWarningFormat(Object context, string format, params object[] args)
        {
            Debug.LogWarningFormat(context, format, args);
        }

        /// <summary>
        /// Logs a formatted warning message to the Unity Console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        public static void LogWarningFormat(string format, params object[] args)
        {
            Debug.LogWarningFormat(format, args);
        }

        /// <summary>
        /// Draws a line from ray properties in world coordinates.
        /// </summary>
        /// <param name="ray">Ray to draw.</param>
        /// <param name="color">Color of the drawn line.</param>
        /// <param name="duration">How long the line will be visible for (in seconds).</param>
        /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
        public static void DrawRay(Ray ray, Color color, float duration, bool depthTest)
        {
            Debug.DrawRay(ray.origin, ray.direction, color, duration, depthTest);
        }

        /// <summary>
        /// Draws a line from ray properties in world coordinates.
        /// </summary>
        /// <param name="ray">Ray to draw.</param>
        /// <param name="color">Color of the drawn line.</param>
        /// <param name="duration">How long the line will be visible for (in seconds).</param>
        public static void DrawRay(Ray ray, Color color, float duration)
        {
            Debug.DrawRay(ray.origin, ray.direction, color, duration);
        }

        /// <summary>
        /// Draws a line from ray properties in world coordinates.
        /// </summary>
        /// <param name="ray">Ray to draw.</param>
        /// <param name="color">Color of the drawn line.</param>
        public static void DrawRay(Ray ray, Color color)
        {
            Debug.DrawRay(ray.origin, ray.direction, color);
        }

        /// <summary>
        /// Draws a line from ray properties in world coordinates.
        /// </summary>
        /// <param name="ray">Ray to draw.</param>
        public static void DrawRay(Ray ray)
        {
            Debug.DrawRay(ray.origin, ray.direction);
        }

        /// <summary>
        /// Draws hit normal from contact point.
        /// </summary>
        /// <param name="hit">RaycastHit to draw.</param>
        /// <param name="color">Color of the drawn line.</param>
        /// <param name="duration">How long the line will be visible for (in seconds).</param>
        /// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
        public static void DrawHit(RaycastHit hit, Color color, float duration, bool depthTest)
        {
            Debug.DrawRay(hit.point, hit.normal, color, duration, depthTest);
        }

        /// <summary>
        /// Draws hit normal from contact point.
        /// </summary>
        /// <param name="hit">RaycastHit to draw.</param>
        /// <param name="color">Color of the drawn line.</param>
        /// <param name="duration">How long the line will be visible for (in seconds).</param>
        public static void DrawHit(RaycastHit hit, Color color, float duration)
        {
            Debug.DrawRay(hit.point, hit.normal, color, duration);
        }

        /// <summary>
        /// Draws hit normal from contact point.
        /// </summary>
        /// <param name="hit">RaycastHit to draw.</param>
        /// <param name="color">Color of the drawn line.</param>
        public static void DrawHit(RaycastHit hit, Color color)
        {
            Debug.DrawRay(hit.point, hit.normal, color);
        }

        /// <summary>
        /// Draws hit normal from contact point.
        /// </summary>
        /// <param name="hit">RaycastHit to draw.</param>
        public static void DrawHit(RaycastHit hit)
        {
            Debug.DrawRay(hit.point, hit.normal);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Quaternion rotation, float xRadius, float yRadius, int edges, Color color)
        {
            float section = (2F * Mathf.PI) / edges;

            float angle = 0F;

            Vector3 start = new Vector2(Mathf.Sin(angle) * xRadius, Mathf.Cos(angle) * yRadius);
            Vector3 end;

            for (int i = 0; i < edges; i++)
            {
                angle += section;

                end = new Vector2(Mathf.Sin(angle) * xRadius, Mathf.Cos(angle) * yRadius);

                Debug.DrawLine(center + rotation * start, center + rotation * end, color);

                start = end;
            }
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Quaternion rotation, float xRadius, float yRadius, int edges)
        {
            DrawPolygon(center, rotation, xRadius, yRadius, edges, Color.white);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, float xRadius, float yRadius, int edges, Color color)
        {
            DrawPolygon(center, Quaternion.identity, xRadius, yRadius, edges, color);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, float xRadius, float yRadius, int edges)
        {
            DrawPolygon(center, Quaternion.identity, xRadius, yRadius, edges, Color.white);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Quaternion rotation, float radius, int edges, Color color)
        {
            DrawPolygon(center, rotation, radius, radius, edges, color);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Quaternion rotation, float radius, int edges)
        {
            DrawPolygon(center, rotation, radius, radius, edges, Color.white);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, float radius, int edges, Color color)
        {
            DrawPolygon(center, Quaternion.identity, radius, radius, edges, color);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, float radius, int edges)
        {
            DrawPolygon(center, Quaternion.identity, radius, radius, edges, Color.white);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Transform transform, float xRadius, float yRadius, int edges, Color color)
        {
            DrawPolygon(transform.position, transform.rotation, xRadius, yRadius, edges, color);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Transform transform, float xRadius, float yRadius, int edges)
        {
            DrawPolygon(transform.position, transform.rotation, xRadius, yRadius, edges, Color.white);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Transform transform, float radius, int edges, Color color)
        {
            DrawPolygon(transform.position, transform.rotation, radius, radius, edges, color);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Transform transform, float radius, int edges)
        {
            DrawPolygon(transform.position, transform.rotation, radius, radius, edges, Color.white);
        }

        public static void DrawElipse(Vector3 center, Quaternion rotation, float xRadius, float yRadius, Color color)
        {
            DrawPolygon(center, rotation, xRadius, yRadius, 90, color);
        }

        public static void DrawElipse(Vector3 center, Quaternion rotation, float xRadius, float yRadius)
        {
            DrawElipse(center, rotation, xRadius, yRadius, Color.white);
        }

        public static void DrawElipse(Vector3 center, Vector3 axis, float xRadius, float yRadius, Color color)
        {
            DrawElipse(center, Quaternion.LookRotation(axis), xRadius, yRadius, color);
        }

        public static void DrawElipse(Vector3 center, Vector3 axis, float xRadius, float yRadius)
        {
            DrawElipse(center, Quaternion.LookRotation(axis), xRadius, yRadius);
        }

        public static void DrawElipse(Vector3 center, float xRadius, float yRadius, Color color)
        {
            DrawElipse(center, Quaternion.identity, xRadius, yRadius, color);
        }

        public static void DrawElipse(Vector3 center, float xRadius, float yRadius)
        {
            DrawElipse(center, Quaternion.identity, xRadius, yRadius, Color.white);
        }

        public static void DrawElipse(Transform transform, float xRadius, float yRadius, Color color)
        {
            DrawElipse(transform.position, transform.rotation, xRadius, yRadius, color);
        }

        public static void DrawElipse(Transform transform, float xRadius, float yRadius)
        {
            DrawElipse(transform.position, transform.rotation, xRadius, yRadius, Color.white);
        }


        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Vector3 axis, float xRadius, float yRadius, int edges, Color color)
        {
            DrawPolygon(center, Quaternion.LookRotation(axis), xRadius, yRadius, edges, color);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Vector3 axis, float xRadius, float yRadius, int edges)
        {
            DrawPolygon(center, Quaternion.LookRotation(axis), xRadius, yRadius, edges, Color.white);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Vector3 axis, float radius, int edges, Color color)
        {
            DrawPolygon(center, Quaternion.LookRotation(axis), radius, radius, edges, color);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Vector3 axis, float radius, int edges)
        {
            DrawPolygon(center, Quaternion.LookRotation(axis), radius, radius, edges, Color.white);
        }

        /// <summary>
        /// Draws a solid sphere with center and radius.
        /// </summary>
        public static void DrawSphere(Vector3 center, float radius, Color color, float duration, bool depthTest)
        {
            DrawElipse(center, radius, radius, color, duration, depthTest);
        }

        public static void DrawElipse(Vector3 center, float xRadius, float yRadius, Color color, float duration, bool depthTest)
        {
            float section = (2F * Mathf.PI) / drawPrecision;

            float angle = 0F;

            float startX = Mathf.Sin(angle) * xRadius;
            float startY = Mathf.Cos(angle) * yRadius;

            for (int i = 0; i < drawPrecision; i++)
            {
                angle += section;

                float endX = Mathf.Sin(angle) * xRadius;
                float endY = Mathf.Cos(angle) * yRadius;

                //XY
                Debug.DrawLine(center + new Vector3(startX, startY, 0F), center + new Vector3(endX, endY, 0F), color, duration, depthTest);
                Debug.DrawLine(center + new Vector3(startX, -startY, 0F), center + new Vector3(endX, -endY, 0F), color, duration, depthTest);

                //YZ
                Debug.DrawLine(center + new Vector3(0F, startY, startX), center + new Vector3(0F, endY, endX), color, duration, depthTest);
                Debug.DrawLine(center + new Vector3(0F, -startY, startX), center + new Vector3(0F, -endY, endX), color, duration, depthTest);

                //ZX
                Debug.DrawLine(center + new Vector3(startX, 0F, startY), center + new Vector3(endX, 0F, endY), color, duration, depthTest);
                Debug.DrawLine(center + new Vector3(startX, 0F, -startY), center + new Vector3(endX, 0F, -endY), color, duration, depthTest);

                startX = endX;
                startY = endY;
            }
        }
    }
}