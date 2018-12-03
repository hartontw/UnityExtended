using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// An extended version of UnityEngine.Gizmos
    /// </summary>
    public static class HGizmos
    {
#region 2D

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Quaternion rotation, float xRadius, float yRadius, int edges)
        {
            float section = (2F * Mathf.PI) / edges;

            float angle = 0F;

            Vector3 start = new Vector2(Mathf.Sin(angle) * xRadius, Mathf.Cos(angle) * yRadius);
            Vector3 end;

            for (int i = 0; i < edges; i++)
            {
                angle += section;

                end = new Vector2(Mathf.Sin(angle) * xRadius, Mathf.Cos(angle) * yRadius);

                Gizmos.DrawLine(center + rotation * start, center + rotation * end);

                start = end;
            }
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Quaternion rotation, float xRadius, float yRadius, int edges, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawPolygon(center, rotation, xRadius, yRadius, edges);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, Quaternion rotation, float radius, int edges)
        {
            DrawPolygon(center, rotation, radius, radius, edges);
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
        public static void DrawPolygon(Vector3 center, Vector3 axis, float radius, int edges)
        {
            DrawPolygon(center, Quaternion.LookRotation(axis), radius, radius, edges);
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
        public static void DrawPolygon(Transform transform, float radius, int edges)
        {
            DrawPolygon(transform.position, transform.rotation, radius, radius, edges);
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
        public static void DrawPolygon(Vector3 center, float radius, int edges)
        {
            DrawPolygon(center, Quaternion.identity, radius, radius, edges);
        }

        /// <summary>
        /// Draws a regular polygon given radius and edges.
        /// </summary>
        public static void DrawPolygon(Vector3 center, float radius, int edges, Color color)
        {
            DrawPolygon(center, Quaternion.identity, radius, radius, edges, color);
        }

        /// <summary>
        /// Draws an elipse with given rotation.
        /// </summary>
        public static void DrawElipse(Vector3 center, Quaternion rotation, float xRadius, float yRadius)
        {
            DrawPolygon(center, rotation, xRadius, yRadius, 90);
        }

        /// <summary>
        /// Draws an elipse with given rotation
        /// </summary>
        public static void DrawElipse(Vector3 center, Quaternion rotation, float xRadius, float yRadius, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawElipse(center, rotation, xRadius, yRadius);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws an elipse around given axis.
        /// </summary>
        public static void DrawElipse(Vector3 center, Vector3 axis, float xRadius, float yRadius)
        {
            DrawElipse(center, Quaternion.LookRotation(axis), xRadius, yRadius);
        }

        /// <summary>
        /// Draws an elipse around given axis.
        /// </summary>
        public static void DrawElipse(Vector3 center, Vector3 axis, float xRadius, float yRadius, Color color)
        {
            DrawElipse(center, Quaternion.LookRotation(axis), xRadius, yRadius, color);
        }

        /// <summary>
        /// Draws an elipse.
        /// </summary>
        public static void DrawElipse(Vector3 center, float xRadius, float yRadius)
        {
            DrawElipse(center, Quaternion.identity, xRadius, yRadius);
        }

        /// <summary>
        /// Draws an elipse.
        /// </summary>
        public static void DrawElipse(Vector3 center, float xRadius, float yRadius, Color color)
        {
            DrawElipse(center, Quaternion.identity, xRadius, yRadius, color);
        }

        /// <summary>
        /// Draws an elipse relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawElipse(Transform transform, float xRadius, float yRadius)
        {
            DrawElipse(transform.position, transform.rotation, xRadius, yRadius);
        }

        /// <summary>
        /// Draws an elipse relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawElipse(Transform transform, float xRadius, float yRadius, Color color)
        {
            DrawElipse(transform.position, transform.rotation, xRadius, yRadius, color);
        }

        /// <summary>
        /// Draws a circle with given rotation.
        /// </summary>
        public static void DrawCircle(Vector3 center, Quaternion rotation, float radius)
        {
            DrawElipse(center, rotation, radius, radius);
        }

        /// <summary>
        /// Draws a circle with given rotation.
        /// </summary>
        public static void DrawCircle(Vector3 center, Quaternion rotation, float radius, Color color)
        {
            DrawElipse(center, rotation, radius, radius, color);
        }

        /// <summary>
        /// Draws a circle around given axis.
        /// </summary>
        public static void DrawCircle(Vector3 center, Vector3 axis, float radius)
        {
            DrawElipse(center, Quaternion.LookRotation(axis), radius, radius);
        }

        /// <summary>
        /// Draws a circle around given axis.
        /// </summary>
        public static void DrawCircle(Vector3 center, Vector3 axis, float radius, Color color)
        {
            DrawElipse(center, Quaternion.LookRotation(axis), radius, radius, color);
        }

        /// <summary>
        /// Draws a circle.
        /// </summary>
        public static void DrawCircle(Vector3 center, float radius)
        {
            DrawElipse(center, Quaternion.identity, radius, radius);
        }

        /// <summary>
        /// Draws a circle.
        /// </summary>
        public static void DrawCircle(Vector3 center, float radius, Color color)
        {
            DrawElipse(center, Quaternion.identity, radius, radius, color);
        }

        /// <summary>
        /// Draws a circle relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawCircle(Transform transform, float radius)
        {
            DrawElipse(transform.position, transform.rotation, radius, radius);
        }

        /// <summary>
        /// Draws a circle relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawCircle(Transform transform, float radius, Color color)
        {
            DrawElipse(transform.position, transform.rotation, radius, radius, color);
        }

        /// <summary>
        /// Draws a rectangle with given rotation and size.
        /// </summary>
        public static void DrawRectangle(Vector3 center, Quaternion rotation, Vector2 size)
        {
            Vector2 extends = size * 0.5f;

            Vector3 ld = center + rotation * new Vector3(-extends.x, -extends.y);
            Vector3 lu = center + rotation * new Vector3(-extends.x, extends.y);
            Vector3 rd = center + rotation * new Vector3(extends.x, -extends.y);
            Vector3 ru = center + rotation * new Vector3(extends.x, extends.y);

            Gizmos.DrawLine(ld, lu);
            Gizmos.DrawLine(lu, ru);
            Gizmos.DrawLine(ru, rd);
            Gizmos.DrawLine(rd, ld);
        }

        /// <summary>
        /// Draws a rectangle with given rotation and size.
        /// </summary>
        public static void DrawRectangle(Vector3 center, Quaternion rotation, Vector2 size, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawRectangle(center, rotation, size);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a rectangle around given axis.
        /// </summary>
        public static void DrawRectangle(Vector3 center, Vector3 axis, Vector2 size)
        {
            DrawRectangle(center, Quaternion.LookRotation(axis), size);
        }

        /// <summary>
        /// Draws a square around given axis.
        /// </summary>
        public static void DrawRectangle(Vector3 center, Vector3 axis, Vector2 size, Color color)
        {
            DrawRectangle(center, Quaternion.LookRotation(axis), size, color);
        }

        /// <summary>
        /// Draws a square relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawRectangle(Transform transform, Vector2 size)
        {
            DrawRectangle(transform.position, transform.rotation, size);
        }

        /// <summary>
        /// Draws a square relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawRectangle(Transform transform, Vector2 size, Color color)
        {
            DrawRectangle(transform.position, transform.rotation, size, color);
        }

        /// <summary>
        /// Draws a square with given rotation.
        /// </summary>
        public static void DrawSquare(Vector3 center, Quaternion rotation, float size)
        {
            DrawRectangle(center, rotation, new Vector2(size, size));
        }

        /// <summary>
        /// Draws a square with given rotation.
        /// </summary>
        public static void DrawSquare(Vector3 center, Quaternion rotation, float size, Color color)
        {
            DrawRectangle(center, rotation, new Vector2(size, size), color);
        }

        /// <summary>
        /// Draws a square around given axis.
        /// </summary>
        public static void DrawSquare(Vector3 center, Vector3 axis, float size)
        {
            DrawRectangle(center, Quaternion.LookRotation(axis), new Vector2(size, size));
        }

        /// <summary>
        /// Draws a square around given axis.
        /// </summary>
        public static void DrawSquare(Vector3 center, Vector3 axis, float size, Color color)
        {
            DrawRectangle(center, Quaternion.LookRotation(axis), new Vector2(size, size), color);
        }

        /// <summary>
        /// Draws a square relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawSquare(Transform transform, float size)
        {
            DrawRectangle(transform.position, transform.rotation, new Vector2(size, size));
        }

        /// <summary>
        /// Draws a square relative to given <see cref="Transform"/>.
        /// </summary>
        public static void DrawSquare(Transform transform, float size, Color color)
        {
            DrawRectangle(transform.position, transform.rotation, new Vector2(size, size), color);
        }

        /// <summary>
        /// Draws the given <see cref="CircleCollider2D"/>.
        /// </summary>
        public static void DrawCircleCollider2D(CircleCollider2D collider)
        {
            DrawElipse(collider.bounds.center, collider.radius, collider.radius, Color.green);
        }

        /// <summary>
        /// Draws the given <see cref="BoxCollider2D"/>.
        /// </summary>
        public static void DrawBoxCollider2D(BoxCollider2D collider)
        {
            Vector3 center = collider.bounds.center;
            Quaternion rotation = collider.transform.rotation;

            Vector2 extends = collider.size * 0.5f;

            Vector3 ld = center + rotation * new Vector3(-extends.x, -extends.y);
            Vector3 lu = center + rotation * new Vector3(-extends.x, extends.y);
            Vector3 rd = center + rotation * new Vector3(extends.x, -extends.y);
            Vector3 ru = center + rotation * new Vector3(extends.x, extends.y);

            ld.z = center.z; lu.z = center.z; rd.z = center.z; ru.z = center.z;

            Color gizmosColor = Gizmos.color;
            Gizmos.color = Color.green;

            Gizmos.DrawLine(ld, lu);
            Gizmos.DrawLine(lu, ru);
            Gizmos.DrawLine(ru, rd);
            Gizmos.DrawLine(rd, ld);

            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws the given <see cref="EdgeCollider2D"/>.
        /// </summary>
        public static void DrawEdgeCollider2D(EdgeCollider2D collider)
        {
            if (collider.pointCount > 0)
            {
                Color gizmosColor = Gizmos.color;
                Gizmos.color = Color.green;

                Vector3 start = collider.transform.position + collider.transform.rotation * (collider.offset + collider.points[0]); start.z = collider.bounds.center.z;
                Vector3 end;

                for (int i = 1; i < collider.points.Length; i++)
                {
                    end = collider.transform.position + collider.transform.rotation * (collider.offset + collider.points[i]); end.z = collider.bounds.center.z;
                    Gizmos.DrawLine(start, end);
                    start = end;
                }

                Gizmos.color = gizmosColor;
            }
        }

        /// <summary>
        /// Draws the given <see cref="CapsuleCollider2D"/>.
        /// TODO: Not reliable. Unifinished.
        /// </summary>
        public static void DrawCapsuleCollider2D(CapsuleCollider2D collider)
        {
            switch (collider.direction)
            {
                case CapsuleDirection2D.Horizontal:
                    float radius = collider.size.y * 0.5f;

                    if (collider.size.y < collider.size.x)
                    {
                        float section = (2F * Mathf.PI) / 90;

                        float angle = 0F;

                        Vector3 center = collider.bounds.center + collider.transform.right * (collider.size.x * 0.5f - radius);

                        Vector3 start = new Vector2(Mathf.Sin(angle) * radius, Mathf.Cos(angle) * radius);
                        Vector3 end;

                        for (int i = 0; i < 45; i++)
                        {
                            angle += section;

                            end = new Vector2(Mathf.Sin(angle) * radius, Mathf.Cos(angle) * radius);

                            Gizmos.DrawLine(center + collider.transform.rotation * start, center + collider.transform.rotation * end);

                            start = end;
                        }
                    }
                    else DrawCircle(collider.bounds.center, collider.transform.rotation, collider.size.y, Color.green);
                    break;
            }
        }

        /// <summary>
        /// Draws the given <see cref="PolygonCollider2D"/>.
        /// TODO: Not reliable. Unifinished.
        /// </summary>
        public static void DrawPolygonCollider2D(PolygonCollider2D collider)
        {
            if (collider.pathCount > 0)
            {
                Vector2[] path = collider.GetPath(0);

                if (path.Length > 0)
                {
                    Color gizmosColor = Gizmos.color;
                    Gizmos.color = Color.green;

                    Vector3 start = collider.bounds.center + collider.transform.rotation * collider.points[0]; start.z = collider.bounds.center.z;
                    Vector3 end;

                    for (int i = 1; i < collider.points.Length; i++)
                    {
                        end = collider.bounds.center + collider.transform.rotation * collider.points[i]; end.z = collider.bounds.center.z;
                        Gizmos.DrawLine(start, end);
                        start = end;
                    }

                    end = collider.bounds.center + collider.transform.rotation * collider.points[0]; end.z = collider.bounds.center.z;
                    Gizmos.DrawLine(start, end);

                    Gizmos.color = gizmosColor;
                }
            }
        }

#endregion

#region 3D
        /// <summary>
        /// Draws a solid sphere with center and radius.
        /// </summary>
        public static void DrawSphere(Vector3 center, float radius, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawSphere(center, radius);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a solid sphere with center and radius.
        /// </summary>
        public static void DrawSphere(Vector3 center, float radius)
        {
            Gizmos.DrawSphere(center, radius);
        }

        /// <summary>
        /// Draws a wireframe sphere with center and radius.
        /// </summary>
        public static void DrawWireSphere(Vector3 center, float radius, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawWireSphere(center, radius);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a wireframe sphere with center and radius.
        /// </summary>
        public static void DrawWireSphere(Vector3 center, float radius)
        {
            Gizmos.DrawWireSphere(center, radius);
        }

        /// <summary>
        /// Draws a solid box with center, rotation and size.
        /// </summary>
        public static void DrawCube(Vector3 center, Quaternion rotation, Vector3 size)
        {
            Matrix4x4 matrix = Gizmos.matrix;
            Gizmos.matrix = Matrix4x4.TRS(center, rotation, size);
            Gizmos.DrawCube(Vector3.zero, Vector3.one);
            Gizmos.matrix = matrix;
        }

        /// <summary>
        /// Draws a solid box with center, rotation and size.
        /// </summary>
        public static void DrawCube(Vector3 center, Quaternion rotation, Vector3 size, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawCube(center, rotation, size);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a solid box with center and size.
        /// </summary>
        public static void DrawCube(Vector3 center, Vector3 size, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawCube(center, size);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a solid box with center and size.
        /// </summary>
        public static void DrawCube(Vector3 center, Vector3 size)
        {
            Gizmos.DrawCube(center, size);
        }

        /// <summary>
        /// Draws a solid box given a <see cref="Transform"/>.
        /// </summary>
        public static void DrawCube(Transform transform)
        {
            DrawCube(transform.position, transform.rotation, transform.lossyScale);
        }

        /// <summary>
        /// Draws a solid box given a <see cref="Transform"/>.
        /// </summary>
        public static void DrawCube(Transform transform, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawCube(transform);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draw a wireframe box with center, rotation and size.
        /// </summary>
        public static void DrawWireCube(Vector3 center, Quaternion rotation, Vector3 size)
        {
            Matrix4x4 matrix = Gizmos.matrix;
            Gizmos.matrix = Matrix4x4.TRS(center, rotation, size);
            Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
            Gizmos.matrix = matrix;
        }

        /// <summary>
        /// Draws a wireframe box with center, rotation and size.
        /// </summary>
        public static void DrawWireCube(Vector3 center, Quaternion rotation, Vector3 size, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawWireCube(center, rotation, size);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draw a wireframe box with center and size.
        /// </summary>
        public static void DrawWireCube(Vector3 center, Vector3 size, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawWireCube(center, size);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draw a wireframe box with center and size.
        /// </summary>
        public static void DrawWireCube(Vector3 center, Vector3 size)
        {
            Gizmos.DrawWireCube(center, size);
        }

        /// <summary>
        /// Draws a wireframe box given a <see cref="Transform"/>.
        /// </summary>
        public static void DrawWireCube(Transform transform)
        {
            DrawWireCube(transform.position, transform.rotation, transform.lossyScale);
        }

        /// <summary>
        /// Draws a wireframe box given a <see cref="Transform"/>.
        /// </summary>
        public static void DrawWireCube(Transform transform, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawWireCube(transform);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws the given <see cref="Bounds"/>.
        /// </summary>
        public static void DrawBounds(Bounds bounds)
        {
            DrawBounds(Vector3.zero, bounds);
        }

        /// <summary>
        /// Draws the given <see cref="Bounds"/>.
        /// </summary>
        public static void DrawBounds(Vector3 start, Bounds bounds)
        {
            DrawWireCube(start + bounds.center, bounds.size);
        }

        /// <summary>
        /// Draws the given <see cref="Bounds"/>.
        /// </summary>
        public static void DrawBounds(Bounds bounds, Color color)
        {
            DrawBounds(Vector3.zero, bounds, color);
        }

        /// <summary>
        /// Draws the given <see cref="Bounds"/>.
        /// </summary>
        public static void DrawBounds(Vector3 start, Bounds bounds, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            DrawBounds(start, bounds);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draw a gizmo to given <see cref="Camera"/>.
        /// </summary>
        public static void DrawCamera(Camera camera, Color color, float max = 0F)
        {
            Color gizmosColor = Gizmos.color;
            Matrix4x4 gizmosMatrix = Gizmos.matrix;

            float far = camera.farClipPlane;
            float near = camera.nearClipPlane;

            if (max > 0F)
            {
                far = Mathf.Min(far, max);
                far = Mathf.Max(far, near);
            }

            Gizmos.color = color;
            Gizmos.matrix = Matrix4x4.TRS(camera.transform.position, camera.transform.rotation, Vector3.one);
            if (camera.orthographic)
            {
                float center = (near + far) * 0.5f;
                Gizmos.DrawWireCube(new Vector3(0, 0, center), new Vector3(camera.orthographicSize * 2F * camera.aspect, camera.orthographicSize * 2F, max));
            }
            else Gizmos.DrawFrustum(Vector3.zero, camera.fieldOfView, far, near, camera.aspect);

            Gizmos.color = gizmosColor;
            Gizmos.matrix = gizmosMatrix;
        }

        /// <summary>
        /// Draw a gizmo to given camera.
        /// </summary>
        public static void DrawCamera(Camera camera, float max = 0F)
        {
            DrawCamera(camera, Color.white, max);
        }

        /// <summary>
        /// Draws a wireframe sphere given a <see cref="SphereCollider"/>.
        /// </summary>
        public static void DrawSphereCollider(SphereCollider sphere)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = Color.green;

            Matrix4x4 matrix = Gizmos.matrix;
            Gizmos.matrix = Matrix4x4.TRS(Vector3.zero, sphere.transform.rotation, Vector3.one);

            //Gizmos.DrawWireSphere(sphere.bounds.center, sphere.radius);
            Handles.DrawWireDisc(sphere.bounds.center, Vector3.right, sphere.radius);

            Gizmos.matrix = matrix;

            DrawCircle(sphere.bounds.center, Quaternion.identity, sphere.radius);

            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a wireframe box given a <see cref="BoxCollider"/>.
        /// </summary>
        public static void DrawBoxCollider(BoxCollider box, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawWireCube(box.bounds.center, box.size);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a wireframe box given a <see cref="BoxCollider"/>.
        /// </summary>
        public static void DrawBoxCollider(BoxCollider box)
        {
            DrawBoxCollider(box, Color.green);
        }

        /// <summary>
        /// Draws a wireframe capsule given a <see cref="CapsuleCollider"/>.
        /// </summary>
        public static void DrawCapsuleCollider(CapsuleCollider capsule, Color color)
        {
            Vector3 direction = Vector3.zero;
            switch (capsule.direction)
            {
                case 0: direction = Vector3.right; break;
                case 1: direction = Vector3.up; break;
                case 2: direction = Vector3.forward; break;
            }
            direction *= capsule.height * 0.5f;
            Vector3 center = capsule.bounds.center;
            DebugExtension.DrawCapsule(center - direction, center + direction, color, capsule.radius);
        }

        /// <summary>
        /// Draws a wireframe capsule given a <see cref="CapsuleCollider"/>.
        /// </summary>
        public static void DrawCapsuleCollider(CapsuleCollider capsule)
        {
            DrawCapsuleCollider(capsule, Color.green);
        }

        /// <summary>
        /// Draws a mesh given a <see cref="MeshCollider"/>.
        /// </summary>
        public static void DrawMeshCollider(MeshCollider mesh, Color color)
        {
            Color gizmosColor = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawWireMesh(mesh.sharedMesh, mesh.bounds.center, mesh.transform.rotation);
            Gizmos.color = gizmosColor;
        }

        /// <summary>
        /// Draws a mesh given a <see cref="MeshCollider"/>.
        /// </summary>
        public static void DrawMeshCollider(MeshCollider mesh)
        {
            DrawMeshCollider(mesh, Color.green);
        }

        /// <summary>
        /// Draws a terrain mesh given a <see cref="TerrainCollider"/>.
        /// </summary>
        public static void DrawTerrainCollider(TerrainCollider terrain, Color color)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a terrain mesh given a <see cref="TerrainCollider"/>.
        /// </summary>
        public static void DrawTerrainCollider(TerrainCollider terrain)
        {
            DrawTerrainCollider(terrain, Color.green);
        }

        /// <summary>
        /// Draws a wheel mesh given a <see cref="WheelCollider"/>.
        /// </summary>
        public static void DrawWheelCollider(WheelCollider wheel, Color color)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a wheel mesh given a <see cref="WheelCollider"/>.
        /// </summary>
        public static void DrawWheelCollider(WheelCollider wheel)
        {
            DrawWheelCollider(wheel, Color.green);
        }

#endregion
    }
}