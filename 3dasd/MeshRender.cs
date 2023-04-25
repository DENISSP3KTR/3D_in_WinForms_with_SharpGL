using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpGL;
using SharpGL.SceneGraph;
namespace _3dasd
{
    public class MeshRender
    {
        private List<Vertex> MeshVertexList;
        private int MeshType;
        public const int CUBE = 1,
            PYRAMID = 2,
            OCTA = 3,
            DODEK = 4,
            ICOSA = 5;
        public MeshRender(int mMeshType)
        {
            MeshType = mMeshType;
            MeshVertexList = new List<Vertex>();

            if (MeshType == CUBE)
            {
                // Перед
                MeshVertexList.Add(new Vertex(-1.0f, -1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, -1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 1.0f, 1.0f));

                // Зад
                MeshVertexList.Add(new Vertex(-1.0f, -1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, -1.0f, -1.0f));

                // Вверх
                MeshVertexList.Add(new Vertex(-1.0f, 1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 1.0f, -1.0f));

                // Вниз
                MeshVertexList.Add(new Vertex(-1.0f, -1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, -1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, -1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, -1.0f, 1.0f));

                // Право
                MeshVertexList.Add(new Vertex(1.0f, -1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, -1.0f, 1.0f));

                // Лево
                MeshVertexList.Add(new Vertex(-1.0f, -1.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, -1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 1.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 1.0f, -1.0f));
            }
            else if (MeshType == PYRAMID)
            {
                float y_cor = (float)Math.Sqrt(2);
                //Низ 1
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, -1.0f));

                //Низ 2
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 1.0f));

                //Перед 1
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.0f, y_cor, 0.0f));

                //Перед 2
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.0f, y_cor, 0.0f));

                //Зад
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(0.0f, y_cor, 0.0f));

                //Лево
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.0f, y_cor, 0.0f));

                //Право
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.0f, y_cor, 0.0f));
            }
            else if (MeshType == DODEK)
            {
                MeshVertexList.Add(new Vertex(0.0f, -0.356822f, 0.934172f));
                MeshVertexList.Add(new Vertex(0.57735f, -0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.934172f, 0.0f, 0.356822f));
                MeshVertexList.Add(new Vertex(0.57735f, 0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, 0.356822f, 0.934172f));

                MeshVertexList.Add(new Vertex(0.0f, 0.356822f, 0.934172f));
                MeshVertexList.Add(new Vertex(-0.57735f, 0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(-0.934172f, 0.0f, 0.356822f));
                MeshVertexList.Add(new Vertex(-0.57735f, -0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, -0.356822f, 0.934172f));

                MeshVertexList.Add(new Vertex(-0.356822f, 0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(-0.57735f, 0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, 0.356822f, 0.934172f));
                MeshVertexList.Add(new Vertex(0.57735f, 0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.356822f, 0.934172f, 0.0f));

                MeshVertexList.Add(new Vertex(0.356822f, -0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(0.57735f, -0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, -0.356822f, 0.934172f));
                MeshVertexList.Add(new Vertex(-0.57735f, -0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(-0.356822f, -0.934172f, 0.0f));
                //
                MeshVertexList.Add(new Vertex(0.0f, 0.356822f, -0.934172f));
                MeshVertexList.Add(new Vertex(0.57735f, 0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(0.934172f, 0.0f, -0.356822f));
                MeshVertexList.Add(new Vertex(0.57735f, -0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, -0.356822f, -0.934172f));
                //
                MeshVertexList.Add(new Vertex(0.0f, -0.356822f, -0.934172f));
                MeshVertexList.Add(new Vertex(-0.57735f, -0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(-0.934172f, 0.0f, -0.356822f));
                MeshVertexList.Add(new Vertex(-0.57735f, 0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, 0.356822f, -0.934172f));
                //
                MeshVertexList.Add(new Vertex(0.356822f, 0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(0.57735f, 0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, 0.356822f, -0.934172f));
                MeshVertexList.Add(new Vertex(-0.57735f, 0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(-0.356822f, 0.934172f, 0.0f));
                //
                MeshVertexList.Add(new Vertex(-0.356822f, -0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(-0.57735f, -0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(0.0f, -0.356822f, -0.934172f));
                MeshVertexList.Add(new Vertex(0.57735f, -0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(0.356822f, -0.934172f, 0.0f));

                MeshVertexList.Add(new Vertex(-0.57735f, -0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(-0.356822f, -0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(-0.57735f, -0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(-0.934172f, 0.0f, 0.356822f));
                MeshVertexList.Add(new Vertex(-0.934172f, 0.0f, -0.356822f));

                MeshVertexList.Add(new Vertex(-0.934172f, 0.0f, -0.356822f));
                MeshVertexList.Add(new Vertex(-0.934172f, 0.0f, 0.356822f));
                MeshVertexList.Add(new Vertex(-0.57735f, 0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(-0.356822f, 0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(-0.57735f, 0.57735f, -0.57735f));

                MeshVertexList.Add(new Vertex(0.57735f, 0.57735f, -0.57735f));
                MeshVertexList.Add(new Vertex(0.356822f, 0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(0.57735f, 0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.934172f, 0.0f, 0.356822f));
                MeshVertexList.Add(new Vertex(0.934172f, 0.0f, -0.356822f));

                MeshVertexList.Add(new Vertex(0.934172f, 0.0f, -0.356822f));
                MeshVertexList.Add(new Vertex(0.934172f, 0.0f, 0.356822f));
                MeshVertexList.Add(new Vertex(0.57735f, -0.57735f, 0.57735f));
                MeshVertexList.Add(new Vertex(0.356822f, -0.934172f, 0.0f));
                MeshVertexList.Add(new Vertex(0.57735f, -0.57735f, -0.57735f));
            }
            else if (MeshType == OCTA)
            {
                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 0.0f));
                MeshVertexList.Add(new Vertex(0.0f, 1.0f, 0.0f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.0f, 1.0f, 0.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 0.0f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 0.0f));
                MeshVertexList.Add(new Vertex(0.0f, -1.0f, 0.0f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.0f, -1.0f, 0.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 0.0f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 0.0f));
                MeshVertexList.Add(new Vertex(0.0f, 1.0f, 0.0f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(0.0f, 1.0f, 0.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 0.0f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-1.0f, 0.0f, 0.0f));
                MeshVertexList.Add(new Vertex(0.0f, -1.0f, 0.0f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(0.0f, -1.0f, 0.0f));
                MeshVertexList.Add(new Vertex(1.0f, 0.0f, 0.0f));
            }
            else if (MeshType == ICOSA)
            {
                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-0.7236f, -0.52572f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.276385f, -0.85064f, 0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.276385f, -0.85064f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.894425f, 0.0f, 0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.894425f, 0.0f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.276385f, 0.85064f, 0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(0.276385f, 0.85064f, 0.447215f));
                MeshVertexList.Add(new Vertex(-0.7236f, 0.52572f, 0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, 1.0f));
                MeshVertexList.Add(new Vertex(-0.7236f, 0.52572f, 0.447215f));
                MeshVertexList.Add(new Vertex(-0.7236f, -0.52572f, 0.447215f));
                //
                MeshVertexList.Add(new Vertex(-0.276385f, -0.85064f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.7236f, -0.52572f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.276385f, -0.85064f, 0.447215f));

                MeshVertexList.Add(new Vertex(0.7236f, -0.52572f, -0.447215f));
                MeshVertexList.Add(new Vertex(0.276385f, -0.85064f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.894425f, 0.0f, 0.447215f));

                MeshVertexList.Add(new Vertex(0.7236f, 0.52572f, -0.447215f));
                MeshVertexList.Add(new Vertex(0.894425f, 0.0f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.276385f, 0.85064f, 0.447215f));

                MeshVertexList.Add(new Vertex(-0.276385f, 0.85064f, -0.447215f));
                MeshVertexList.Add(new Vertex(0.276385f, 0.85064f, 0.447215f));
                MeshVertexList.Add(new Vertex(-0.7236f, 0.52572f, 0.447215f));

                MeshVertexList.Add(new Vertex(-0.894425f, 0.0f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.7236f, 0.52572f, 0.447215f));
                MeshVertexList.Add(new Vertex(-0.7236f, -0.52572f, 0.447215f));
                //
                MeshVertexList.Add(new Vertex(-0.7236f, -0.52572f, 0.447215f));
                MeshVertexList.Add(new Vertex(-0.894425f, 0.0f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.276385f, -0.85064f, -0.447215f));

                MeshVertexList.Add(new Vertex(0.276385f, -0.85064f, 0.447215f));
                MeshVertexList.Add(new Vertex(-0.276385f, -0.85064f, -0.447215f));
                MeshVertexList.Add(new Vertex(0.7236f, -0.52572f, -0.447215f));

                MeshVertexList.Add(new Vertex(0.894425f, 0.0f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.7236f, -0.52572f, -0.447215f));
                MeshVertexList.Add(new Vertex(0.7236f, 0.52572f, -0.447215f));

                MeshVertexList.Add(new Vertex(0.276385f, 0.85064f, 0.447215f));
                MeshVertexList.Add(new Vertex(0.7236f, 0.52572f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.276385f, 0.85064f, -0.447215f));

                MeshVertexList.Add(new Vertex(-0.7236f, 0.52572f, 0.447215f));
                MeshVertexList.Add(new Vertex(-0.276385f, 0.85064f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.894425f, 0.0f, -0.447215f));
                //
                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-0.894425f, 0.0f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.276385f, 0.85064f, -0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-0.276385f, 0.85064f, -0.447215f));
                MeshVertexList.Add(new Vertex(0.7236f, 0.52572f, -0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(0.7236f, 0.52572f, -0.447215f));
                MeshVertexList.Add(new Vertex(0.7236f, -0.52572f, -0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(0.7236f, -0.52572f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.276385f, -0.85064f, -0.447215f));

                MeshVertexList.Add(new Vertex(0.0f, 0.0f, -1.0f));
                MeshVertexList.Add(new Vertex(-0.276385f, -0.85064f, -0.447215f));
                MeshVertexList.Add(new Vertex(-0.894425f, 0.0f, -0.447215f));
            }
        }
        public void render(OpenGL gl)
        {
            gl.Color(1.0f, 0.0f, 0.0f);

            if (MeshType == CUBE && MeshVertexList.Count >= 24)
            {
                gl.Begin(OpenGL.GL_QUADS);
                for (int i = 0; i < 6; i++) // 6 face
                {
                    gl.TexCoord(0.0f, 0.0f); gl.Vertex(MeshVertexList[i * 4]);
                    gl.TexCoord(1.0f, 0.0f); gl.Vertex(MeshVertexList[i * 4 + 1]);
                    gl.TexCoord(1.0f, 1.0f); gl.Vertex(MeshVertexList[i * 4 + 2]);
                    gl.TexCoord(0.0f, 1.0f); gl.Vertex(MeshVertexList[i * 4 + 3]);
                }

                gl.End();
                gl.Flush();
            }
            else if (MeshType == PYRAMID && MeshVertexList.Count >= 21)
            {
                gl.Begin(OpenGL.GL_TRIANGLES);
                for (int i = 0; i < 7; i++) // 6 face
                {
                    gl.TexCoord(0.0f, 0.0f); gl.Vertex(MeshVertexList[i * 3]);
                    gl.TexCoord(0.0f, 1.0f); gl.Vertex(MeshVertexList[i * 3 + 1]);
                    gl.TexCoord(1.0f, 0.0f); gl.Vertex(MeshVertexList[i * 3 + 2]);
                }

                gl.End();
                gl.Flush();
            }
            if (MeshType == DODEK && MeshVertexList.Count >= 60)
            {
                gl.Begin(OpenGL.GL_TRIANGLES);
                for (int i = 0; i < 12; i++)
                {
                    gl.TexCoord(0.0f, 0.0f); gl.Vertex(MeshVertexList[i * 5]); 
                    gl.TexCoord(1.0f, 0.0f); gl.Vertex(MeshVertexList[i * 5 + 1]);
                    gl.TexCoord(0.0f, 1.0f); gl.Vertex(MeshVertexList[i * 5 + 3]); 
                    
                    gl.TexCoord(1.0f, 0.0f); gl.Vertex(MeshVertexList[i * 5 + 1]);
                    gl.TexCoord(0.5f, 1.0f); gl.Vertex(MeshVertexList[i * 5 + 2]);
                    gl.TexCoord(0.0f, 1.0f); gl.Vertex(MeshVertexList[i * 5 + 3]);

                    gl.TexCoord(0.0f, 0.0f); gl.Vertex(MeshVertexList[i * 5]);
                    gl.TexCoord(0.0f, 1.0f); gl.Vertex(MeshVertexList[i * 5 + 3]);
                    gl.TexCoord(1.0f, 1.0f); gl.Vertex(MeshVertexList[i * 5 + 4]);
                }
                gl.End();
                gl.Flush();
            }
            if (MeshType == ICOSA && MeshVertexList.Count >= 59)
            {
                gl.Begin(OpenGL.GL_TRIANGLES);
                for (int i = 0; i < 20; i++)
                {
                    gl.TexCoord(0.0f, 0.0f); gl.Vertex(MeshVertexList[i * 3]);
                    gl.TexCoord(1.0f, 0.0f); gl.Vertex(MeshVertexList[i * 3 + 1]);
                    gl.TexCoord(0.0f, 1.0f); gl.Vertex(MeshVertexList[i * 3 + 2]);
                }
                gl.End();
                gl.Flush();
            }
            if (MeshType == OCTA && MeshVertexList.Count >= 24)
            {
                gl.Begin(OpenGL.GL_TRIANGLES);
                for (int i = 0; i < 8; i++)
                {
                    gl.TexCoord(0.0f, 0.0f); gl.Vertex(MeshVertexList[i * 3]);
                    gl.TexCoord(1.0f, 0.0f); gl.Vertex(MeshVertexList[i * 3 + 1]);
                    gl.TexCoord(0.0f, 1.0f); gl.Vertex(MeshVertexList[i * 3 + 2]);
                }
                gl.End();
                gl.Flush();
            }
        }
    }
}
