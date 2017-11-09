using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace Vivid.Texture
{
    public enum LoadMethod
    {
        Single,Multi
    }
    public class VTex2D : VTexBase
    {
        public Thread LoadThread = null;
        public Mutex LoadMutex = new Mutex();
        public Bitmap TexData = null;
        public bool Loaded = false;
        public bool Binded = false;
        public byte[] pixs = null;
        public bool Alpha = false;

        public void ReadBitmap(BinaryReader r)
        {
            short bw = r.ReadInt16();
            short bh = r.ReadInt16();
            TexData = new Bitmap(bw, bh);
            pixs = r.ReadBytes(bw * bh * 4);
            W = bw;
            H = bh;
            Alpha = true;
            return;
            for(int y = 0; y < bh; y++)
            {
                for(int x = 0; x < bw; x++)
                {
                    byte[] col = r.ReadBytes(4);
                    System.Drawing.Color nc = System.Drawing.Color.FromArgb(col[3], col[0], col[1], col[2]);
                    TexData.SetPixel(x, y, nc);
                }
            }
            W = bw;
            H = bh;
        }
        public void SkipBitmap(BinaryReader r)
        {
            short bw = r.ReadInt16();
            short bh = r.ReadInt16();
            r.BaseStream.Seek(bw * bh * 4, SeekOrigin.Current);
        }
        public void SaveTex(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return;
            }
            FileStream fs = new FileStream(p, FileMode.Create, FileAccess.Write);
            BinaryWriter w = new BinaryWriter(fs);
          
            
                var sd = new Bitmap(TexData, 32, 32);
                WriteBitmap(sd,w);
                WriteBitmap(TexData,w);
          
            fs.Flush();
            fs.Close();
        }
        public void WriteBitmap(Bitmap b,BinaryWriter w)
        {
            w.Write((short)b.Width);
            w.Write((short)b.Height);
            for(int y = 0; y < b.Height; y++)
            {
                for(int x = 0; x < b.Width; x++)
                {
                    var p = b.GetPixel(x, y);
                    w.Write(p.R);
                    w.Write(p.G);
                    w.Write(p.B);
                    w.Write(p.A);
                }
            }
        }
        public VTex2D(int w,int h,bool alpha=false)
        {
            GL.ActiveTexture(TextureUnit.Texture0);
            Alpha = alpha;
            W = w;
            H = h;
            ID = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, ID);
            if(alpha)
            {
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, w, h, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
            }
            else
            {
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb, w, h, 0, PixelFormat.Rgb, PixelType.UnsignedByte, IntPtr.Zero);
            }
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
            GL.PixelStore(PixelStoreParameter.PackAlignment, 4 * 4);
           
        }
        public VTex2D(int w,int h,byte[] dat,bool alpha = true)
        {
            GL.ActiveTexture(TextureUnit.Texture0);
            Alpha = alpha;
            W = w;
            H = h;
            ID = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, ID);
            if (alpha)
            {
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, w, h, 0, PixelFormat.Rgba, PixelType.UnsignedByte, dat);
            }
            else
            {
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb, w, h, 0, PixelFormat.Rgb, PixelType.UnsignedByte, dat);
            }
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
            GL.PixelStore(PixelStoreParameter.PackAlignment, 4 * 4);
            pixs = dat;
        }
        public VTex2D(string path,LoadMethod lm)
        {
            GL.ActiveTexture(TextureUnit.Texture0);
            Path = path;
          
            if (lm==LoadMethod.Single)
            {
                // Check if FreeImage.dll is available (can be in %path%).
                bool sl = false;
                if(File.Exists(Path+".vtex"))
                {
                    FileStream fs = new FileStream(Path + ".vtex", FileMode.Open, FileAccess.Read);
                    BinaryReader r = new BinaryReader(fs);

                    SkipBitmap(r);
                    ReadBitmap(r);
                    r.Close();
                    sl = true;
                }

                if (sl == false)
                {
                    if (File.Exists(path) == false)
                    {
                        return;
                    }


                   
                        TexData = new Bitmap(path);
                    W = TexData.Width;
                    H = TexData.Height;

                }


                //TexData = new Bitmap(path);
            
                D = 1;
                Loaded = true;
                Alpha = true;
                //SetPix();
                BindData();
                if (sl == false)
                {
                    SaveTex(path + ".vtex");
                }
            } else
            {
                bool sl = false;
                if (File.Exists(Path + ".vtex"))
                {
                    
                    sl = true;
                }

                if (sl == false)
                {
                    LoadThread = new Thread(new ThreadStart(T_LoadTex));
                    LoadThread.Start();
                }
                else
                {
                    FileStream fs = new FileStream(Path + ".vtex", FileMode.Open, FileAccess.Read);
                    BinaryReader r = new BinaryReader(fs);
                    ReadBitmap(r);
                    D = 1;
                    PreLoaded = true;
                    Alpha = true;
                  //  SetPix();
                    BindData();
                    nf = fs;
                    nr = r;

                    LoadThread = new Thread(new ThreadStart(T_LoadVTex));
                    LoadThread.Start();
                }
            }
        }
        bool PreLoaded = false;
        FileStream nf;
        BinaryReader nr;
        public void T_LoadVTex()
        {
            ReadBitmap(nr);

            //W = TexData.Width;
            //H = TexData.Height;
            D = 1;
            Alpha = true;
            //SetPix();
            //SaveTex(Path + ".vtex");
            Loaded = true;
            nf.Close();
            nf = null;
            nr = null;

        }
        public override void Bind(int texu)
        {
            if(Loaded==true && Binded==false)
            {
                BindData();
                Binded = true;
            }

            GL.Enable(EnableCap.Texture2D);
            GL.ActiveTexture((TextureUnit)((int)TextureUnit.Texture0 + texu));
          //  GL.ClientActiveTexture((TextureUnit)((int)TextureUnit.Texture0 + texu));
            GL.BindTexture(TextureTarget.Texture2D, ID);
        }
        public override void Release(int texu)
        {
            GL.ActiveTexture((TextureUnit)((int)TextureUnit.Texture0 + texu));
           // GL.ClientActiveTexture((TextureUnit)((int)TextureUnit.Texture0 + texu));
            GL.BindTexture(TextureTarget.Texture2D, 0);
            GL.Disable(EnableCap.Texture2D);
        }
        public void SetPix()
        {
            pixs = new byte[W * H * 4];
            int loc = 0;
            for (int y=0;y<H;y++)
            {
                for(int x=0;x<W;x++)
                {
                    var p = TexData.GetPixel(x, y);
                    pixs[loc++] = p.R;
                    pixs[loc++] = p.G;
                    pixs[loc++] = p.B;
                    pixs[loc++] = p.A;
                  
                }
            }
        }
        public void BindData()
        {
            GL.Enable(EnableCap.Texture2D);
            ID = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, ID);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.PixelStore(PixelStoreParameter.PackAlignment, 4 * 4);
           GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, W, H, 0, PixelFormat.Rgba, PixelType.UnsignedByte, pixs);
            GL.Disable(EnableCap.Texture2D);

        }
        public void T_LoadTex()
        {
       
            TexData = new Bitmap(Path); 

            W = TexData.Width;
            H = TexData.Height;
            D = 1;
            Alpha = true;
            SetPix();
            SaveTex(Path + ".vtex");
            Loaded = true;
        }
    }
}
