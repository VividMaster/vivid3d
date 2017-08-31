﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using FreeImageAPI;
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
        public VTex2D(string path,LoadMethod lm)
        {
            GL.ActiveTexture(TextureUnit.Texture0);
            Path = path;
            if (!FreeImage.IsAvailable())
            {
                Console.WriteLine("FreeImage.dll seems to be missing. Aborting.");
                return;
            }
            if (lm==LoadMethod.Single)
            {
                // Check if FreeImage.dll is available (can be in %path%).
                
               
               
                FREE_IMAGE_FORMAT ff = FREE_IMAGE_FORMAT.FIF_UNKNOWN;
                string ext = new FileInfo(path).Extension;
                ext = ext.ToLower();
                FREE_IMAGE_LOAD_FLAGS lf = FREE_IMAGE_LOAD_FLAGS.DEFAULT;
                switch(ext)
                {
                    case ".bmp":
                        ff = FREE_IMAGE_FORMAT.FIF_BMP;
                        break;
                    case ".tga":
                        ff = FREE_IMAGE_FORMAT.FIF_TARGA;
                        break;
                    case ".png":
                        ff = FREE_IMAGE_FORMAT.FIF_PNG;
                        break;
                    case ".jpg":
                        ff = FREE_IMAGE_FORMAT.FIF_JPEG;
                        break;
                }
                TexData = FreeImage.LoadBitmap(path, lf, ref ff);
                

                //TexData = new Bitmap(path);
                W = TexData.Width;
                H = TexData.Height;
                D = 1;
                Loaded = true;
                SetPix();
                BindData();

            } else
            {
                LoadThread = new Thread(new ThreadStart(T_LoadTex));
                LoadThread.Start();
            }
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
            FREE_IMAGE_FORMAT ff = FREE_IMAGE_FORMAT.FIF_UNKNOWN;
            string ext = new FileInfo(Path).Extension;
            ext = ext.ToLower();
            FREE_IMAGE_LOAD_FLAGS lf = FREE_IMAGE_LOAD_FLAGS.DEFAULT;
            switch (ext)
            {
                case ".bmp":
                    ff = FREE_IMAGE_FORMAT.FIF_BMP;
                    break;
                case ".tga":
                    ff = FREE_IMAGE_FORMAT.FIF_TARGA;
                    break;
                case ".png":
                    ff = FREE_IMAGE_FORMAT.FIF_PNG;
                    break;
                case ".jpg":
                    ff = FREE_IMAGE_FORMAT.FIF_JPEG;
                    break;
            }
            TexData = FreeImage.LoadBitmap(Path, lf, ref ff);

            W = TexData.Width;
            H = TexData.Height;
            D = 1;
            SetPix();
            Loaded = true;
        }
    }
}
