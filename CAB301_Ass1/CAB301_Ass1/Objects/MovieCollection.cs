using System;
using System.Runtime;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    public class MovieCollection //BST main class
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }

        //Almost all of these work ths same so ill only comment 1. Anything that works different will get a comment.
        //they have varying inputs/outoputs depending on use case. Most return bools for use in conditional statements
        public bool ReplaceInv(string title, int inv) //define function
        {
            if (root != null) //check if the root node isn't null.
            {
                return root.ReplaceInv(title, inv); //call ReplaceInv func in Treenode class on the root
                                                    //
            }
            else //if its null no point in doing anything
            {
                return false;
            }
        }

        public bool BorrowMovie(string title)
        {
            if (root != null)
            {
                return root.BorrowMovie(title);
            }
            else
            {
                return false;
            }
        }

        public bool ReturnMovie(string title)
        {
            if (root != null)
            {
                return root.ReturnMovie(title);
            }
            else
            {
                return false;
            }
        }

        public bool Find(string title)
        {
            if (root != null)
            {
                return root.Find(title);
            }
            else
            {
                return false;
            }
        }

        public Movie FindMovie(string title)
        {
            if (root != null)
            {
                return root.FindMovie(title);
            }
            else
            {
                return null;
            }
        }


        public void Insert(Movie movie)
        {
            if (root != null)
            {
                root.Insert(movie);
            }
            else
            {
                root = new TreeNode(movie);
            }
        }

        public void PrintMovies()
        {
            if (root != null)
                root.PrintMovies();
        }

        public Movie[] ArrayMovies() //this one is the only one that works slightly differently
        {
            if (root != null) {
                root.ArrayMovie(); //calls arraymovie on root which recursivley modifies the TopArray global
                return glob.TopArray; //returns top array to func after its been modified by arraymovie
            }
            return null;
        }
    }
}
