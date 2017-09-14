using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class TreeSort
    {

        public static byte[] treeSort(byte[] data)
        {
            TreeNode root = new TreeNode(data[0], 0);

            for(int i = 1; i < data.Length; i++)
            {
                root.addNode(new TreeNode(data[i], i));
            }

            //Inorder Traversal
            int index = 0;

            bool traversed = false;

            TreeNode nextNode = root;

            while(!traversed)
            {
                if(!nextNode.visited)
                {
                    if (nextNode.left == null)
                    {
                        //Save Value and Pop
                        for (int i = 0; i < nextNode.duplicates + 1; i++)
                        {
                            data[index] = nextNode.value;
                            index++;
                        }

                        nextNode.visited = true;


                        if (nextNode.right == null)
                        {
                            if (nextNode.parentNode == null)
                            {
                                traversed = true;
                            }
                            else
                            {
                                nextNode = nextNode.parentNode;
                            }
                        }
                        else
                        {
                            if (nextNode.right.visited)
                            {
                                nextNode.right = null;
                            }
                            else
                            {
                                nextNode = nextNode.right;
                            }
                        }

                    }
                    else
                    {
                        if (nextNode.left.visited)
                        {
                            nextNode.left = null;
                        }
                        else
                        {
                            nextNode = nextNode.left;
                        }
                    }
                }
                else
                {
                    if (nextNode.parentNode == null)
                    {
                        traversed = true;
                    }
                    else
                    {
                        nextNode = nextNode.parentNode;
                    }
                }
            }

            return data;
        }

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
