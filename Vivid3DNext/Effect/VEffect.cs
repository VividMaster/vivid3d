using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace Vivid.Effect
{
    public class VEffect
    {
        private string _Name = "";
        private string _GShader = "";
        private string _VShader = "";
        private string _FShader = "";
        private int _Program=0;
        private int _Geo=0;
        private int _Vert=0;
        private int _Frag=0;
        public VEffect(string geo="",string vert="",string pix="")
        {
            _GShader = geo;
            _VShader = vert;
            _FShader = pix;
            InitShaders();
        }

        ~VEffect()
        {

            GL.DeleteProgram(_Program);

        }

        public bool InitShaders()
        {
            if(_GShader!="")
            {

            }
            if(_VShader!="")
            {
                _Vert = GL.CreateShader(ShaderType.VertexShader);
                GL.ShaderSource(_Vert, File.ReadAllText(@_VShader));
                GL.CompileShader(_Vert);

            }
            if(_FShader!="")
            {
                _Frag = GL.CreateShader(ShaderType.FragmentShader);
                GL.ShaderSource(_Frag, File.ReadAllText(@_FShader));
                GL.CompileShader(_Frag);
            }

            _Program = GL.CreateProgram();

            GL.AttachShader(_Program, _Vert);
            GL.AttachShader(_Program, _Frag);
            GL.LinkProgram(_Program);

            GL.DetachShader(_Program, _Vert);
            GL.DetachShader(_Program, _Frag);
            GL.DeleteShader(_Vert);
            GL.DeleteShader(_Frag);


            return true;
        }
    }
}
