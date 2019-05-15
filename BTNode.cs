using System;

namespace BST
{
    class BTNode
    {
        public int val;
        public BTNode left;
        public BTNode right;
        public BTNode(int val)
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }
}