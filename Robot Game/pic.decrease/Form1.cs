using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pic.decrease
{
    public class CActor
    {
        public int X, Y, ihit = -1, W , H ;
        public List<Bitmap> imgs;
        public int iFrm = 0;
    }
    public class Cenemy
    {
        public int X, Y, ihit = -1, W, H;
        public List<Bitmap> imgs;
        public int iFrm = 0;
    }
    public class bullet
    {
        public int X, Y, ihit = -1, W, H;
        public Bitmap img;
        
    }
    public class CActor2
    {
        public int X, Y, ihit = -1, W, H;
        public Bitmap img;
    }
    public class rect
    {
        public int X, Y, dir = -1, W, H;
       
    }
    public class CLadder
    {
        public int X, Y, ihit = -1, W, H;
        public Bitmap img;
    }
    public class CLaser
    {
        public int X, Y, ihit = -1, W, H;
       
    }
    public class fly
    {
        public int X, Y, ihit = -1, W, H;
        public Bitmap img;
    }
    public partial class Form1 : Form
    {
        Bitmap off;
        Timer tt = new Timer();
        List<CActor> LActs = new List<CActor>();
        List<Cenemy> Le = new List<Cenemy>();
        List<Cenemy> Le2 = new List<Cenemy>();
        List<CActor2> LA = new List<CActor2>();
        List<bullet> Lbu = new List<bullet>();
        List<bullet> Lbue = new List<bullet>();
        List<rect> Lr = new List<rect>();
        List<CLadder> Ll = new List<CLadder>();
        List<CLaser> La = new List<CLaser>();
        List<fly> Lf = new List<fly>();
        List<bullet> Lbf = new List<bullet>();
        int YS = 0;
        int XS = 0;
        int ae = 665;
        int ae2 = 765;
        int ax = 0;
        int ay = 0;
        int cttick = 0;
        int cttick2 = 0;
        int v = 0;
        int w = 50;
        int h = 50;
        int fhit = -1;
        int f = 0;
        int cta = 0;
        int l = 11;
        int l2 = 19;
        int l3 = 27;
        int l4 = 37;
        int l5 = 41;
        int fj = 0;
        int fg = 0;
        int fb = 0;
        int fjd = 0;
        int ctj = 0;
        int flaunch = 0;
        Bitmap b;
        int fshootR = 0;
        int lshoot = 52;
        int val = 0;
        int fval = 0;
        int felev = 0;
        int froof = 0;
        int le1 = 0;
        int le2 = 0;
        int fhit1 = 0;
        int fgameover = 0;
        int fbue = 0;
        int pose = 0;
        int ctre = 50;
        int counte = 19;
        int flaser = 0;
        int af = 800;
        int posf = 0;
        int flf = 0;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            tt.Tick += Tt_Tick;
            tt.Start();

        }
   
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                f = 0;

            }
            if (e.KeyCode == Keys.Left)
            {
                f = 0;
            }
            if (e.KeyCode == Keys.Space)
            {
                fg = 1;
                fj = 0;

            }
            if (e.KeyCode == Keys.S)
            {
                fb = 0;
                fshootR = 0;

            }
            if (e.KeyCode == Keys.Down)
            {
                LActs[0].imgs[0] = new Bitmap("1.bmp");
                LActs[0].imgs[0].MakeTransparent(LActs[0].imgs[0].GetPixel(1, 1));
                LActs[0].Y--;

            }
            if (e.KeyCode == Keys.D)
            {
                flaser = 0;
            }
        }
  
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(fval==0)
            {
                val = this.Width*4;
                fval = 1;
            }
        
            if (fg == 0)
            {
                if (e.KeyCode == Keys.Right)
                {


                    if (l == 17)
                    {
                        l = 11;
                    }

                    l++;
                    //  if (LActs[0].X > Ll[1].X + Ll[1].W)
                    // {
                   


                        XS += 3;
                        LActs[0].X += 1;
                        Ll[0].X -= 9;
                        Ll[1].X -= 9;
                        Ll[2].X -= 9;
                        Lr[0].X -= 9;
                        for (int k = 0; k < Le.Count; k++)
                        {
                            Le[k].X -= 9;
                        }
                        for (int k = 0; k < Le2.Count; k++)
                        {
                            Le2[k].X -= 9;
                        }
                        for(int j=0;j<Lf.Count;j++)
                        {
                            Lf[j].X -= 9;
                        }
                        for (int j = 0; j < Lbf.Count; j++)
                        {
                           Lbf[j].X -= 9;
                        }

                    // }

                    f = 1;




                }
                if (e.KeyCode == Keys.Left)
                {



                    if (l2 == 25)
                    {
                        l2 = 19;
                    }

                    if (LActs[0].X >= 165)
                    {
                        
                        l2++;

                        XS -=3;
                        LActs[0].X -= 1;
                        Ll[0].X += 9;
                        Ll[1].X += 9;
                        Ll[2].X += 9;
                        Lr[0].X += 9;
                        for(int k=0;k<Le.Count;k++)
                        {
                            Le[k].X += 9;
                        }
                        for (int k = 0; k < Le2.Count; k++)
                        {
                            Le2[k].X -= 9;
                        }
                        for (int j = 0; j < Lf.Count; j++)
                        {
                            Lf[j].X += 9;
                        }
                        for (int j = 0; j < Lbf.Count; j++)
                        {
                            Lbf[j].X -= 9;
                        }
                    }
                    f = 2;


                }
                if (e.KeyCode == Keys.Space)
                {
                    fj = 1;

                    if (f == 0)
                    {
                        if (LActs[0].Y >= this.Height - 250)
                        {
                            LActs[0].Y -= 5;
                        }

                    }


                }


            }
            if (e.KeyCode == Keys.S)
            {
                fb = 1;
                flaunch = 1;
                if (f == 1)
                { fshootR = 1;
                    fb = 0;
                }
                f = 0;

            }
            if(e.KeyCode==Keys.Up)
            {
                if(LActs[0].X>=Ll[0].X&&LActs[0].X+LActs[0].W<=Ll[0].X+Ll[0].W)
                {
                    LActs[0].Y -= 4;

                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (LActs[0].X >= Ll[0].X && LActs[0].X + LActs[0].W <= Ll[0].X + Ll[0].W)
                {
                    LActs[0].Y += 4;

                }
                else
                {
                    LActs[0].imgs[0] = new Bitmap("79.bmp");
                    LActs[0].imgs[0].MakeTransparent(LActs[0].imgs[0].GetPixel(1, 1));
                    LActs[0].Y++;

                }
            }
            if(e.KeyCode==Keys.D)
            {
                flaser = 1;
                createlaser();
            }

        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            if (pose >= counte)
            {
                pose = 0;
            }
            if (posf == 9)
            {
                posf = 0;
            }
            if (cttick2 % 150 == 0)
            {

                flaunch = 0;
                Lbue.Clear();
                Lbu.Clear();

            }

            if (LActs[0].X >= Lf[posf].X)
            { createbulletfly(); }
                
            
      
             movebulletfly(); 
            if(flaser==1)
            {
                movelaser();
            }
            if (fgameover == 1 || ctre <= 0)
            {
                tt.Stop();
                MessageBox.Show("Game Over");
            }
            if(LActs[0].X>=Ll[0].X+Ll[0].W)
            {
                tt.Stop();
                MessageBox.Show("you win");

            }
            moveenemies();
            moveenemies2();

            if (cttick2 % 10 == 0&&counte>=0)
            {  createbulletsleft(); } 

            
            if (fbue == 1)
            { movebulletleft(); }



            movefly();

            
            moveelevator();
            if (fj == 1)
            {
                if (f == 1)
                {
                    jumpright();

                }
                if (f == 2)
                {
                    jumpleft();



                }


            }
            if(LActs[0].X>=Lr[0].X&&LActs[0].X+LActs[0].W<=Lr[0].X+Lr[0].W &&Lr[0].Y+Lr[0].H==this.Height-90&&Lr[0].Y<LActs[0].Y)
            {
              
                felev = 1;
            }
           if(LActs[0].X>=Lr[0].X&&LActs[0].X+LActs[0].W<=Ll[1].X+Ll[1].W)
            {
                froof = 1;

            }
           if(LActs[0].X<Lr[0].X|| LActs[0].X + LActs[0].W > Ll[1].X + Ll[1].W)
            {

                froof = 0;
            }
            if (LActs[0].X < Lr[0].X || LActs[0].X + LActs[0].W > Lr[0].X+Lr[0].W)
            {
                felev = 0;
            }
         
            if (felev == 1)
            {
              if(Lr[0].dir==1)
                {
                    LActs[0].Y += 2;
                }
              if(Lr[0].dir==-1)
                {
                    LActs[0].Y -= 2;
                }

            }
            if (fb == 1)
            {
                shoot();
            

            }
            if (fshootR == 1)
            { shootright(); }
            if (flaunch == 1)
            { movebulletsright(); }
            
         

            if (f == 0)
            {
                if (LActs[0].Y < this.Height - 170)
                {
                    if (cttick % 2 == 0)
                    { if (felev != 1&&froof!=1)
                        { LActs[0].Y += cttick; }
                       
                      

                    }




                }
                if (LActs[0].Y >= this.Height - 170)
                {

                    LActs[0].Y = this.Height - 170;

                    fg = 0;

                    cttick = 20;
                }

            }
            cttick++;
            cttick2++;
            pose++;
            posf++;
            DrawDubb(this.CreateGraphics());
        }
        void createbackground()
        {

            b = new Bitmap("0.bmp");
            b.MakeTransparent(b.GetPixel(1, 1));


        }
        void createbulletfly()
        {
            bullet pnn = new bullet();

            pnn.X = Lf[posf].X+10;
            pnn.Y = Lf[posf].Y+70;


            pnn.img = new Bitmap("81.bmp");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.W = 20;
            pnn.H = 20;
            Lbf.Add(pnn);
            flf = 1;

        }
        void movebulletfly()
        {
          
                    for (int j = 0; j < Lbf.Count; j++)
                    {
                        Lbf[j].Y += 10;
                     if (Lbf[j].X >= LActs[0].X && Lbf[j].X + Lbf[j].W <= LActs[0].X +LActs[0].W&&Lbf[j].Y==LActs[0].Y)
                     {
                              ctre--;
                           Lbf.RemoveAt(j);

                     }

                    }
                
            

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);

            createbackground();

            createactors();
            createelevator();
            createladder();
            createroof();
            createenemies();
            createenemies2();
            createfly();
         





        }
        void shoot()
        {
            createbulletsright();

            l5 = 40;
        }
        void createlaser()
        {
            CLaser pnn = new CLaser();
            pnn.X = LActs[0].X + 53;
            pnn.Y = LActs[0].Y + 38;
            pnn.W=this.Width;
            pnn.H = 3;
            La.Add(pnn);
        }
        void shootright()
        {
            if(lshoot==58)
            {
                lshoot = 52;
            }
            createbulletsright();

            lshoot++;
            XS++;


        }
        void shootleft()
        {


        }
       void createbulletsright()
        {
            bullet pnn = new bullet();
            pnn.X = LActs[0].X + 53;
            pnn.Y = LActs[0].Y + 38;
            pnn.img = new Bitmap("42.bmp");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.W = 20;
            pnn.H = 10;
            Lbu.Add(pnn);


        }
        void createbulletsleft()
        {
            bullet pnn = new bullet();
           
                pnn.X = Le2[pose].X - 5;
                pnn.Y = Le2[pose].Y + 32;


                pnn.img = new Bitmap("51.bmp");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.W = 20;
                pnn.H = 10;
                Lbue.Add(pnn);
                fbue = 1;
            
            

        }
        void createfly()
        {
            for (int j = 0; j < 10; j++)
            {
                fly pnn = new fly();
                pnn.X = af;
                pnn.Y = 150;
                pnn.img = new Bitmap("80.bmp");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.W = 50;
                pnn.H = 50;
                Lf.Add(pnn);
                af += 300;
            }
        }
        void movefly()
        {
            for (int i = 0; i < Lf.Count; i++)
            { 
                if (Lf[i].ihit==-1)
                {  if (Lf[i].X >= LActs[0].X)
                    {
                        Lf[i].X -= 2;

                    }
                    else
                    {
                        Lf[i].ihit = 1;
                    }
                }
                if(Lf[i].ihit==1)
                {
                    if (Lf[i].X <= LActs[0].X)
                    {
                        Lf[i].X += 2;

                    }
                    else
                    {
                        Lf[i].ihit = -1;
                    }
                }

            }
        }
        void movelaser()
        {
            for (int i = 0; i < La.Count; i++)
            {
                for (int j = 0; j < Le.Count; j++)
                {
                    if (Le[j].X==La[i].X+La[i].W)
                    {
                        Le.RemoveAt(j);
                        flaser = 0;
                    }       
                    

                }
                for (int j = 0; j < Le2.Count; j++)
                {
                    if (Le2[j].X == La[i].X + La[i].W)
                    {

                        Le2.RemoveAt(j);
                        flaser = 0;

                    }

                }
            }
        }
        void movebulletleft()
        {

            for(int i=0;i<Lbue.Count;i++)
            {
                Lbue[i].X -= 10;
                if(Lbue[i].X>=LActs[0].X&&Lbue[i].X+Lbue[i].W<=LActs[0].X+LActs[0].W&&this.Height-170==LActs[0].Y)
                {
                    ctre--;
                    Lbue.RemoveAt(i);
                }

            }

        }
        void movebulletsright()
        {
            for(int i=0;i<Lbu.Count;i++)
            {
                Lbu[i].X += 10;
                for(int k=0;k<Le.Count;k++)
                {
                    if (Lbu[i].X >= Le[k].X && Lbu[i].X + Lbu[i].W <= Le[k].X +Le[k].W&& this.Height - 170 == LActs[0].Y)
                    {
                        Le.RemoveAt(k);
                        fhit1 = 1;
                       
                    }
                }
                for (int k = 0; k < Le2.Count; k++)
                {
                    if (Lbu[i].X >= Le2[k].X && Lbu[i].X + Lbu[i].W <= Le2[k].X + Le2[k].W && this.Height - 170 == LActs[0].Y)
                    {
                        Le2.RemoveAt(k);
                        counte--;
                        fhit1 = 1;

                    }
                }
                if (fhit1 == 1)
                {
                    Lbu.RemoveAt(i);
                    fhit1 = 0;
                }
            }


        }
        void jumpright()
        {
           
                for (int k = 27; k < LActs[0].imgs.Count - 4; k++)
                {
                if (LActs[0].Y >= this.Height - 250)
                {
                    LActs[0].Y -= 2;
                    
                    LActs[0].X++;
                }
            
                l3++;

                }
                l3 = 27;
            
        }
        void jumpleft()
        {
          
                for (int k = 37; k < LActs[0].imgs.Count; k++)
                {
                if (LActs[0].Y >= this.Height - 250)
                {
                    LActs[0].Y -= 2;
                    
                    LActs[0].X--;
                }
                        
                    l4++;

                }
                l4 = 37;
            
        }



        void createactors()
        {
            CActor pnn = new CActor();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 59; i++)
            {
                Bitmap pnnImg = new Bitmap((i + 1) + ".bmp");
                pnnImg.MakeTransparent(pnnImg.GetPixel(0, 0));
                pnn.imgs.Add(pnnImg);
            }
            pnn.X = 165;
            pnn.Y = this.Height - 170;
            pnn.W = 80;
            pnn.H = 80;
            LActs.Add(pnn);
      
        }
        void createenemies()
        {
            for (int j = 0; j < 30; j++)
            {
                Cenemy pnn = new Cenemy();
                pnn.imgs = new List<Bitmap>();
                for (int i = 60; i < 69; i++)
                {
                    Bitmap pnnImg = new Bitmap((i + 1) + ".bmp");
                    pnnImg.MakeTransparent(pnnImg.GetPixel(0, 0));
                    pnn.imgs.Add(pnnImg);
                }
                pnn.X = ae;
                pnn.Y = this.Height - 170;
                pnn.W = 80;
                pnn.H = 80;
                Le.Add(pnn);
                ae += 200;
            }
     

        }
        void createenemies2()
        {
            for (int j = 0; j < 20; j++)
            {
                Cenemy pnn = new Cenemy();
                pnn.imgs = new List<Bitmap>();
                for (int i = 71; i < 77; i++)
                {
                    Bitmap pnnImg = new Bitmap((i + 1) + ".png");
                    pnnImg.MakeTransparent(pnnImg.GetPixel(1,1));
                    pnn.imgs.Add(pnnImg);
                }
                pnn.X = ae2;
                pnn.Y = this.Height - 170;
                pnn.W = 80;
                pnn.H = 80;
                Le2.Add(pnn);
                ae2 += 300;
            }
        }
        void moveenemies()
        {
           if(le1==8)
            {
                le1 = 0;
            }
         
            for(int i=0;i<Le.Count;i++)
            {
                Le[i].X -= 2;
                if(Le[i].X>=LActs[0].X&&Le[i].X+40<=LActs[0].X+LActs[0].W)
                {
                    fgameover = 1;
                }

            }
            le1++;
         

        }
        void moveenemies2()
        {
            if (le2 == 5)
            {
                le2 = 0;
            }

            for (int i = 0; i < Le2.Count; i++)
            {
                Le2[i].X -= 2;
                if (Le2[i].X >= LActs[0].X && Le[i].X + 40 <= LActs[0].X + LActs[0].W)
                {
                    fgameover = 1;
                }

            }
            le2++;


        }
        void createladder()
        {
            CLadder pnn = new CLadder();
            pnn.X = Lr[0].X+400;
            pnn.Y = 470;
            pnn.img = new Bitmap("60.bmp");
            pnn.img.MakeTransparent(pnn.img.GetPixel(25, 25));
            pnn.W = 100;
            pnn.H = 300;
            Ll.Add(pnn);
        }
        void createroof()
        {
            CLadder pnn = new CLadder();
            pnn.X = Lr[0].X + Lr[0].W+5;
            pnn.Y = 470;
            pnn.W = 390;
            pnn.H = 5;
            Ll.Add(pnn);
            CLadder pnn2 = new CLadder();
            pnn2.X = Lr[0].X + Lr[0].W + 5;
            pnn2.Y = 470;
            pnn2.W = 5;
            pnn2.H = 300;
            Ll.Add(pnn2);
        }
        void createactorsshoot()
        {
            CActor pnn = new CActor();
            pnn.imgs = new List<Bitmap>();
            for (int i = 51; i < 59; i++)
            {
                Bitmap pnnImg = new Bitmap((i + 1) + ".bmp");
                pnnImg.MakeTransparent(pnnImg.GetPixel(0, 0));
                pnn.imgs.Add(pnnImg);
            }
            pnn.X = 165;
            pnn.Y = this.Height - 170;
            pnn.W = 80;
            pnn.H = 80;
            LActs.Add(pnn);
        }
        void createelevator()
        {
            rect pnn = new rect();
            pnn.X = this.Width*4-1000;
            pnn.Y = this.Height - 290;
            pnn.W = 100;
            pnn.H = 200;
            Lr.Add(pnn);

        }
        void moveelevator()
        {
            
            if (Lr[0].dir == -1)
            {        Lr[0].Y -= 2;
            }
            if(Lr[0].Y==200)
            {
                Lr[0].dir = 1;
            }
            if (Lr[0].dir == 1)
            {
                Lr[0].Y += 2;
            }
            if(Lr[0].Y+Lr[0].H>=this.Height-90)
            {
                Lr[0].dir = -1;
            }

        }
        int j = 0;
        void DrawScene(Graphics g)
        {
            g.Clear(Color.Black);


            g.DrawImage(b, new Rectangle(0, 0, this.Width * 4, this.Height), new Rectangle(XS, YS, b.Width, b.Height), GraphicsUnit.Pixel);
            if (flaser == 1)
            {
                for (int i = 0; i < La.Count; i++)
                {
                    g.FillRectangle(Brushes.Yellow, La[i].X, La[i].Y, La[i].W, La[i].H);
                }


            }

            if (f == 0)
            {
                int k = 0;
                g.DrawImage(LActs[0].imgs[k], LActs[0].X, LActs[0].Y, LActs[0].W, LActs[0].H);
            }
            if (f == 1)
            {

                int k = l;
                g.DrawImage(LActs[0].imgs[k], LActs[0].X, LActs[0].Y, LActs[0].W, LActs[0].H);



            }
            if (f == 2)
            {

                int k = l2;
                g.DrawImage(LActs[0].imgs[k], LActs[0].X, LActs[0].Y, LActs[0].W, LActs[0].H);




            }

            if (fj == 1)
            {
                if (f == 1)
                {
                    int k = l3;
                    g.DrawImage(LActs[0].imgs[k], LActs[0].X, LActs[0].Y, LActs[0].W, LActs[0].H);
                }
                if (f == 2)
                {
                    int u = l4;
                    g.DrawImage(LActs[0].imgs[u], LActs[0].X, LActs[0].Y, LActs[0].W, LActs[0].H);
                }


            }

            if (flaunch == 1)
            {
                for (int i = 0; i < Lbu.Count; i++)
                {
                    g.DrawImage(Lbu[i].img, Lbu[i].X, Lbu[i].Y, Lbu[i].W, Lbu[i].H);

                }
            }
            if (fb == 1)
            {
                int k = l5;
                g.DrawImage(LActs[0].imgs[k], LActs[0].X, LActs[0].Y, LActs[0].W, LActs[0].H);
            }
            if (fshootR == 1)
            {
                fb = 0;
                int k = lshoot;
                g.DrawImage(LActs[0].imgs[k], LActs[0].X, LActs[0].Y, LActs[0].W, LActs[0].H);

            }
            Pen p = new Pen(Brushes.Black, 5);
            g.DrawRectangle(p, Lr[0].X, Lr[0].Y, Lr[0].W, Lr[0].H);
            Pen p2 = new Pen(Brushes.Black, 5);
            g.DrawLine(p2, Lr[0].X + 50, Lr[0].Y, Lr[0].X + 50, 3);
            g.DrawImage(Ll[0].img, Ll[0].X, Ll[0].Y, Ll[0].W, Ll[0].H);
            g.FillRectangle(Brushes.Gray, Ll[1].X, Ll[1].Y, Ll[1].W, Ll[1].H);
            g.FillRectangle(Brushes.Gray, Ll[2].X, Ll[2].Y, Ll[2].W, Ll[2].H);
            for (int i = 0; i < Le.Count; i++)
            {
                int k = le1;
                g.DrawImage(Le[i].imgs[k], Le[i].X, Le[i].Y, Le[i].W, Le[i].H);

            }
            for (int i = 0; i < Le2.Count; i++)
            {
                int k = le2;
                g.DrawImage(Le2[i].imgs[k], Le2[i].X, Le2[i].Y, Le2[i].W, Le2[i].H);

            }
            for (int i = 0; i < Lbue.Count; i++)
            {
                g.DrawImage(Lbue[i].img, Lbue[i].X, Lbue[i].Y, Lbue[i].W, Lbue[i].H);

            }
            String S = "" + ctre;
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString(S, drawFont, Brushes.Red, 10, 10);
            for(int i=0;i<Lf.Count;i++)
            {
                g.DrawImage(Lf[i].img, Lf[i].X, Lf[i].Y, Lf[i].W, Lf[i].H);
            }

            for (int i = 0; i < Lbf.Count; i++)
            {
                g.DrawImage(Lbf[i].img, Lbf[i].X, Lbf[i].Y, Lbf[i].W, Lbf[i].H);
            }

        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}
