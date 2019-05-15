using System;

namespace BST
{
    class BST
    {
        public BTNode root;
        public BST()
        {
            this.root = null;
        }
        public void Add(int val)
        {
            BTNode squirrel = this.root;
            if (squirrel == null)
            {
                this.root = new BTNode(val);
                return;
            }
            bool done = false;
            while(!done)
            {
                if(squirrel.val >= val)
                {
                    if(squirrel.left == null)
                    {
                        squirrel.left = new BTNode(val);
                        done = true;
                    }
                    else
                    {
                        squirrel = squirrel.left;
                    }
                }
                else
                {
                    if(squirrel.right == null)
                    {
                        squirrel.right = new BTNode(val);
                        done = true;
                    }
                    else
                    {
                        squirrel = squirrel.right;
                    }
                }
            }
        }
    }
}