using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
namespace Vivid.Data
{
    public class VMesh
    {
        public string Name = "NoName";
        public VVertex3D Data = null;
        public uint[] Indices = null;
        public int NumVertices
        {
            get
            {
                return Data.Vertices;
            }
        }
        public int NumIndices
        {
            get
            {
                return Indices.Length;
            }
        }
        public VMesh(int indices,int vertices)
        {
            Data = new VVertex3D(vertices);
            Indices = new uint[indices];
        }
        public void SetVertex(int id,Vector3 pos,Vector3 t,Vector3 b,Vector3 n,Vector2 uv)
        {
            Data.SetVertex(id, pos, t, b, n, uv);
        }
        public void SetIndex(int id,uint vertex)
        {
            Indices[id] = vertex;
        }
        public void Clean()
        {
            Data = new VVertex3D(Data.Vertices);
        }
        public float[] GetVerts()
        {
            return Data.Data;
        }
        public uint[] GetInds()
        {
            return Indices;
        }
    }
}
