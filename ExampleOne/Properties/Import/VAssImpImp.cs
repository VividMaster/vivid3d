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
        public static string IPath = "";
        public override VSceneNode LoadNode(string path)
        {
            VSceneEntity root = new VSceneEntity();
            string file = path;
            var e = new Assimp.AssimpImporter();
            var c1 = new Assimp.Configs.NormalSmoothingAngleConfig(45);
            e.SetConfig(c1);
            var s = e.ImportFile(file, PostProcessSteps.CalculateTangentSpace | PostProcessSteps.GenerateSmoothNormals | PostProcessSteps.Triangulate | PostProcessSteps.GenerateNormals);
            Dictionary<string, VMesh> ml = new Dictionary<string, VMesh>();
            List<VMesh> ml2 = new List<VMesh>();
            foreach (var m in s.Meshes)
            {

                var vm = new Material.VMaterial();

                var m2 = new VMesh(m.VertexCount, m.GetIntIndices().Length);
                ml2.Add(m2);
               // ml.Add(m.Name, m2);

                m2.Mat = vm;
               // root.AddMesh(m2);
                m2.Name = m.Name;
                var mat = s.Materials[m.MaterialIndex];
                TextureSlot t1;
                if (mat.GetTextureCount(TextureType.Diffuse) > 0)
                {
                    t1 = mat.GetTextures(TextureType.Diffuse)[0];

                   
                    if(t1.FilePath!=null)
                    {
                        vm.TCol = new Texture.VTex2D(IPath+t1.FilePath, Texture.LoadMethod.Single);
                        Console.WriteLine("TexLoaded");
                    }
                        if (true)
                    {
                   
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
                    Vector3D tan, bi;
                    if (m.Tangents != null)
                    {

                        tan = m.Tangents[i];
                        bi = m.BiTangents[i];
                    }
                    else
                    {
                        tan = new Vector3D(0, 0, 0);
                        bi = new Vector3D(0, 0, 0);
                    }
                    if (t != null)
                    {
                        m2.SetVertex(i, Cv(v), Cv(tan), Cv(bi), Cv(n), Cv2(t[i]));
                    }
                    else
                    {
                        m2.SetVertex(i, Cv(v), Cv(tan), Cv(bi), Cv(n), Cv2(new Vector3D(0, 0, 0)));
                    }
                }
                int[] id = m.GetIntIndices();
                int fi = 0;
                uint[] nd = new uint[id.Length];
                for (int i = 0; i < id.Length; i++)
                {
                    nd[i] = (uint)id[i];
                }

                m2.Indices = nd;

                m2.Final();
         
            }

            ProcessNode(root, s.RootNode, ml2);
         
 
            return root as VSceneNode;
        }

        private void ProcessNode(VSceneEntity root, Assimp.Node s,List<VMesh> ml)
        {

            VSceneEntity r1 = new VSceneEntity();
            root.Sub.Add(r1);
            r1.Top = root;
            r1.Name = s.Name;


            //r1.LocalTurn = new OpenTK.Matrix4(s.Transform.A1, s.Transform.A2, s.Transform.A3, s.Transform.A4, s.Transform.B1, s.Transform.B2, s.Transform.B3, s.Transform.B4, s.Transform.C1, s.Transform.C2, s.Transform.C3, s.Transform.C4, s.Transform.D1, s.Transform.D2, s.Transform.D3, s.Transform.D4);
            r1.LocalTurn = new OpenTK.Matrix4(s.Transform.A1, s.Transform.B1, s.Transform.C1, s.Transform.D1, s.Transform.A2, s.Transform.B2, s.Transform.C2, s.Transform.D2, s.Transform.A3, s.Transform.B3, s.Transform.C3, s.Transform.D3, s.Transform.A4, s.Transform.B4, s.Transform.C4, s.Transform.D4);
            var lt = r1.LocalTurn;

            r1.LocalTurn = lt.ClearTranslation();
            r1.LocalTurn = r1.LocalTurn.ClearScale();
            r1.LocalPos = lt.ExtractTranslation();
 
            r1.LocalScale = lt.ExtractScale();
           // r1.LocalPos = new OpenTK.Vector3(r1.LocalPos.X + 100, 0, 0);
            for(int i = 0; i < s.MeshCount; i++)
            {
                r1.AddMesh(ml[s.MeshIndices[i]]);
          
            }
            if (s.HasChildren)
            {
                foreach (var pn in s.Children)
                {
             
                    ProcessNode(r1, pn, ml);
                }
            }
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
