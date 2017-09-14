using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class TreeSort
    {


        private class TreeNode
        {
            public TreeNode parentNode;
            public TreeNode left;
            public TreeNode right;

            public bool visited = false;
            public int duplicates = 0;
            public byte value = 0;

            public TreeNode(byte value, int arrayIndex)
            {
                this.value = value;
            }

            public void addNode(TreeNode node)
            {
                bool hasChild = false;
                bool hitBottom = false;

                TreeNode nextNode = this;

                while(!hitBottom)
                {
                    if(node.value == nextNode.value)
                    {
                        nextNode.duplicates++;
                        hitBottom = true;
                    }
                    else if((node.value < nextNode.value))
                    {
                        //Move left
                        hasChild = (nextNode.left == null) ? false : true;

                        if (!hasChild)
                        {
                            //Add
                            nextNode.left = node;
                            node.parentNode = nextNode;
                            hitBottom = true;
                        }
                        else
                        {
                            nextNode = nextNode.left;
                            hitBottom = false;
                        }
                    }
                    else
                    {
                        //Move right
                        hasChild = (nextNode.right == null) ? false : true;

                        if (!hasChild)
                        {
                            //Add
                            nextNode.right = node;
                            node.parentNode = nextNode;
                            hitBottom = true;
                        }
                        else
                        {
                            nextNode = nextNode.right;
                            hitBottom = false;
                        }
                    }
                }


            }
        }

    }
}
