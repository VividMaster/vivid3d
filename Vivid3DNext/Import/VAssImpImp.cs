using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Scene;
using Assimp;
using Assimp.Configs;
using Vivid.Data;
using System.IO;

namespace Vivid.Import
{
    public class VAssImpImp : VImporter
    {
        public override VSceneNode LoadNode(string path)
        {
            VSceneEntity root = new VSceneEntity();
            string file = path;
            var e = new Assimp.AssimpImporter();
            var c1 = new Assimp.Configs.NormalSmoothingAngleConfig(45);
            e.SetConfig(c1);
            var s = e.ImportFile(file, PostProcessSteps.CalculateTangentSpace | PostProcessSteps.GenerateSmoothNormals | PostProcessSteps.Triangulate);
            foreach (var m in s.Meshes)
            {

                var m2 = new VMesh(m.VertexCount, m.GetIntIndices().Length);
                root.AddMesh(m2);
                var mat = s.Materials[m.MaterialIndex];
                TextureSlot t1;
                if (mat.GetTextureCount(TextureType.Diffuse) > 0)
                {
                    t1 = mat.GetTextures(TextureType.Diffuse)[0];


                    if (true)
                    {
                        Console.WriteLine(t1.FilePath);
                        if (new FileInfo(t1.FilePath).Exists == true)
                        {
                            //  var tex = App.AppSal.CreateTex2D();
                            //  tex.Path = t1.FilePath;
                            // tex.Load();
                            //m2.DiffuseMap = tex;
                        }
                    }
                }
                for (int i = 0; i < m2.NumVertices; i++)
                {
                    var v = m.Vertices[i];
                    var n = m.Normals[i];
                    var t = m.GetTextureCoords(0);
                    var tan = m.Tangents[i];
                    var bi = m.BiTangents[i];

                    m2.SetVertex(i, Cv(v), Cv(tan), Cv(bi), Cv(n), Cv2(t[0]));

                }
                int[] id = m.GetIntIndices();
                int fi = 0;
                uint[] nd = new uint[id.Length];
                for (int i = 0; i < id.Length; i++)
                {
                    nd[i] = (uint)id[i];
                }
               
                m2.Indices = nd;



            }
         

            return root as VSceneNode;
        }
        public OpenTK.Vector2 Cv2(Assimp.Vector3D o)
        {
            return new OpenTK.Vector2(o.X, o.Y);
        }
        public OpenTK.Vector3 Cv(Assimp.Vector3D o)
        {
            return new OpenTK.Vector3(o.X, o.Y, o.Z);
        }
    }
}
