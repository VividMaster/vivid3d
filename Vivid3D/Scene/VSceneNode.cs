using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
using OpenTK;
namespace Vivid.Scene
{
    public enum Space
    {
        Local,World
    }
    public class VSceneNode
    {
        public string Name = "";
        public Vector3 LocalPos = Vector3.Zero;
        public Vector3 LocalScale = Vector3.One;
        public Matrix4 LocalTurn = Matrix4.Identity;
        public Vector3 WorldPos
        {
            get
            {
                var p = Vector3.Zero;
                if (Top != null)
                {
                    p = Top.WorldPos;
                }
                p = p + LocalPos;
                return p;
            }
        }
        public Matrix4 World
        {
            get
            {
                Matrix4 r = Matrix4.Identity;
                if (Top != null)
                {
                    r = Top.World * r;
                }
                r = LocalTurn * r;

       
                return r;
            }
        }
   
        public VSceneNode Top = null;
        public List<VSceneNode> Sub = new List<VSceneNode>();
        public VInfoMap<string, object> Links = new VInfoMap<string, object>();
        public VSceneNode()
        {
            Init();
        }
        public virtual void Init()
        {

        }
        public virtual void AddLink(string name,object obj)
        {
            Links.Add(name, obj);
        }
        public void Pos(Vector3 p, Space s)
        {
            if (s == Space.Local)
            {
                LocalPos = p;
            }
        }
        public void Rot(Vector3 r,Space s)
        {
            if (s == Space.Local)
            {
                LocalTurn = Matrix4.RotateY(MathHelper.DegreesToRadians(r.Y)) * Matrix4.RotateX(MathHelper.DegreesToRadians(r.X)) * Matrix4.RotateZ(MathHelper.DegreesToRadians(r.Z));
            }
        }
        public void LookAt(Vector3 t)
        {
            LocalTurn = Matrix4.LookAt(WorldPos, t, Vector3.UnitY);
        }
        public void Move(Vector3 v,Space s)
        {
            if(s==Space.Local)
            {
                var nv = Vector3.TransformPosition(v, LocalTurn);
                LocalPos = LocalPos + nv;
            }
        }
        public virtual void Present(VCam c)
        {

        }
    }
}

