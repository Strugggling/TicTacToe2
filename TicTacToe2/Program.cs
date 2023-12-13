using System;



class Program
{
    static string[] position = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    static void MakeBoard()
    {
        Console.WriteLine($"   {position[1]}  |  {position[2]}  |  {position[3]}   ");
        Console.WriteLine("-------------------");
        Console.WriteLine($"   {position[4]}  |  {position[5]}  |  {position[6]}   ");
        Console.WriteLine("-------------------");
        Console.WriteLine($"   {position[7]}  |  {position[8]}  |  {position[9]}   ");
    }

    static void Main(string[] args)
    {

        Console.WriteLine("TicTacToe");
        bool turn = true;
        int chosenPoint = 0;
        bool endGame=false;

        MakeBoard();

        do
        {
            Console.WriteLine("give number");
            chosenPoint = Convert.ToInt32(Console.ReadLine());


                do
                {

                    if(position[chosenPoint] !="x" && position[chosenPoint] !="o")
                    {
                            if (turn == true)
                            {
                                position[chosenPoint] = "x";
                            }
                            else
                            {
                                position[chosenPoint] = "o";
                            }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("CellWasAlreadyUsed");
                        Console.WriteLine("give different number");
                        chosenPoint = Convert.ToInt32(Console.ReadLine());
                    }
                        

                } while (true);


            //change player turn
            if (turn == true)
            {
                turn = false;
            }
            else
            {
                turn = true;
            }

            Console.Clear();
            MakeBoard();

            //endloop(GAME)
            endGame=WinCon(turn, position);
            if (endGame)
            {
                endGameScript(turn);
                break;
            }

        } while (true);

    }

    static bool WinCon(bool who, string[] argument)
    {
        bool winner = false;
        if( argument[1] == argument[5] && argument[9] == argument[5] ||
            argument[3] == argument[5] && argument[5] == argument[7] || 
            argument[1] == argument[4] && argument[4] == argument[7] ||
            argument[2] == argument[5] && argument[5] == argument[8] ||
            argument[3] == argument[6] && argument[6] == argument[9] ||
            argument[1] == argument[2] && argument[2] == argument[3] ||
            argument[4] == argument[5] && argument[5] == argument[6] ||
            argument[7] == argument[8] && argument[8] == argument[9]   )
        {
            winner = true;
            return winner;
        }
        return winner;
    }

    static void endGameScript(bool whichPlayer)
    {
        if (whichPlayer == true)
        {
            Console.WriteLine("player x won");
        }
        else
        {
            Console.WriteLine("player o won");
        }
    }


}
    