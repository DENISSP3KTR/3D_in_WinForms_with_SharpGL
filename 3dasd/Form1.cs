using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//подключение библиотек SharpGL
using SharpGL;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Cameras;
using SharpGL.Shaders;
namespace _3dasd
{
    public partial class Form1 : Form
    {
        Camera cam;

        private List<MeshRender> listShape = new List<MeshRender>();

        public Form1()
        {
            InitializeComponent();

            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;

            gl.Enable(OpenGL.GL_TEXTURE_2D);

            //Light light = new Light()
            //{
            //    On = true,
            //    Position = new Vertex(0, 0, 5),
            //    GLCode = OpenGL.GL_LIGHT0
            //};
            gl.Enable(OpenGL.GL_LIGHTING);
            float[] lightPosition = { 1.0f, 0.0f, 0.0f, 1.0f }; // координаты источника света
            float[] lightAmbient = { 0.2f, 0.2f, 0.2f, 1.0f }; // окружающая света
            float[] lightDiffuse = { 0.8f, 0.8f, 0.8f, 1.0f }; // диффузный свет
            float[] lightSpecular = { 1.0f, 1.0f, 1.0f, 1.0f }; // зеркальный свет

            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, lightPosition);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, lightAmbient);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, lightDiffuse);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, lightSpecular);
            gl.Enable(OpenGL.GL_LIGHT0);
            gl.Enable(OpenGL.GL_NORMALIZE);

            float fov = 70.0f,
                aspect = (float)openGLControl1.Width / (float)openGLControl1.Height,
                zNear = 0.1f,
                zFar = 100.0f;
            Vertex eyeVertex = new Vertex(2.0f, 2.0f, 2.0f);
            Vertex centerVertex = new Vertex(0.0f, 0.0f, 0.0f);
            Vertex upVertex = new Vertex(0.0f, 1.0f, 0.0f);

            cam = new Camera(gl, fov, aspect, zNear, zFar, eyeVertex, centerVertex, upVertex);

        }


        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);


            gl.Color(1.0f, 1.0f, 1.0f);

            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();

            cam.Look();

            gl.Disable(OpenGL.GL_TEXTURE_2D);
            Ploshadka psr = new Ploshadka(16);
            psr.render(gl);


            gl.Enable(OpenGL.GL_TEXTURE_2D);
            foreach (MeshRender mesh in listShape)
            {
                mesh.render(gl);
            }
        }

        private void openGLControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.X:
                    cam.ZoomIn();
                    break;
                case Keys.Z:
                    cam.ZoomOut();
                    break;
                case Keys.A:
                    cam.GoLeft();
                    break;
                case Keys.D:
                    cam.GoRight();
                    break;
                case Keys.W:
                    cam.GoUp();
                    break;
                case Keys.S:
                    cam.GoDown();
                    break;
                default:
                    break;
            }
            cam.Look();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listShape.Clear();
        }

        private void кубToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listShape.Clear();
            listShape.Add(new MeshRender(MeshRender.CUBE));
        }

        private void тетраэдрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listShape.Clear();
            listShape.Add(new MeshRender(MeshRender.PYRAMID));
        }
        private void додакаэдрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listShape.Clear();
            listShape.Add(new MeshRender(MeshRender.DODEK));
        }

        private void икосаэдрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listShape.Clear();
            listShape.Add(new MeshRender(MeshRender.ICOSA));
        }

        private void октаэдрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listShape.Clear();
            listShape.Add(new MeshRender(MeshRender.OCTA));
        }
    }
}
