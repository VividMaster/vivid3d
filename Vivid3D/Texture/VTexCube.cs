using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using System.Drawing;
namespace Vivid.Texture
{
    public class VTexCube : VTexBase
    {
        public VTexCube(int w,int h)
        {
            W = w;
            H = h;
            D = 1;
            GenMap();

        }
        public VTexCube(string path)
        {
            GenMap();
            Dat(path + "/nx.png");
            GL.TexImage2D(TextureTarget.TextureCubeMapNegativeX, 0, PixelInternalFormat.Rgba, W, H, 0, PixelFormat.Rgba, PixelType.UnsignedByte, Dat(path + "/nx.png"));
            GL.TexImage2D(TextureTarget.TextureCubeMapNegativeY, 0, PixelInternalFormat.Rgba, W, H, 0, PixelFormat.Rgba, PixelType.UnsignedByte, Dat(path + "/ny.png"));
            GL.TexImage2D(TextureTarget.TextureCubeMapNegativeZ, 0, PixelInternalFormat.Rgba, W, H, 0, PixelFormat.Rgba, PixelType.UnsignedByte, Dat(path + "/nz.png"));
            GL.TexImage2D(TextureTarget.TextureCubeMapPositiveX, 0, PixelInternalFormat.Rgba, W, H, 0, PixelFormat.Rgba, PixelType.UnsignedByte, Dat(path + "/px.png"));
            GL.TexImage2D(TextureTarget.TextureCubeMapPositiveY, 0, PixelInternalFormat.Rgba, W, H, 0, PixelFormat.Rgba, PixelType.UnsignedByte, Dat(path + "/py.png"));
            GL.TexImage2D(TextureTarget.TextureCubeMapPositiveZ, 0, PixelInternalFormat.Rgba, W, H, 0, PixelFormat.Rgba, PixelType.UnsignedByte, Dat(path + "/pz.png"));

        }
        public byte[] Dat(string pf)
        {
            var TexData = new Bitmap(pf);
            W = TexData.Width;
            H = TexData.Height;
            var pixs = new byte[W * H * 4];
            int loc = 0;
            for (int y = 0; y < H; y++)
            {
                for (int x = 0; x < W; x++)
                {
                    var p = TexData.GetPixel(x, y);
                    pixs[loc++] = p.R;
                    pixs[loc++] = p.G;
                    pixs[loc++] = p.B;
                    pixs[loc++] = p.A;

                }
            }
            return pixs;
        }
        private void GenMap()
        {
            ID = GL.GenTexture();
            GL.BindTexture(TextureTarget.TextureCubeMap, ID);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToEdge);
        }
        public override void Bind(int texu)
        {
            GL.ActiveTexture(TextureUnit.Texture0 + texu);
            GL.Enable(EnableCap.TextureCubeMap);
            GL.BindTexture(TextureTarget.TextureCubeMap, ID);
        }
        public override void Release(int texu)
        {
            GL.ActiveTexture(TextureUnit.Texture0 + texu);
            GL.BindTexture(TextureTarget.TextureCubeMap, 0);

            GL.Disable(EnableCap.TextureCubeMap);
        }
    }
}
