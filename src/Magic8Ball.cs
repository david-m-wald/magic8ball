using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Magic8Ball : Form
    {
        private Point relClickLocation;
        private int nMoveEvents;
        private GraphicsPath pickerUpGPath;
        private GraphicsPath pickerDownGPath;

        public Magic8Ball()
        {
            InitializeComponent();
            CustomComponentSettings();
        }

        //Method to custom initialize components after designer initialization
        private void CustomComponentSettings()
        {
            //Magic8Ball
            this.MinimumSize = new Size(350, 350);                  //Ensures proper scaling
                   
            GraphicsPath ballGPath = new GraphicsPath();
            ballGPath.AddEllipse(0, 0, 350, 350);                   //Clip to circular region
            this.Region = new Region(ballGPath);


            //Exit button (top portion of ball - not a real button but a label acting like a button)
            exitButton.MinimumSize = new Size(350, 40);             //Ensures proper scaling
            exitButton.Location = new Point(0, 0);                  //Ensures proper location upon scaling

            GraphicsPath exitGPath = new GraphicsPath();
            exitGPath.AddEllipse(0, -40, 350, 70);                  //Clip to elliptical region
            exitButton.Region = new Region(exitGPath);


            //Viewport
            viewport.MinimumSize = new Size(180, 180);              //Ensures proper scaling
            viewport.Location = new Point(85, 85);                  //Ensures proper location upon scaling

            GraphicsPath viewportGPath = new GraphicsPath();
            viewportGPath.AddEllipse(0, 0, 180, 180);               //Clip to circular region
            viewport.Region = new Region(viewportGPath);


            //Answer picker
            answerPicker.MinimumSize = new Size(150, 150);          //Ensures proper scaling
            answerPicker.Location = new Point(100, 100);            //Ensures proper location upon scaling

            pickerUpGPath = new GraphicsPath();
            pickerDownGPath = new GraphicsPath();
            Point[] upTrianglePoints = {
                new Point(75, 0),
                new Point(15, 120),
                new Point(135, 120)
            };
            Point[] downTrianglePoints = {
                new Point(15, 30),
                new Point(135, 30),
                new Point(75, 150)
            };
            pickerUpGPath.AddPolygon(upTrianglePoints);             //Option 1: clip to up-pointing triangular region
            pickerDownGPath.AddPolygon(downTrianglePoints);         //Option 2: clip to down-pointing triangular region


            //Answer label
            answerLabel.MinimumSize = new Size(150, 150);           //Ensures proper scaling
            answerLabel.Location = new Point(0, 0);                 //Ensures proper location upon scaling            
        }

        //Paint event handlers to draw graphics
        private void Viewport_Paint(object sender, PaintEventArgs e)
        {
            //Add graphics
            e.Graphics.DrawEllipse(new Pen(new SolidBrush(Color.FromArgb(100, 80, 80, 80)), 10), 0, 0, 180, 180);
        }

        private void ExitButton_Paint(object sender, PaintEventArgs e)
        {
            //Add graphics
            e.Graphics.FillEllipse(Brushes.Black, 0, -40, 350, 50);
            e.Graphics.DrawEllipse(new Pen(Brushes.Black, 3), 0, 0, 350, 350);
        }

        //Event handler to close application when left-clicking exit button
        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Application.Exit();
        }

        //Mouse event handlers for displaying/removing exit button text
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Text = "Exit";
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Text = "";
        }

        //Mouse event handlers for interacting with main portion of Magic8Ball
        private void General_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return; //Only left mouse button can be used

            nMoveEvents = 0;
            answerPicker.Visible = false;
            answerLabel.Text = "";

            relClickLocation = e.Location;
            //Add MouseMove event handler for active control 
            ((dynamic)sender).MouseMove += new MouseEventHandler(this.General_MouseMove);
        }

        private void General_MouseUp(object sender, MouseEventArgs e)
        {
            if (nMoveEvents >= 75) DisplayAnswer(); //Answer picker displays based on number of valid MouseMove events counted

            //Remove MouseMove event handler for active control 
            ((dynamic)sender).MouseMove -= new MouseEventHandler(this.General_MouseMove);            
        }

        private void General_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location == relClickLocation) return; //Ignore secondary event triggered when Magic8Ball's location is updated relative to mouse position 

            nMoveEvents++;

            //Overall Magic8Ball repositioned on screen where original click spot aligns with current mouse position
            Point deltaPos = new Point(e.X - relClickLocation.X, e.Y - relClickLocation.Y);
            this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
        }

        //Method to display a randomly selected answer with appropriate triangular graphics
        private void DisplayAnswer()
        {
            string[] answerList = new string[] {  //Two spaces used between words for display clarity
                "IT  IS\nCERTAIN",
                "IT  IS\nDECIDEDLY\nSO",
                "YES  -\nDEFINITELY",
                "YOU\nMAY  RELY\nON  IT",
                "AS  I\nSEE  IT,\nYES",
                "MOST\nLIKELY",
                "YES",
                "REPLY\nHAZY,\nTRY  AGAIN",
                "ASK\nAGAIN\nLATER",
                "DON'T\nCOUNT\nON  IT",
                "VERY\nDOUBTFUL",
                "WITHOUT  A\nDOUBT",
                "OUTLOOK\nGOOD",
                "SIGNS\nPOINT  TO\nYES",
                "BETTER\nNOT  TELL\nYOU  NOW",
                "CANNOT\nPREDICT\nNOW",
                "CONCENTRATE\nAND  ASK\nAGAIN",
                "MY  REPLY\nIS  NO",
                "MY  SOURCES\nSAY  NO",
                "OUTLOOK\nNOT  SO\nGOOD",
            };

            Random value = new Random();
            int pick = value.Next(0, 20);
            if (pick <= 10) //first 11 answers use up-pointing triangle
                answerPicker.Region = new Region(pickerUpGPath);
            else            //remaining answers use down-pointing triangle
                answerPicker.Region = new Region(pickerDownGPath);
            answerPicker.Visible = true;
            answerLabel.Text = answerList[pick];
        }
    }
}