using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    public class TreeNode
    {
        private Movie movie;
        public Movie Movie //boilerplate :))))))))))
        {
            get 
            { 
                return movie; 
            }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get 
            {
                return rightNode;
            }
            set
            {
                rightNode = value;
            }
        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get
            {
                return leftNode;
            }
            set
            {
                leftNode = value;
            }
        }

        public TreeNode(Movie value)
        {
            movie = value;
        }

        public Movie FindMovie(string title) //finds movie in BST from movie title, returns whole movie object
        {
            TreeNode currentNode = this;

            while (currentNode != null) //while current node isn't null - ie bottom of tree not reached
            {
                if (title == currentNode.movie.title) //checks if title matches
                {
                    return currentNode.movie; //returns movie in node
                }
                else if (String.Compare(currentNode.movie.title, title) <= 0) //string compare to determine if the movie we are looking for is in left or right node
                {
                    currentNode = currentNode.rightNode; //move to right node and while loops again
                }
                else
                {
                    currentNode = currentNode.leftNode; //move to left node and while keeps looping
                }
            }
            return null;
        }

        public bool Find(string title) //is the same as FindMovie, just returns a bool to determine if the movie is in the collection
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (title == currentNode.movie.title)
                {
                    return true;
                }
                else if (String.Compare(currentNode.movie.title, title) <= 0)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return false;
        }
        public bool ReplaceInv(string title, int inv)   //All of these functions are just moditified find functions
        {                                               //this one takes a title and the amount of stock to add to the title
            TreeNode currentNode = this;

            while (currentNode != null) //all of this is the same as find
            {
                if (title == currentNode.movie.title)
                {
                    currentNode.movie.inventory += inv; //except this, which when at the right node adds the input inv to the preexisting inventory
                    return true;
                }
                else if (String.Compare(currentNode.movie.title, title) <= 0)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return false;
        }

        public bool BorrowMovie(string title) //Modified find
        {
            TreeNode currentNode = this;

            while (currentNode != null) //same as above
            {
                if (title == currentNode.movie.title && currentNode.movie.inventory > 0)
                {               //except here
                    currentNode.movie.inventory = currentNode.movie.inventory - 1; //minus 1 from rented movies
                    currentNode.movie.timesBorrowed++;              //iterate the times the movie has been borrowed
                    return true;
                }
                else if (String.Compare(currentNode.movie.title, title) <= 0)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return false;
        }

        public bool ReturnMovie(string title) //modified find
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (title == currentNode.movie.title)
                {
                    currentNode.movie.inventory = currentNode.movie.inventory + 1; //when movie is returned the inventory goes back up
                    return true;
                }
                else if (String.Compare(currentNode.movie.title, title) <= 0)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return false;
        }

        public void Insert(Movie value) //inserts the given movie into the BST in correct order
        {
            if (String.Compare(movie.title, value.title) <= 0) //string compare to determine if movie needs to go on left or right node
            {   
                if (rightNode == null) //check right node is null
                {
                    rightNode = new TreeNode(value); //if it is create a new right node with input value
                }
                else
                {
                    rightNode.Insert(value); //if it isn't null recursivley call the function on the rightnode, process repeates for rightnode tree
                }
            }
            else //compare decides it has to go on left
            {
                if (leftNode == null) //check if node is null
                {
                    leftNode = new TreeNode(value); //create new node on left
                }
                else
                {
                    leftNode.Insert(value); //if not null recursivley call insert, function loops on leftnode tree
                }
            }
        }

        public void PrintMovies() //prints movies to console
        {
            if (leftNode != null)
                leftNode.PrintMovies(); //traverses tree recursivley 

            Console.WriteLine(movie);

            if (rightNode != null)
                rightNode.PrintMovies();
        }

        public void ArrayMovie() //works the same as printmovies but instead of printing adds the movie to a global array using my own .Add function
        {
            if (leftNode != null)
            {
                leftNode.ArrayMovie();
            }

            glob.Add(movie); //add movie to global array using defined .Add

            if (rightNode != null)
            {
                rightNode.ArrayMovie();
            }
        }
    }
}
