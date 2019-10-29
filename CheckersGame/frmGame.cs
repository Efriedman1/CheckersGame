//TODO
//add multi jump functionality
//show "potential moves"
//display remaining pieces..DONE
//display winner
//display how many kings each player has
//add rules/how to
//name input
//fix player icon to only change on VALID click
//add force jump
//make game start on menu screen


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class frmGame : Form
    {
        //counter attributes
        int turn = 0;
        int whiteChips = 12;
        int whiteKings = 0;
        int whiteJumped = 0;
        int blackChips = 12;
        int blackKings = 0;
        int blackJumped = 0;

        bool extraMove = false;
        PictureBox select = null;

        //instantiate lists for both players pieces
        List<PictureBox> whitePieces = new List<PictureBox>();
        List<PictureBox> blackPieces = new List<PictureBox>();

        public frmGame()
        {
            InitializeComponent();
            loadLists();           
        }

        //Add pieces to picture box list
        private void loadLists()
        {
            whitePieces.Add(white1);
            whitePieces.Add(white2);
            whitePieces.Add(white3);
            whitePieces.Add(white4);
            whitePieces.Add(white6);
            whitePieces.Add(white7);
            whitePieces.Add(white8);
            whitePieces.Add(white5);
            whitePieces.Add(white9);
            whitePieces.Add(white10);
            whitePieces.Add(white11);
            whitePieces.Add(white12);

            blackPieces.Add(black1);
            blackPieces.Add(black2);
            blackPieces.Add(black3);
            blackPieces.Add(black4);
            blackPieces.Add(black6);
            blackPieces.Add(black7);
            blackPieces.Add(black8);
            blackPieces.Add(black5);
            blackPieces.Add(black9);
            blackPieces.Add(black10);
            blackPieces.Add(black11);
            blackPieces.Add(black12);
        }

        //responsible for chip movement
        public void movement(PictureBox square)
        {
            if (select != null)
            {
                string color = select.Name.ToString().Substring(0, 5);
                formatPlayerIcon(color);
                //validation
                if (moveValidation(select, square, color))
                {
                    Point lastLocation = select.Location;
                   // Console.WriteLine("select location" + select.Location);
                    select.Location = square.Location;
                   // Console.WriteLine("square location" + square.Location);
                    int advance = lastLocation.Y - square.Location.Y;
                   // Console.WriteLine("location y"+lastLocation.Y);

                    //verifying extra move
                    if (!isExtraMove(color) | Math.Abs(advance) == 52)
                    {
                        Console.WriteLine("advance" + Math.Abs(advance));
                        ifKing(color); 
                        turn++;
                        select.BackColor = Color.Tan;
                        select = null;
                        extraMove = false;
                    }
                    else
                    {
                        extraMove = true;
                    }
                }

            }
        }

        private bool isExtraMove(string color)
        {
            List<PictureBox> oppositeSide = color == "white" ? blackPieces : whitePieces;
           
            //list of points to be evaluated
            List<Point> positions = new List<Point>();

            //validating that the space in behind the piece we intend to jump is unoccupied
            int nextPosition = color == "white" ? -100 : 100;
            positions.Add(new Point(select.Location.X + 100, select.Location.Y + nextPosition));
            positions.Add(new Point(select.Location.X - 100, select.Location.Y + nextPosition));
            if (select.Tag == "king")
            {
                positions.Add(new Point(select.Location.X + 100, select.Location.Y - nextPosition));
                positions.Add(new Point(select.Location.X - 100, select.Location.Y - nextPosition));
            }

            bool result = false;
            for (int i = 0; i < positions.Count; i++)
            {
                
                if (positions[i].X >= 50 && positions[i].X <= 400 && positions[i].Y >= 50 && positions[i].Y <= 400)
                {
                    //validating the spot we intend to jump is unoccupied
                    if (!occupied(positions[i], whitePieces) && !occupied(positions[i], blackPieces))
                    {
                        Point centerPoint = new Point(average(positions[i].X, select.Location.X), average(positions[i].Y, select.Location.Y));
                        //verify there is a piece in the location we jumped
                        if (occupied(centerPoint, oppositeSide))
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        //look for a point within the list of points, returns true if occupied, false if not
        private bool occupied(Point point, List<PictureBox> inside)
        {
            for (int i = 0; i < inside.Count; i++)
            {
                if (point == inside[i].Location)
                {
                    return true;
                }
            }
            return false;
        }

        //takes the average of two numbers 
        private int average(int n1, int n2)
        {
            int result = n1 + n2;
            result = result / 2;
            return Math.Abs(result);
        }
        
        //validates the the allowed movement of a piece
        private bool moveValidation(PictureBox origin, PictureBox desination, string color)
        {
            Point originPoint = origin.Location;
            Point desinationPoint = desination.Location;
            int advance = originPoint.Y - desinationPoint.Y;
            Console.WriteLine(originPoint.Y - desinationPoint.Y);
            advance = color == "white" ? advance : (advance * -1);
            advance = select.Tag == "king" ? Math.Abs(advance) : advance;

            //regular piece movement 
            if (advance == 52)
            {
                return true;
            }
            //piece jumping over another piece and removing jumped piece
            else if (advance == 104)
            {
                Point centerPoint = new Point(average(desinationPoint.X, originPoint.X), average(desinationPoint.Y, originPoint.Y));
                List<PictureBox> oppositeSide = color == "white" ? blackPieces : whitePieces;
                for (int i = 0; i < oppositeSide.Count; i++)
                {
                    if (oppositeSide[i].Location == centerPoint)
                    {
                        oppositeSide[i].Location = new Point(0,0);
                        oppositeSide[i].Visible = false;
                        Console.WriteLine("Center Point Name:" + oppositeSide[i].Name);

                        //Subtract from chip count & increment jumped piece count
                        string jumpedPiece = oppositeSide[i].Name.ToString().Substring(0, 5);
                        if (jumpedPiece == "black")
                        {
                            blackChips = blackChips - 1;
                            blackJumped = blackJumped + 1;
                            lblChipCount2.Text = blackChips.ToString();
                            lblJumpCount1.Text = blackJumped.ToString();
                        }
                        if (jumpedPiece == "white")
                        {
                            whiteChips = whiteChips - 1;
                            whiteJumped = whiteJumped + 1;
                            lblChipCount1.Text = whiteChips.ToString();
                            lblJumpCount2.Text = whiteJumped.ToString();
                        }

                        return true;
                    }
                }
            }
            return false;
        }


        //Validates chip field selected and changes selected chips background color
        public void selection(object x)
        {
            if (!extraMove) {
                try
                {
                    select.BackColor = Color.Tan;
                }
                catch
                {

                }
                PictureBox file = (PictureBox)x;
                select = file;
                select.BackColor = Color.RoyalBlue;
                Console.WriteLine("Selected Coordinates: (" + select.Location.X + ", " + select.Location.Y + ")");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player1Image.BorderStyle = BorderStyle.Fixed3D;
            player1Image.BackColor = Color.MediumSeaGreen;
     
        }

        private void onClick(object sender, MouseEventArgs e)
        {
            movement((PictureBox)sender);
        }

        //white chip selected
        private void selectWhite(object sender, MouseEventArgs e)
        {
            //turn validation
            if (turn % 2 == 0)
            {
                selection(sender);
            }
            else
            {
                MessageBox.Show("It is Player 2's (Black) turn");
            }
        }

        //black chip selected
        private void selectBlack(object sender, MouseEventArgs e)
        {
            //turn validation
            if (turn % 2 == 1)
            {
                selection(sender);
            }
            else
            {
                MessageBox.Show("It is Player 1's (White) turn");
            }
        }

        //Highlight player icon in side menu to designate turn
        private void formatPlayerIcon(string color)
        {
            if (color == "black")
            {
                player1Image.BackColor = Color.MediumSeaGreen;
                player1Image.BorderStyle = BorderStyle.Fixed3D;
                player2Image.BackColor = Color.Transparent;
                player2Image.BorderStyle = BorderStyle.None;
            }
            if (color == "white")
            {
                player2Image.BorderStyle = BorderStyle.Fixed3D;
                player2Image.BackColor = Color.MediumSeaGreen;
                player1Image.BorderStyle = BorderStyle.None;
                player1Image.BackColor = Color.Transparent;

            }
        }

        //if a player gets a king piece
        private void ifKing(string color)
        {
            if (color == "white" && select.Location.Y == 26)
            {
                select.BackgroundImage = Properties.Resources.whiteKing;
                select.Tag = "king";

                //Increment king counter
                whiteKings = whiteKings + 1;
                lblKingCount1.Text = whiteKings.ToString();

            }
            if (color == "black" && select.Location.Y == 390)
            {
                select.BackgroundImage = Properties.Resources.blackKing;
                select.Tag = "king";

                //Increment king counter
                blackKings = blackKings + 1;
                lblKingCount2.Text = blackKings.ToString();
            }
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
