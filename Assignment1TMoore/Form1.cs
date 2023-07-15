using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
// custom components
using GUIImageArray;
//for the speech:
using System.Speech.Synthesis;


namespace Assignment1TMoore
{
    public partial class othelloForm : Form
    {
        //making the board
        GImageArray GBoard;
        string ImagePath = Directory.GetCurrentDirectory() + "\\images\\";

        //creates an int to track whose turn it is:
        int playerTurn;


        //later used to determine whether a game has started, for exit window purposes
        bool inProgress = false;

        // score variables
        int whiteScore;
        int blackScore;

        //2d integer array to hold data regarding the game state:
        int[,] boardArray = new int[8, 8];

        //variable to determine whether or not a move has been made
        bool moveMade;

        //form to hold the 'about' form
        Form f2 = new Form();

        //creates 'speaker', an object of the SpeechSynthesizer class, responsible for text to speech:
        SpeechSynthesizer speaker = new SpeechSynthesizer();

        public othelloForm()
        {
            InitializeComponent();
            //variable to determine whose turn it is
            //white starts, so white = 1
            playerTurn = 1;
            




        }

        //method for element click detection:
        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            //detects the indexes or the square that have been clicked:
            int row = GBoard.Get_Row(sender);
            int col = GBoard.Get_Col(sender);

            //TESTING ONLY (kept for later assignment)
            //lrow.Text = row.ToString();
            //lcol.Text = col.ToString();


            //if area clicked is blank:
            if (boardArray[row, col] == 10) {
                //all fuctions check from the area clicked
                //so 'check North' will check North from the area the player is trying to place a counter

                //checks all the directions:
                checkNorth(row, col);
                checkSouth(row, col);
                checkWest(row, col); 
                checkEast(row, col); 
                checkSouthWest(row, col); 
                checkSouthEast(row, col); 
                checkNorthWest(row, col); 
                checkNorthEast(row, col); 
            }

            //if a successful move was made:
            if (moveMade == true)
            {
                // Changes Players

                if (playerTurn == 1)
                {
                    playerTurn = 0;
                    
                    //hide white's to play image
                    whiteToPlayImage.Visible = false;
                    
                    //show black's to play image
                    blackToPlayImage.Visible = true;
                    
                    //resets 'moveMade' for next player's turn:
                    moveMade = false;
                    
                    //accomodates for adding extra piece:
                    whiteScore++;
                }
                else
                {
                    playerTurn = 1;

                    
                    //show white to play image
                    whiteToPlayImage.Visible = true;
                    
                    //hide white to play image
                    blackToPlayImage.Visible = false;
                    
                    //resets 'moveMade' for next player's turn
                    moveMade = false;

                    //accomodates for adding extra piece:
                    blackScore++;
                }
                
                //update score labels
                whiteLabel.Text = whiteScore.ToString();
                blackLabel.Text = blackScore.ToString();
                
                //speak:
                //if the user has opted for speech:
                if(speakMenuItem.Checked == true) {
                    
                    //concatonates all the information into a single string ready for passing to the speaker
                    string speech = ("Now " + whiteTextBox.Text + " has " + whiteLabel.Text + " and " + blackTextBox.Text + " has " + blackLabel.Text);
                    
                    //speaks the information
                    speaker.Speak(speech);
                }


            }
            
            //if the move is invalid
            else {
                //if the usesr has opted for speech:
                if (speakMenuItem.Checked == true) {
                    speaker.Speak("That was an invalid move");
                }
                
            }



            //updates the GUI board:
            GBoard.UpDateImages(boardArray);


        }

        //method to easily change score:
        private void incrementScore() 
        {
            //if white's turn:
            if (playerTurn == 1)
            {
                //increase white's score, decrease black's:
                whiteScore++;
                blackScore--;
            }
            //else it is black's turn:
            else 
            {
                //increase black's score, decrease white's:
                blackScore++;
                whiteScore--;
            }
        }

        //method to check north from click:
        private void checkNorth(int row, int col)
        {
            int NewRow = row - 1;
            //used to check whether a legal move still possible
            bool moveIllegal = false;
            //creates empty lists for row/col locations
            List<int> rowLocation = new List<int>();
            //List<int> colLocation = new List<int>();

            //looks for the tokens that need changing on the north axis
            if (NewRow > -1)
            {
                do
                {   //checks move legality
                    if (boardArray[NewRow, col] != playerTurn && boardArray[NewRow, col] != 10)
                    {
                        //adds the new location to the new ilsts
                        rowLocation.Add(NewRow);
                        //colLocation.Add(col);
                        //changes the counter to iterate through the board
                        NewRow--;
                        
                        //if the end of the board is reached
                        if (NewRow < 0)
                        {
                            //stop checking; the next move wouldn't be a legal move
                            moveIllegal = true;
                            NewRow = 0;
                        }
                    }
                    else //the selected area isn't a possible move location
                    {
                        moveIllegal = true;
                    }

                    //whilst the move is legal
                } while (boardArray[NewRow, col] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (rowLocation.Count > 0 && moveIllegal != true) {
                //set the moveMade variable to true, to enable turn switching:
                moveMade = true;
                for (int Token = 0; Token < rowLocation.Count; Token++)
                {
                    //place the current player's token
                    boardArray[rowLocation[Token], col] = playerTurn;
                    //increase score
                    incrementScore();
                }
                boardArray[row, col] = playerTurn;
            }

        }
       
        //method for South axis checking

        private void checkSouth(int row, int col) {
            int NewRow = row + 1;
            //used to check if move still possible
            bool moveIllegal = false;
            //creates empty lists for row and col locations
            List<int> rowLocation = new List<int>();
            List<int> colLocation = new List<int>();

            //checks validity of South axis moves
            if (NewRow < 8)
            {
                do
                {
                    //checks move legality
                    if (boardArray[NewRow, col] != playerTurn && boardArray[NewRow, col] != 10)
                    {
                        //adds the new location to the location lists
                        rowLocation.Add(NewRow);
                        colLocation.Add(col);
                        //increments to iterate through South axis locations:
                        NewRow++;
                        
                        //if the end of the board is reached:
                        if (NewRow > 7)
                        {   //stops checking as out of bounds
                            moveIllegal = true;
                            NewRow = 0;
                        }
                    }
                    else //if selected area is not a possible move location
                    {
                        moveIllegal = true;
                    }

                } while (boardArray[NewRow, col] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (rowLocation.Count > 0 && moveIllegal != true)
            {
                moveMade = true;
                for (int Token = 0; Token < rowLocation.Count; Token++)
                {   //place current player's token
                    boardArray[rowLocation[Token], col] = playerTurn;
                    //call score increase fuction
                    incrementScore();

                }
                boardArray[row, col] = playerTurn;
            }
        }

        //method checking East from click

        private void checkEast(int row, int col) {
            int NewCol = col + 1;
            bool moveIllegal = false;
            //new lists for locations
            List<int> rowLocation = new List<int>();
            List<int> colLocation = new List<int>();

            //checks validity
            if (NewCol < 8)
            {
                do
                {
                    //checks move legality
                    if (boardArray[row, NewCol] != playerTurn && boardArray[row, NewCol] != 10)
                    {
                        //adds new location to lists
                        rowLocation.Add(row);
                        colLocation.Add(NewCol);
                        //increments to iterate through possible locations
                        NewCol++;
                        
                        //if the end of board is reached:
                        if (NewCol > 7)
                        {
                            //the next location would not be a legal change
                            moveIllegal = true;
                            NewCol = 0;
                        }
                    }
                    else //if location is not a possible move location
                    {
                        moveIllegal = true;
                    }

                } while (boardArray[row, NewCol] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (colLocation.Count > 0 && moveIllegal != true)
            {
                moveMade = true;
                for (int Token = 0; Token < colLocation.Count; Token++)
                {
                    //place current player's token
                    boardArray[row, colLocation[Token]] = playerTurn;
                    //increase score
                    incrementScore();

                }
                boardArray[row, col] = playerTurn;
            }

        }

        //method for checking West from click

        private void checkWest(int row, int col) {
            int NewCol = col - 1;
            bool moveIllegal = false;
            //new lists for location storage
            List<int> rowLocation = new List<int>();
            List<int> colLocation = new List<int>();

            //checks validity
            if (NewCol > -1)
            {
                do
                {
                    //checks move legality
                    if (boardArray[row, NewCol] != playerTurn && boardArray[row, NewCol] != 10)
                    {
                        //adds new locations to list
                        rowLocation.Add(row);
                        colLocation.Add(NewCol);
                        //decreases to work through the board
                        NewCol--;
                        
                        //if next sqaure still in range
                        if (NewCol < 0)
                        {
                            //it is not a possible square
                            moveIllegal = true;
                            NewCol = 0;
                        }
                    }
                    else
                    {
                        moveIllegal = true;
                    }

                } while (boardArray[row, NewCol] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (colLocation.Count > 0 && moveIllegal != true)
            {
                moveMade = true;
                for (int Token = 0; Token < colLocation.Count; Token++)
                {
                    //allocate position to player
                    boardArray[row, colLocation[Token]] = playerTurn;
                    //increase score
                    incrementScore();
                }
                boardArray[row, col] = playerTurn;
            }
        }

        //method for checking NW from click

        private void checkNorthWest(int row, int col) {
            int NewRow = row - 1;
            int NewCol = col - 1;
            bool moveIllegal = false;
            //neww lists for location storage
            List<int> rowLocation = new List<int>();
            List<int> colLocation = new List<int>();

            //if within bounds
            if (NewRow > -1 && NewCol > -1) {
                do {
                    //if legal move
                    if (boardArray[NewRow, NewCol] != playerTurn && boardArray[NewRow, NewCol] != 10)
                    {
                        //store locations in lists
                        rowLocation.Add(NewRow);
                        colLocation.Add(NewCol);
                        //decrement location values to traverse through the board
                        NewCol--;
                        NewRow--;
                        
                        //if move invalid
                        if (NewRow < 0 || NewCol < 0)
                        {
                            //no need to traverse through rest of board
                            moveIllegal = true;
                            NewRow = 0;
                            NewCol = 0;
                        }
                    }
                    else
                    {
                        moveIllegal = true;
                    }

                } while (boardArray[NewRow, NewCol] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (colLocation.Count > 0 && rowLocation.Count > 0 && moveIllegal != true)
            {
                moveMade = true;
                for (int Token = 0; Token < colLocation.Count || Token < rowLocation.Count; Token++)
                {
                    //assign player's value to location
                    boardArray[rowLocation[Token], colLocation[Token]] = playerTurn;
                    //increase the score
                    incrementScore();
                }
                boardArray[row, col] = playerTurn;
            }
        }

        //method for checking SW from click

        private void checkSouthWest(int row, int col)
        {
            int NewRow = row + 1;
            int NewCol = col - 1;
            bool moveIllegal = false;
            //creates new lists for location storage
            List<int> rowLocation = new List<int>();
            List<int> colLocation = new List<int>();

            //checks move is within bounds
            if (NewRow < 8 && NewCol > -1)
            {
                do
                {
                    //if move is legal
                    if (boardArray[NewRow, NewCol] != playerTurn && boardArray[NewRow, NewCol] != 10)
                    {
                        //store location in lists
                        rowLocation.Add(NewRow);
                        colLocation.Add(NewCol);
                        //changes value to traverse through board
                        NewCol--;
                        NewRow++;
                        
                        //if next location out of bounds
                        if (NewRow > 7 || NewCol < 0)
                        {
                            //no legal moves can be made
                            moveIllegal = true;
                            NewRow = 0;
                            NewCol = 0;
                        }
                    }
                    else
                    {
                        moveIllegal = true;
                    }

                } while (boardArray[NewRow, NewCol] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (colLocation.Count > 0 && rowLocation.Count > 0 && moveIllegal != true)
            {
                moveMade = true;
                for (int Token = 0; Token < colLocation.Count || Token < rowLocation.Count; Token++)
                {
                    //assign location value to the player
                    boardArray[rowLocation[Token], colLocation[Token]] = playerTurn;
                    //increment score
                    incrementScore();
                }
                boardArray[row, col] = playerTurn;
            }
        }

        //method for checking NE from click 

        private void checkNorthEast(int row, int col)
        {
            int NewRow = row - 1;
            int NewCol = col + 1;
            bool moveIllegal = false;
            //new lists for location storage
            List<int> rowLocation = new List<int>();
            List<int> colLocation = new List<int>();

            //checks if move is in bounds
            if (NewRow > -1 && NewCol < 8)
            {
                do
                {
                    //checks if move is legal
                    if (boardArray[NewRow, NewCol] != playerTurn && boardArray[NewRow, NewCol] != 10)
                    {
                        //add locations to list
                        rowLocation.Add(NewRow);
                        colLocation.Add(NewCol);
                        //adjust values to traverse through the board
                        NewCol++;
                        NewRow--;
                        
                        //if next square out of bounds
                        if (NewRow < 0 || NewCol > 7)
                        {
                            //it is not a legal move
                            moveIllegal = true;
                            NewRow = 0;
                            NewCol = 0;
                        }
                    }
                    else
                    {
                        moveIllegal = true;
                    }

                } while (boardArray[NewRow, NewCol] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (colLocation.Count > 0 && rowLocation.Count > 0 && moveIllegal != true)
            {
                moveMade = true;
                for (int Token = 0; Token < colLocation.Count || Token < rowLocation.Count; Token++)
                {
                    //assigns location the value of the player
                    boardArray[rowLocation[Token], colLocation[Token]] = playerTurn;
                    //increments his score
                    incrementScore();
                }
                boardArray[row, col] = playerTurn;
            }
        }

        //method for checking SE from click

        private void checkSouthEast(int row, int col)
        {
            int NewRow = row + 1;
            int NewCol = col + 1;
            bool moveIllegal = false;
            //creates new lists
            List<int> rowLocation = new List<int>();
            List<int> colLocation = new List<int>();

            //if move is in bounds
            if (NewRow < 8 && NewCol < 8)
            {
                do
                {
                    //if move is legal
                    if (boardArray[NewRow, NewCol] != playerTurn && boardArray[NewRow, NewCol] != 10)
                    {
                        //add locations to lists
                        rowLocation.Add(NewRow);
                        colLocation.Add(NewCol);
                        //adjust values to traverse board
                        NewCol++;
                        NewRow++;
                        
                        //if next square out of bounds
                        if (NewRow > 7 || NewCol > 7)
                        {
                            //it is not a legal location
                            moveIllegal = true;
                            NewRow = 0;
                            NewCol = 0;
                        }
                    }
                    else
                    {
                        moveIllegal = true;
                    }

                } while (boardArray[NewRow, NewCol] != playerTurn && moveIllegal != true);
            }
            //if tokens need changing, they change here:
            if (colLocation.Count > 0 && rowLocation.Count > 0 && moveIllegal != true)
            {
                moveMade = true;
                for (int Token = 0; Token < colLocation.Count || Token < rowLocation.Count; Token++)
                {
                    //assign locations to player value
                    boardArray[rowLocation[Token], colLocation[Token]] = playerTurn;
                    //increase score
                    incrementScore();
                }
                boardArray[row, col] = playerTurn;
            }
        }

        // method for new game creation
        //(based on new menu button click event
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            //if a game has already started:
            if (inProgress == true) {
                //give the user the option to save:
                save(boardArray);
            }
            // checking both player names have been entered:
            if (whiteTextBox.Text.Length < 1 || blackTextBox.Text.Length <1)
            {
                MessageBox.Show("Please make sure both players have a name. :)");
            }
            else
            {
                
                listFiller();
                //tempBoard is used to determine whether a 'GBoard' alrady exists
                //for example, if the player opens the application and immediately loads in a game without starting a new game, 'GBoard' will be null
                GImageArray tempBoard = GBoard;
                //if GBoard has not yet been initialised:
                if (tempBoard is null)
                {
                    //make GBoard
                    GBoard = new GImageArray(this, boardArray, 50, 50, 150, 50, 0, ImagePath);
                    GBoard.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);

                }
                //if GBoard alraedy exists:
                else
                {
                    //update the images using the loaded in values from the file
                    GBoard.UpDateImages(boardArray);
                }

                // save the player names if they are valid
                // (where valid means more than zero characters)
                string whitePlayerName = whiteTextBox.Text;
                string blackPlayerName = blackTextBox.Text;
                // set the game to in progress
                inProgress = true;
                playerTurn = 1;
                //hide/show relevant turn labels:
                blackToPlayImage.Hide();
                whiteToPlayImage.Show();
                //set scores to 2 for game start:
                whiteScore = 2;
                blackScore = 2;
                whiteLabel.Text = whiteScore.ToString();
                blackLabel.Text = blackScore.ToString();
            }

        }

        //event for when exit clicked
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            //if a game has been started:
            if (inProgress == true) {
                //offer the user the option to save
                save(boardArray);

                
            }
            //close either way
            this.Close();
        }

        //event for when about button clicked
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            //shows the precreated about window
            About about = new About();
            about.ShowDialog();
        }

        // method for saving game
        private void save(int[,] boardArray) {
            if (inProgress == true)
            {
                if (MessageBox.Show("Do you want to save?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //assigns a variable for writing the current piece of data to the .txt document
                    //(not used when the data type is already a writable string)
                    string currentWrite;
                    //gets the names from the textboxes again
                    //(this is redundant, but the names were not global to avoid oid unnecessary overwrites)
                    string whitePlayerName = whiteTextBox.Text;
                    string blackPlayerName = blackTextBox.Text;
                    //find file location of where program is being executed
                    saveFile.ShowDialog();
                    //assigns the file name to that the user inputted in the save dialog:
                    string fileName = saveFile.FileName;
                    //creates a .txt file to the user's specified location and name:
                    StreamWriter myOutputStream = File.CreateText(fileName + ".txt");

                    //writing the lines
                    //converts and writes player scores and names:
                    //white:
                    currentWrite = whiteScore.ToString();
                    myOutputStream.WriteLine(currentWrite);
                    myOutputStream.WriteLine(whitePlayerName);
                    //black:
                    currentWrite = blackScore.ToString();
                    myOutputStream.WriteLine(currentWrite);
                    myOutputStream.WriteLine(blackPlayerName);
                    //saves player turn:
                    currentWrite = playerTurn.ToString();
                    myOutputStream.WriteLine(currentWrite);
                    //saves the memory array for the board:
                    //the for loops break the arrays into individual items:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int x = 0; x < 8; x++)
                        {
                            //converts the integer value to a writable string:
                            currentWrite = boardArray[i, x].ToString();
                            //writes the item
                            myOutputStream.WriteLine(currentWrite);
                }
                    }
                    //closes the file
                    myOutputStream.Close();

                }
                else //if the user picked no
                {
                    //display message to show the game hasn't been saved:
                    MessageBox.Show("No game has been saved :)");
                }
            }
            else { //if the game hasn't started:
                //display relevant message to the user:
                MessageBox.Show("You can't save a game you haven't started :)");
            }


        }

        //a method for assigning the values to the original array
        private void listFiller()
        {
            //assigns blank squares to the array
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    boardArray[i, x] = 10;
                }
            }
            //force assign the non-blank initial squares
            boardArray[3, 3] = 1;
            boardArray[4, 3] = 0;
            boardArray[3, 4] = 0;
            boardArray[4, 4] = 1;
        }

        //method for save menu click event
        private void saveGameMenuItem_Click(object sender, EventArgs e)
        {
            //calls saving function
            save(boardArray);
        }

        //method for game restoration
        private void restoreGameMenuItem_Click(object sender, EventArgs e)
        {
            //if a game has been started:
            if (inProgress == true)
            {
                //offer the user the option to save
                save(boardArray);


            }

            //creates local variables to read the name data into:
            string whitePlayerName;
            string blackPlayerName;
            //shows only .txt files as that is the save file type:
            openFile.Filter = "txt files (*.txt)|*.txt";

            //if the file opens successfully:
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //opens the text file the user selected in the file dialog:
                StreamReader myInputStream = File.OpenText(openFile.FileName);
                string currentLine = myInputStream.ReadLine();

                //whitescore
                whiteScore = Convert.ToInt32(currentLine);
                whiteLabel.Text = currentLine;

                //whitename
                currentLine = myInputStream.ReadLine();
                whitePlayerName = currentLine;
                whiteTextBox.Text = whitePlayerName;

                //blackscore
                currentLine = myInputStream.ReadLine();
                blackScore = Convert.ToInt32(currentLine);
                blackLabel.Text = currentLine;

                //blackname
                currentLine = myInputStream.ReadLine();
                blackPlayerName = currentLine;
                blackTextBox.Text = blackPlayerName;

                //playerturn
                currentLine = myInputStream.ReadLine();
                playerTurn = Convert.ToInt32(currentLine);

                //handles the 'to play' images:
                if (playerTurn == 1) //if it's white's turn:
                {
                    whiteToPlayImage.Show();
                    blackToPlayImage.Hide();

                }
                else //if it's black's turn:
                {
                    whiteToPlayImage.Hide();
                    blackToPlayImage.Show();
                }
                //sets up gameboard
                for (int i = 0; i < 8; i++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        //reads and breaksdown the data and assigns it to individual array items:
                        currentLine = myInputStream.ReadLine();
                        boardArray[i, x] = Convert.ToInt32(currentLine);

                    }
                }
                //tempBoard is used to determine whether a 'GBoard' alrady exists
                //for example, if the player opens the application and immediately loads in a game without starting a new game, 'GBoard' will be null
                GImageArray tempBoard = GBoard;
                //if GBoard has not yet been initialised:
                if (tempBoard is null)
                {
                    //make GBoard
                    GBoard = new GImageArray(this, boardArray, 50, 50, 150, 50, 0, ImagePath);
                    GBoard.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);

                }
                //if GBoard alraedy exists:
                else {
                    //update the images using the loaded in values from the file
                    GBoard.UpDateImages(boardArray);
                }
                


            }
            //error catching:
            //if the file is not successfully opened, display an error message:
            else {
                MessageBox.Show("Something went wrong. Please try again! :)");
            }
        }
    }
}
